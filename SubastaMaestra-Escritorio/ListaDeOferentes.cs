using SubastaMaestra.Data.Interfaces;
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
    public partial class ListaDeOferentes : Form
    {

        private readonly IBidRepository _bidRepository;
        public ListaDeOferentes(IBidRepository bidRepository)
        {

            InitializeComponent();
            _bidRepository = bidRepository;
            dataGridViewOfertas.AutoGenerateColumns = true;
            //ConfigurarDataGridView();
        }

        //private void ConfigurarDataGridView()
        //{
        //    dataGridViewOfertas.AutoGenerateColumns = false;

        //    // Columna para el nombre del oferente
        //    dataGridViewOfertas.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        DataPropertyName = "UserName", // Asegúrate de que este sea el nombre correcto en tu DTO
        //        HeaderText = "Oferente",
        //        Width = 150
        //    });

        //    // Columna para el monto de la oferta
        //    dataGridViewOfertas.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        DataPropertyName = "Amount", // Asegúrate de que este sea el nombre correcto en tu DTO
        //        HeaderText = "Monto de Oferta",
        //        Width = 100
        //    });

        //    // Columna para la fecha de la oferta
        //    dataGridViewOfertas.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        DataPropertyName = "CreatedAt", // Asegúrate de que este sea el nombre correcto en tu DTO
        //        HeaderText = "Fecha de la Oferta",
        //        Width = 150
        //    });

        //}


        private async void buttonOfertas_Click(object sender, EventArgs e)
        {
            int idProducto;

            // Validar que el ID del producto sea válido
            if (!int.TryParse(textBoxIdProd.Text, out idProducto))
            {
                MessageBox.Show("Por favor ingrese un ID de producto válido.", "Error");
                return;
            }

            // Llamar al servicio para obtener las ofertas por producto
            var resultado = await _bidRepository.ObtenerOfertasPorProducto(idProducto);

            if (resultado.Success)
            {
                // Cargar los datos en el DataGridView
                dataGridViewOfertas.DataSource = resultado.Value;
                MessageBox.Show($"Se cargaron {resultado.Value.Count} ofertas.", "Resultado");
            }
            else
            {
                MessageBox.Show(resultado.Message, "Resultado");
                dataGridViewOfertas.DataSource = null; // Limpiar el DataGridView si no hay ofertas
            }
        }
    }
    }

