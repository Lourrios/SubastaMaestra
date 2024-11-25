using CloudinaryDotNet;
using SubastaMaestra.Data.Interfaces;
using SubastaMaestra.Entities.Core;
using SubastaMaestra.Entities.Enums;
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
    public partial class Editar : Form
    {

        private readonly IAuctionRepository _auctionRepository;
        private AuctionDTO _subastaSeleccionada;
        private AuctionUpdateDTO _subasta;
        public Editar(IAuctionRepository auctionRepository, AuctionDTO subastaSeleccionada)
        {
            _auctionRepository = auctionRepository;
            _subastaSeleccionada = subastaSeleccionada;

            InitializeComponent();
            CargarDatosSubasta();
        }

        private void CargarDatosSubasta()
        {
            textBoxTitle.Text = _subastaSeleccionada.Title;
            dateTimePickerStar.Value = _subastaSeleccionada.StartDate;
            dateTimePickerFinish.Value = _subastaSeleccionada.FinishDate;

        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {

            _subasta = new AuctionUpdateDTO();
            _subasta.Id= _subastaSeleccionada.Id;
            _subasta.Title = textBoxTitle.Text;
            _subasta.StartDate = dateTimePickerStar.Value;
            _subasta.FinishDate = dateTimePickerFinish.Value;

            var resul = _subasta.FinishDate - _subasta.StartDate;

            if (resul < TimeSpan.FromDays(1))
            {
                MessageBox.Show("La subasta debe tener al menos un dia de duracion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = await ApiHelper.PostEditarAuctionAsync<AuctionUpdateDTO>(ApiUrl.LocalURL + $"api/Auction/edit/{_subasta.Id}", _subasta);
            // Llamar al repositorio para actualizar la subasta
            //var resultado = await _auctionRepository.EditAuctionAsync(_subasta, _subastaSeleccionada.Id);

            if (resultado.result == null )
            {
                MessageBox.Show("Subasta actualizada con éxito.");
                this.DialogResult = DialogResult.OK; // Indicar que la acción fue exitosa
                this.Close(); // Cerrar el formulario
            }
            else
            {
                MessageBox.Show($"Error al actualizar la subasta: {resultado.errorMessage}");
            }
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerStar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Editar_Load(object sender, EventArgs e)
        {

        }
    }
}
    

