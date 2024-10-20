using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SubastaMaestra.Data.Implements;
using SubastaMaestra.Data.Interfaces;
using SubastaMaestra.Entities.Core;
using SubastaMaestra.Entities.Enums;
using SubastaMaestra.Models.DTOs;
using SubastaMaestra.Models.DTOs.Auction;
namespace SubastaMaestra_Escritorio
{
    public partial class CrearSubasta : Form
    {

        public CrearSubasta()
        {


            InitializeComponent();
        }
        // Lista global para almacenar las subastas
        private List<Auction> listaSubastas = new List<Auction>();

        // Clase Auction que representará una subasta
        public class Auction
        {
            public string NombreSubasta { get; set; }
            public DateTime FechaInicio { get; set; }
            public DateTime FechaCierre { get; set; }
            public string Estado { get; set; }
        }



        //private async Task button1_Click(object sender, EventArgs e)
        //{
        //    // Crear una nueva subasta con los datos ingresados
        //    var nuevaSubasta = new AuctionCreateDTO()
        //    {
        //        Title = textNombreSubasta.Text,
        //        ////StartDate = dateTimePickerInicio.Value,
        //        FinishDate = dateTimePickerCierre.Value,
        //        //PaymentMethod = textFormaPago.Text, // Asume que agregas un TextBox para la forma de pago
        //        //DeliveryMethod = textModoEntrega.Text // Asume que agregas un TextBox para el modo de entrega
        //    };

        //    // Aquí se llama al método del repositorio para guardar la subasta (lógica pendiente de implementar)
        //    var resultado = await _auctionRepository.CreateAuctionAsync(nuevaSubasta);

        //    if (resultado > 0)
        //    {
        //        MessageBox.Show("Subasta guardada con éxito.");

        //        // Refrescar el DataGridView con las subastas abiertas
        //        await ActualizarSubastasAbiertas();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Error al guardar la subasta.");
        //    }

        //    // Limpiar los campos después de guardar
        //    LimpiarFormulario();
        //}


        private void LimpiarFormulario()
        {
            textBoxNombre.Text = "";
            dateTimePickerInicio.Value = DateTime.Today;
            dateTimePickerCierre.Value = DateTime.Now;
            Estado.Text =" ";
        }

        //private async Task ActualizarSubastasAbiertas()
        //{
        //    // Crear una lista ficticia de subastas
        //    var listaSubastas = new List<AuctionDTO>()
        //{
        //    new AuctionDTO { Title = "Subasta 1", StartDate = DateTime.Now.AddDays(-2), FinishDate = DateTime.Now.AddDays(2)},
        //    new AuctionDTO { Title = "Subasta 2", StartDate = DateTime.Now.AddDays(-10), FinishDate = DateTime.Now.AddDays(-5)}
        //};

        //    // Recargar el DataGridView con la lista ficticia
        //    dataGridView1.DataSource = null; // Limpiar el DataGridView
        //    dataGridView1.DataSource = listaSubastas; // Cargar la lista ficticia

        //    // Establecer qué columnas mostrar en el DataGridView
        //    if (dataGridView1.Columns["Products"] != null)
        //    {
        //        dataGridView1.Columns["Products"].Visible = false; // Ocultar columna 'Products' si existe
        //    }
        //}




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //// Obtener la subasta seleccionada del DataGridView
            //var subastaSeleccionada = (AuctionDTO)dataGridView1.CurrentRow.DataBoundItem;

            //// Cargar los datos de la subasta seleccionada en los controles
            //textNombreSubasta.Text = subastaSeleccionada.Title;
            //dateTimePickerInicio.Value = subastaSeleccionada.StartDate;
            //dateTimePickerCierre.Value = subastaSeleccionada.FinishDate;

        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Seleccionar la subasta de la fila seleccionada
                var subastaSeleccionada = (Auction)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                // Cargar los datos en los campos para modificación
                textBoxNombre.Text = subastaSeleccionada.NombreSubasta;
                dateTimePickerInicio.Value = subastaSeleccionada.FechaInicio;
                dateTimePickerCierre.Value = subastaSeleccionada.FechaCierre;
                Estado.Text = subastaSeleccionada.Estado;
            }
        }



        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            // Crear una nueva subasta con los datos ingresados
            var nuevaSubasta = new Auction
            {
                NombreSubasta = textBoxNombre.Text,
                FechaInicio = dateTimePickerInicio.Value,
                FechaCierre = dateTimePickerCierre.Value,
                Estado = SubastaMaestra.Entities.Enums.AuctionState.Pending.ToString(),
            };

            // Agregar la nueva subasta a la lista
            listaSubastas.Add(nuevaSubasta);

            // Refrescar el DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaSubastas;

            // Limpiar los campos después de guardar
            LimpiarFormulario();

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            // Obtener la subasta seleccionada del DataGridView
            var subastaSeleccionada = (Auction)dataGridView1.CurrentRow.DataBoundItem;

            // Actualizar los valores de la subasta con los datos ingresados
            subastaSeleccionada.NombreSubasta = textBoxNombre.Text;
            subastaSeleccionada.FechaInicio = dateTimePickerInicio.Value;
            subastaSeleccionada.FechaCierre = dateTimePickerCierre.Value;
            //  subastaSeleccionada.Estado = textEstado.Text;

            // Refrescar el DataGridView para mostrar los cambios
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaSubastas;

            // Limpiar los campos después de modificar
            LimpiarFormulario();

        }

        private void CrearSubasta_Load(object sender, EventArgs e)
        {

        }
    }
}


