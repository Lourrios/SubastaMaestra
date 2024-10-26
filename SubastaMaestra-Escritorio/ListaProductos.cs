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
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private ProductDTO productDTO;
        public ListaProductos(IProductRepository productRepository, IMapper mapper)
        {
            InitializeComponent();
            _productRepository = productRepository;
            _mapper = mapper;
            //CargarProducto();


        }

        private async void ListaProductos_Load(object sender, EventArgs e)
        {
            // Configuración de las columnas del DataGridView
            dataGridView1.Columns.Add("Name", "Nombre");
            dataGridView1.Columns.Add("InitialPrice", "Precio Inicial");
            dataGridView1.Columns.Add("FinalPrice", "Precio Final");
            dataGridView1.Columns.Add("Condition", "Condición");
            dataGridView1.Columns.Add("Category", "Categoría");
            dataGridView1.Columns.Add("Seller", "Vendedor");
            dataGridView1.Columns.Add("AuctionNumber", "Numero de Subasta");
            dataGridView1.Columns.Add("AuctionState", "Estado de Subasta");
            dataGridView1.Columns.Add("Description", "Descripción");

            await CargarProducto();
        }



        private async Task CargarProducto()
        {
            var resultado = await _productRepository.GetAllProductsAsync();
            if (resultado.Success && resultado.Value != null)
            {
                // Limpiar el DataGridView antes de agregar nuevos datos
                dataGridView1.Rows.Clear();

                // Iterar sobre los productos y agregarlos al DataGridView
                foreach (var producto in resultado.Value)
                {
                    // Agregar una fila al DataGridView con los datos del producto
                    dataGridView1.Rows.Add(
                        producto.Name,
                        producto.InitialPrice,
                        producto.FinalPrice,
                        producto.Condition?.ToString(),
                        producto.CategoryId,
                        producto.SellerId,
                        producto.AuctionId,
                        producto.Auction?.State.ToString(),
                        producto.Description
                    );
                }
            }
            else
            {
                MessageBox.Show("Error al cargar productos: " + resultado.Message);
            }

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
            //}

        }
    }
}