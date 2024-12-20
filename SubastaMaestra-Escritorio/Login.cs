﻿using Microsoft.Extensions.DependencyInjection;
using SubastaMaestra.Data.Interfaces;
using SubastaMaestra.Models.DTOs.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubastaMaestra_Escritorio
{
    public partial class Login : Form
    {
        private IUserRepository _userRepository;
        private LoginRequestDTO _loginRequestDTO;
        public Login(IUserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {

            // Validar entradas
            if (string.IsNullOrWhiteSpace(textBoxUsuario.Text) || string.IsNullOrWhiteSpace(textBoxContraseña.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar formato del email
            if (!IsValidEmail(textBoxUsuario.Text))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar longitud mínima de la contraseña (8 caracteres)
            if (textBoxContraseña.Text.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var loginDTO = new LoginRequestDTO
            {
                Email = textBoxUsuario.Text,
                Password = textBoxContraseña.Text
            };


            var result = await ApiHelper.PostLoginAsync(ApiUrl.LocalURL + "login", loginDTO);
            //var result = await _userRepository.ValidateUserAsync(loginDTO);
            if (result.success == true)
            {
                MessageBox.Show("Inicio de sesión exitoso");

                // Abrir el formulario principal (Home) y cerrar el formulario de Login
                var homeForm = Program.ServiceProvider.GetRequiredService<Home>();
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error: " + result.message);
            }
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            var registerForm = Program.ServiceProvider.GetRequiredService<Register>();
            registerForm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
