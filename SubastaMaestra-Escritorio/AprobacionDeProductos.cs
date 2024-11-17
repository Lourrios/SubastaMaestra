using SubastaMaestra.Entities.Enums;
using SubastaMaestra.Models.DTOs.Product;
using SubastaMaestra.Models.DTOs.Sale;
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
    public partial class AprobacionDeProductos : Form
    {
        private List<ProductDTO> _productDto;
        public AprobacionDeProductos()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadSolicitudes();
        }
        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Name = "Id"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Nombre",
                Name = "Name"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Condition",
                HeaderText = "Condición",
                Name = "Condition"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InitialPrice",
                HeaderText = "Precio Inicial",
                Name = "InitialPrice"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FinalPrice",
                HeaderText = "Precio Final",
                Name = "FinalPrice"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ImgUrl",
                HeaderText = "URL Imagen",
                Name = "ImgUrl"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreatedAt",
                HeaderText = "Fecha de Creación",
                Name = "CreatedAt"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Descripción",
                Name = "Description"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CurrentState",
                HeaderText = "Estado Actual",
                Name = "CurrentState"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumberOfOffers",
                HeaderText = "Número de Ofertas",
                Name = "NumberOfOffers"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CategoryId",
                HeaderText = "ID Categoría",
                Name = "CategoryId"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SellerId",
                HeaderText = "ID Vendedor",
                Name = "SellerId"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SellerName",
                HeaderText = "Nombre Vendedor",
                Name = "SellerName"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BuyerId",
                HeaderText = "ID Comprador",
                Name = "BuyerId"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BuyerName",
                HeaderText = "Nombre Comprador",
                Name = "BuyerName"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "AuctionId",
                HeaderText = "ID Subasta",
                Name = "AuctionId"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DeliveryCondition",
                HeaderText = "Condición de Entrega",
                Name = "DeliveryCondition"
            });
        }
        private async void LoadSolicitudes()
        {
            var (result, error) = await ApiHelper.GetAsync<List<ProductDTO>>(ApiUrl.LocalURL + "api/Product/list");

            if (result != null)
            {
                // Filtrar los productos en estado pendiente
                _productDto = result.Where(p => p.CurrentState == ProductState.Pending).ToList();

                if (_productDto.Any())
                {
                    dataGridView1.DataSource = _productDto;
                }
                else
                {
                    MessageBox.Show("No hay productos en estado pendiente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show($"{error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AprobacionDeProductos_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int productId = (int)selectedRow.Cells["Id"].Value;

                var result = await ApiHelper.PostAsync(ApiUrl.LocalURL + $"api/Product/habilitar/{productId}", null);

                if (!string.IsNullOrEmpty(result) && !result.Contains("Error"))
                {
                    selectedRow.Cells["CurrentState"].Value = ProductState.Active;
                    MessageBox.Show("Producto aprobado correctamente.");
                }
                else
                {
                    MessageBox.Show($"Error al aprobar el producto: {result}");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto para aprobar.");
            }
        }

        private async void buttonRechazar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int productId = (int)selectedRow.Cells["Id"].Value;

                var result = await ApiHelper.PostAsync(ApiUrl.LocalURL + $"api/Product/deshabilitar/{productId}", null);

                if (!string.IsNullOrEmpty(result) && !result.Contains("Error"))
                {
                    selectedRow.Cells["CurrentState"].Value = ProductState.Disabled;
                    MessageBox.Show("Producto rechazado correctamente.");
                }
                else
                {
                    MessageBox.Show($"Error al rechazar el producto: {result}");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un producto para rechazar.");
            }
        }

    }
}

