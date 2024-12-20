﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SubastaMaestra.Data.Interfaces;
using SubastaMaestra.Data;
using SubastaMaestra.Entities.Core;
using SubastaMaestra.Models.DTOs.User;
using SubastaMaestra.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubastaMaestra.Models.DTOs.Reports;

namespace SubastaMaestra.Data.Implements
{
    public class UserRepository : IUserRepository
    {
        private readonly SubastaContext _subastaContext;
        private readonly IMapper _mapper;
        public UserRepository(SubastaContext subastaContext, IMapper mapper) {
            _subastaContext = subastaContext;
            _mapper = mapper;
        }
        public async Task<OperationResult<int>> RegisterUserAsync(UserCreateDTO userDTO)
        {
            bool result = await UsuarioExist(userDTO.Email);
            if (result)
            {
                return new OperationResult<int> { Success=false, Message="Email ya existe", Value =0};
            }
            User user = _mapper.Map<User>(userDTO);
            user.RolId =  await _subastaContext.Roles
                                    .Where(r => r.Name == "user")
                                    .Select(r => r.Id)
                                    .FirstOrDefaultAsync();

            try
            {
                user.Password = BCrypt.Net.BCrypt.HashPassword(userDTO.Password);
                await _subastaContext.Users.AddAsync(user);
                await _subastaContext.SaveChangesAsync();
                return new OperationResult<int> { Success = true, Message = "Registro exitoso" };
            } catch (Exception ex) {
                return new OperationResult<int> { Success = false, Message = "Error de registro", Value= -1 };
            }
        }

        public async Task<bool> UsuarioExist(string email)
        {
            User userExist = await _subastaContext.Users.FirstOrDefaultAsync(u => u.Email.Equals(email));
            if (userExist == null)
            {
                return false;
            }
            return true;
        }

        public async Task<OperationResult<User>> ValidateUserAsync(LoginRequestDTO loginRequestDTO)
        {
            User user = await _subastaContext.Users.FirstOrDefaultAsync(u=>u.Email.Equals(loginRequestDTO.Email));
            if (user != null)
            {
                bool isValidPassword = BCrypt.Net.BCrypt.Verify(loginRequestDTO.Password, user.Password);
                if (isValidPassword)
                {
                    return new OperationResult<User> { Success = true, Message = "Inicio de sesión correcto", Value = user };
                }
            }
            return new OperationResult<User> { Success = false, Message = "Email no registrado"};
        }

        public async Task<List<MostActiveUserDTO>> ObtenerUsuariosMasActivos()
        {

            // Consulta en Entity Framework
               var activeBidders = _subastaContext.Users
                .Join(
                    _subastaContext.Bids,           // Tabla a unir
                    user => user.Id,          // Clave primaria (Users)
                    bid => bid.BidderId,      // Clave foránea (Bids)
                    (user, bid) => new        // Proyección intermedia
                    {
                        UserId = user.Id,
                        UserName = user.Name,
                        OfferDate = bid.OfferDate,
                        Price = bid.Price,
                        ProductId = bid.ProductId
                    }
                )
                .GroupBy(
                    x => new { x.UserId, x.UserName } // Agrupamos por UserId y UserName
                )
                .Where(g => g.Count() >= 1)          // Filtro similar a HAVING
                .Select(g => new MostActiveUserDTO   // Proyección final hacia el DTO
                {
                    UserId = g.Key.UserId,
                    UserName = g.Key.UserName,
                    TotalBids = g.Count(),
                    HighestBidAmount = g.Max(x => x.Price),
                    HighestBidDate = g
                        .Where(x => x.Price == g.Max(y => y.Price)) // Filtramos el bid más alto
                        .Select(x => x.OfferDate)                   // Seleccionamos su fecha
                        .FirstOrDefault(),                          // Obtenemos el primer valor
                    ProductName = g
                        .Where(x => x.Price == g.Max(y => y.Price)) // Filtramos el bid más alto
                        .Join(
                            _subastaContext.Products,      // Join con Products
                            bid => bid.ProductId,    // Clave foránea en Bids
                            product => product.Id,   // Clave primaria en Products
                            (bid, product) => product.Name // Obtenemos el nombre del producto
                        )
                        .FirstOrDefault()            // Seleccionamos el nombre del producto
                })
                .OrderByDescending(x => x.TotalBids) // Ordenar por número de ofertas
                .Take(15)                             // Top 15
                .ToList();

            return activeBidders;

        }
    }
}
