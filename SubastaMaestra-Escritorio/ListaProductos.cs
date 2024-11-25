using AutoMapper;
using SubastaMaestra.Data.Implements;
using SubastaMaestra.Data.Interfaces;
using SubastaMaestra.Entities.Core;
using SubastaMaestra.Models.DTOs.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubastaMaestra_Escritorio
{
    public partial class ListaProductos : Form
    {
        private  IProductRepository _productRepository;
        private IBidRepository _bidRepository;
        private  IMapper _mapper;
        private ProductDTO productDTO;
        public ListaProductos(IProductRepository productRepository,IBidRepository bidRepository, IMapper mapper)
        {
            InitializeComponent();
            _productRepository = productRepository;
            _bidRepository = bidRepository;
            _mapper = mapper;
            //CargarProducto();


        }

        private async void ListaProductos_Load(object sender, EventArgs e)
        {
            // Configuración de las columnas del DataGridView
            dataGridView1.Columns.Add("Id", "ID Producto");
            dataGridView1.Columns.Add("Name", "Nombre");
            dataGridView1.Columns.Add("InitialPrice", "Precio Inicial");
            dataGridView1.Columns.Add("FinalPrice", "Precio Final");
            dataGridView1.Columns.Add("Condition", "Condición");
            dataGridView1.Columns.Add("Category", "Categoría");
            dataGridView1.Columns.Add("SellerName", "Vendedor");
            dataGridView1.Columns.Add("AuctionNumber", "Numero de Subasta");
            dataGridView1.Columns.Add("AuctionState", "Estado de Subasta");
            dataGridView1.Columns.Add("Description", "Descripción");

            await CargarProducto();
        }



        private async Task CargarProducto()
        {
            // Usa ApiHelper para obtener la lista de productos
            var resultado = await ApiHelper.GetListAsync<ProductDTO>(ApiUrl.LocalURL + "api/Product/list");

            if (resultado != null)
            {
                // Limpiar el DataGridView antes de agregar nuevos datos
                dataGridView1.Rows.Clear();

                // Iterar sobre los productos y agregarlos al DataGridView
                foreach (var producto in resultado)
                {
                    dataGridView1.Rows.Add(
                        producto.Id,  // Suponiendo que ProductId es la propiedad del ID
                        producto.Name,
                        producto.InitialPrice,
                        producto.FinalPrice,
                        producto.Condition?.ToString(),
                        producto.CategoryId,
                        producto.SellerName??"-",
                        producto.AuctionId,
                        producto.Auction?.CurrentState,

                        producto.Description
                    );
                }
            }
            else
            {
                MessageBox.Show("Error al cargar productos: No se pudo obtener la lista de productos.");
            }

            //var resultado = await _productRepository.GetAllProductsAsync();
            //if (resultado.Success && resultado.Value != null)
            //{
            //    // Limpiar el DataGridView antes de agregar nuevos datos
            //    dataGridView1.Rows.Clear();

            //    // Iterar sobre los productos y agregarlos al DataGridView
            //    foreach (var producto in resultado.Value)
            //    {
            //        // Agregar una fila al DataGridView con los datos del producto
            //        dataGridView1.Rows.Add(
            //            producto.Name,
            //            producto.InitialPrice,
            //            producto.FinalPrice,
            //            producto.Condition?.ToString(),
            //            producto.CategoryId,
            //            producto.SellerId,
            //            producto.AuctionId,
            //            producto.Auction?.State.ToString(),
            //            producto.Description
            //        );
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Error al cargar productos: " + resultado.Message);
            //}

            //    var result = await _productRepository.GetProductsByAuctionAsync(auctionId);

            //    if (result.Success)
            //    {
            //        // Si la operación es exitosa, asigna los productos al DataGridView
            //        dataGridView1.DataSource = result.Value;  // Esto establece los productos en el DataGridView
            //    }
            //    else
            //    {
            //        // Muestra un mensaje si no se encontraron productos
            //        MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

        }
            //}

        private void buttonOferentes_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el ID del producto de la fila seleccionada
                int idProducto = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                // Crear instancia del formulario ListaDeOferentes y pasarle el ID del producto
                var listaDeOferentesForm = new ListaDeOferentes(_bidRepository, idProducto);
                listaDeOferentesForm.Show();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un producto para ver las ofertas.");
            }
        }
    }
    }
