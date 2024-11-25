using SubastaMaestra.Data.Interfaces;
using SubastaMaestra.Models.DTOs.User;
using SubastaMaestra.Models.Utils;
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
        private int _productId;
        public ListaDeOferentes(IBidRepository bidRepository, int productId)
        {

            InitializeComponent();
            _bidRepository = bidRepository;
            _productId = productId;
            //dataGridViewOfertas.AutoGenerateColumns = true;
            ConfigurarDataGridView();
            LoadOffers();
        }

        private async void LoadOffers()
        {

            var (resultado, error) = await ApiHelper.GetAsync<OperationResult<List<BidderDTO>>>(ApiUrl.LocalURL + $"product/{_productId}/oferentes");
           // var resultado = await _bidRepository.ObtenerOfertasPorProducto(_productId);


            if (resultado.Success)
            {
                dataGridViewOfertas.DataSource = resultado.Value;
                MessageBox.Show($"Se cargaron {resultado.Value.Count} ofertas.", "Resultado");
            }
            else
            {
                MessageBox.Show(resultado.Message, "Resultado");
                dataGridViewOfertas.DataSource = null;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void ConfigurarDataGridView()
        {
            // Configuración inicial del DataGridView
            dataGridViewOfertas.AutoGenerateColumns = false;
            dataGridViewOfertas.AllowUserToAddRows = false;
            dataGridViewOfertas.ReadOnly = true;
            dataGridViewOfertas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Columna para el nombre del oferente (Bidder.UserName)
            dataGridViewOfertas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BidderId", // Mapea la propiedad del DTO
                HeaderText = "Oferente",
                Width = 150,
                Name = "BidderId"
            });

            // Columna para el monto de la oferta (Price)
            dataGridViewOfertas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price", // Mapea la propiedad del DTO
                HeaderText = "Monto de Oferta ($)",
                Width = 100,
                Name = "Price",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" } // Muestra como moneda
            });

            // Columna para la fecha de la oferta (OfferDate)
            dataGridViewOfertas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OfferDate", // Mapea la propiedad del DTO
                HeaderText = "Fecha de la Oferta",
                Width = 150,
                Name = "OfferDate",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm:ss" } // Formato de fecha
            });

            // Columna para el método de pago (PaymentMethods)
            dataGridViewOfertas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PaymentMethod", // Mapea la propiedad del DTO
                HeaderText = "Método de Pago",
                Width = 150,
                Name = "PaymentMethod"
            });

            

        }



    }
}

