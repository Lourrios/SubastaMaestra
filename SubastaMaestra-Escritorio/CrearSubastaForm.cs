using SubastaMaestra.Data.Interfaces;
using SubastaMaestra.Models.DTOs.Auction;
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
    public partial class CrearSubastaForm : Form
    {
        private readonly IAuctionRepository _auctionRepository;
        public CrearSubastaForm(IAuctionRepository auctionRepository)


        {
            _auctionRepository = auctionRepository;
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Crear un objeto con los datos de la nueva subasta
            var nuevaSubasta = new AuctionCreateDTO
            {
                Title = textBoxTitle.Text,
                StartDate = dateTimePickerStar.Value,
                FinishDate = dateTimePickerFinish.Value
            };

            // Llamar al repositorio para crear la subasta
            var resultado = await _auctionRepository.CreateAuctionAsync(nuevaSubasta);

            if (resultado.Success)
            {
                MessageBox.Show("Subasta creada con éxito.");
                this.DialogResult = DialogResult.OK; // Indicar que la acción fue exitosa
                this.Close(); // Cerrar el formulario
            }
            else
            {
                MessageBox.Show($"Error al crear la subasta: {resultado.Message}");
            }
        }
    }
}
    