using SubastaMaestra.Data.Interfaces;
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
            comboBoxState.DataSource = Enum.GetValues(typeof(AuctionState)); // Cargar enum AuctionState
            comboBoxState.SelectedItem = _subastaSeleccionada.State;
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            _subastaSeleccionada.Title = textBoxTitle.Text;
            _subastaSeleccionada.StartDate = dateTimePickerStar.Value;
            _subastaSeleccionada.FinishDate = dateTimePickerFinish.Value;
            _subastaSeleccionada.State = (AuctionState)comboBoxState.SelectedItem;

            // Llamar al repositorio para actualizar la subasta
            var resultado = await _auctionRepository.EditAuctionAsync(_subastaSeleccionada,_subastaSeleccionada.Id);

            if (resultado.Success)
            {
                MessageBox.Show("Subasta actualizada con éxito.");
                this.DialogResult = DialogResult.OK; // Indicar que la acción fue exitosa
                this.Close(); // Cerrar el formulario
            }
            else
            {
                MessageBox.Show($"Error al actualizar la subasta: {resultado.Message}");
            }
        }
    }
}
    

