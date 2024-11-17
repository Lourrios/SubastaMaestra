using SubastaMaestra.Data.Interfaces;
using SubastaMaestra.Entities.Enums;
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
    public partial class Register : Form
    {
        private IUserRepository _userRepository;
        private UserDTO _userDTO;
        public Register(IUserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            CargarCombos();
        }

        private void CargarCombos()
        {
            // Cargar los valores del enum DocumType en comboBoxTipoDoc
            comboBoxTipoDoc.DataSource = Enum.GetValues(typeof(DocumType));

            // Cargar los valores del enum PersonType en comboBoxTipoPersona
            comboBoxTipoPersona.DataSource = Enum.GetValues(typeof(PersonType));
        }


        private async void buttonRegistrar_Click(object sender, EventArgs e)
        {
            var userDTO = new UserCreateDTO()
            {
                Name = textBoxNombre.Text,
                Email = textBoxEmail.Text,
                DocumentType = (DocumType)comboBoxTipoDoc.SelectedItem,
                DocumentNumber = textBoxNumDoc.Text,
                PhoneNumber = textBoxTelefono.Text,
                Password = textBoxContraseña.Text,
                PersonType = (PersonType)comboBoxTipoPersona.SelectedItem
            };

            var result = await _userRepository.RegisterUserAsync(userDTO);

            if (result.Success)
            {
                MessageBox.Show("Registro exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

