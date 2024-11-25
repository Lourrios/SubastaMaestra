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


            var (result2, error2) = await ApiHelper.GetAsync<List<SaleDTO>>(ApiUrl.LocalURL + "api/Sale/list");

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


                _ventasFiltradas = _prodVendidos.Where(sale => sale.Product != null &&  sale.Product.AuctionId == auctionId).ToList();


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
                            Document doc = new Document(PageSize.A4, 50, 50, 50, 50);
                            PdfWriter.GetInstance(doc, fs);
                            doc.Open();

                            // Agregar logo de la empresa
                            string logoPath = "C://Escritorio//SubastaMaestra-master//SubastaMaestra//logo//image.png";
                            if (File.Exists(logoPath))
                            {
                                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                                logo.ScaleAbsoluteWidth(100);
                                logo.ScaleAbsoluteHeight(50);
                                logo.Alignment = Element.ALIGN_LEFT;
                                doc.Add(logo);
                            }

                            // Agregar información de la empresa
                            doc.Add(new Paragraph("Puja Maestra S.A.", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)));
                            doc.Add(new Paragraph("CUIT: 30-12345678-9"));
                            doc.Add(new Paragraph("Tipo de Sociedad: Sociedad Anónima (S.A.)"));
                            doc.Add(new Paragraph("Dirección: Calle Ejemplo 123, Ciudad Ejemplo"));
                            doc.Add(new Paragraph("Teléfono: +54 9 1234-567890"));
                            doc.Add(new Paragraph("Correo Electrónico: contacto@pujamaestra.com"));
                            doc.Add(new Paragraph("\n"));

                            // Título del informe
                            doc.Add(new Paragraph("Informe de Productos Vendidos", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)));
                            doc.Add(new Paragraph("Fecha de Generación: " + DateTime.Now.ToString("dd/MM/yyyy")));
                            doc.Add(new Paragraph("\n"));

                            // Crear tabla de datos con marco
                            PdfPTable table = new PdfPTable(6);
                            table.WidthPercentage = 100;
                            table.SetWidths(new float[] { 2, 2, 2, 1.5f, 2, 2 });
                            table.SpacingBefore = 10;
                            table.SpacingAfter = 10;
                            table.DefaultCell.Border = iTextSharp.text.Rectangle.BOX;

                            // Encabezados
                            table.AddCell("Producto");
                            table.AddCell("Vendedor");
                            table.AddCell("Fecha Venta");
                            table.AddCell("Monto Total");
                            table.AddCell("Monto Vendedor");
                            table.AddCell("Monto Empresa");

                            // Agregar datos a la tabla
                            foreach (var product in _ventasFiltradas)
                            {
                                table.AddCell(product.Product?.Name ?? ""); // Producto
                                table.AddCell(product.Seller?.Name ?? "");  // Vendedor
                                table.AddCell(product.SaleDate.ToString("dd/MM/yyyy HH:mm:ss")); // Fecha de Venta
                                table.AddCell($"${product.Amount.ToString("N2")}"); // Monto Total

                                var montoVendedor = product.Amount - product.Deduccion;
                                table.AddCell($"${montoVendedor?.ToString("N2")}");
                                table.AddCell($"${product.Deduccion?.ToString("N2")}");
                            }

                            doc.Add(table);

                            // Agregar pie de página
                            doc.Add(new Paragraph("\nEste informe cumple con los requisitos para ser presentado.", FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.GRAY)));
                            doc.Add(new Paragraph("Puja Maestra S.A.", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, BaseColor.GRAY)));

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
