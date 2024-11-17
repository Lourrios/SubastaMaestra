using iTextSharp.text.pdf;
using iTextSharp.text;
using SubastaMaestra.Data.Interfaces;
using SubastaMaestra.Models.DTOs.Auction;
using SubastaMaestra.Models.DTOs.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

using System.IO;
using SubastaMaestra.Models.DTOs.Sale;
using SubastaMaestra.Models.Utils;
using SubastaMaestra.Entities.Enums;

namespace SubastaMaestra_Escritorio
{
    public partial class InformeProductosVendidos : Form
    {
        private readonly IProductRepository _productRepository;
        private readonly IAuctionRepository _auctionRepository;
        private List<SaleDTO> _prodVendidos;
        private List<AuctionDTO> _auctions;
        private List<SaleDTO> _ventasFiltradas;
        public InformeProductosVendidos(IProductRepository productRepository, IAuctionRepository auctionRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
            _auctionRepository = auctionRepository;


        }

        private async void InformeProductosVendidos_Load(object sender, EventArgs e)
        {

            var (result, error) = await ApiHelper.GetAsync<OperationResult<List<AuctionDTO>>>(ApiUrl.LocalURL + "api/Auction/list");
            

            if (result.Value != null)
            {
                // Filtra solo las subastas cerradas(por ejemplo, con State = 0)
                var closedAuctions = result.Value.Where(a => a.State == AuctionState.Closed).ToList();

                comboBox1.DataSource = closedAuctions; // result es List<AuctionDTO>
                comboBox1.DisplayMember = "Title";
                comboBox1.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show($"Error al obtener las subastas:" +
                    $"{error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            var (result2, error2) = await ApiHelper.GetAsync<List<SaleDTO>>(ApiUrl.LocalURL + "list");

            if (result2 != null)
            {
                // todas las ventas
                _prodVendidos = result2;
            }
            else
            {
                MessageBox.Show($"{error2}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue is int auctionId && _prodVendidos != null)
            {


                _ventasFiltradas = _prodVendidos.Where(sale =>sale.Product != null &&  sale.Product.AuctionId == auctionId).ToList();


                if (_ventasFiltradas.Any())
                {
                    // Muestra los productos filtrados
                    DisplayProducts();

                    // Guarda el informe en PDF con los productos filtrados

                }


            }
        }
        public async Task LoadSales()
        {

        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            GuardarInformePDF();
          
        }


        private void DisplayProducts()
        {
            dataGridView1.DataSource = _ventasFiltradas.Select(p => new
            {
                Producto = p.Product?.Name,
                Vendedor = p.Seller.Name,
                FechaVenta = p.SaleDate,
                MontoTotal = p.Amount,
                MontoVendedor = p.Amount - p.Deduccion,
                MontoEmpresa = p.Deduccion
            }).ToList();
        }

        private void GuardarInformePDF()
        {
            if (_ventasFiltradas == null || !_ventasFiltradas.Any())
            {
                MessageBox.Show("No hay productos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF Files|*.pdf", FileName = "InformeProductosVendidos.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            Document doc = new Document(PageSize.A4);
                            PdfWriter.GetInstance(doc, fs);
                            doc.Open();

                            // Título
                            doc.Add(new Paragraph("Informe de Productos Vendidos"));
                            doc.Add(new Paragraph(" ")); // Espacio

                            // Tabla PDF
                            PdfPTable table = new PdfPTable(6);
                            table.WidthPercentage = 100;
                            table.SetWidths(new float[] { 2, 2, 2, 2, 2, 2 });

                            // Encabezados
                            table.AddCell("Producto");
                            table.AddCell("Vendedor");
                            table.AddCell("Fecha Venta");
                            table.AddCell("Monto Total");
                            table.AddCell("Monto Vendedor");
                            table.AddCell("Monto Empresa");

                            // Datos de los productos
                            foreach (var product in _ventasFiltradas)
                            {
                                table.AddCell(product.Product?.Name ?? ""); // Producto
                                table.AddCell(product.Seller?.Name ?? "");  // Vendedor
                                table.AddCell(product.SaleDate.ToString("dd/MM/yyyy HH:mm:ss")); // Fecha de Venta
                                table.AddCell(product.Amount.ToString("C")); // Monto Total

                                var montoVendedor = product.Amount - product.Deduccion;
                                table.AddCell(montoVendedor?.ToString("C")); // Monto Vendedor

                                table.AddCell(product.Deduccion?.ToString("C")); // Monto Empresa
                            }

                            doc.Add(table);
                            doc.Close();
                        }

                        MessageBox.Show("Informe PDF guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

       
    }
}