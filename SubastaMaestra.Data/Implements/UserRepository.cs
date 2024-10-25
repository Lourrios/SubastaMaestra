﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SubastaMaestra.Data.Interfaces;
using SubastaMaestra.Data.SubastaMaestra.Data;
using SubastaMaestra.Entities.Core;
using SubastaMaestra.Models.DTOs.User;
using SubastaMaestra.Models.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<OperationResult<int>> ValidateUserAsync(string email, string password)
        {
            User user = await _subastaContext.Users.FirstOrDefaultAsync(u=>u.Email.Equals(email));
            if (user != null)
            {
                bool isValidPassword = BCrypt.Net.BCrypt.Verify( password, user.Password);
                if (isValidPassword)
                {
                    return new OperationResult<int> { Success = true, Message = "Inicio de sesión correcto" };
                }
            }
            return new OperationResult<int> { Success = false, Message = "Email no registrado" };
        }
    }
}
