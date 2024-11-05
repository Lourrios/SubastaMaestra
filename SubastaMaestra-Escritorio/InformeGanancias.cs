using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SubastaMaestra.Models.DTOs.Sale;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SubastaMaestra.Data.Interfaces;
using SubastaMaestra.Data.Implements;
using SubastaMaestra.Data;
using AutoMapper;
using SubastaMaestra.Models.DTOs.Auction;
using SubastaMaestra.Models.Utils;


namespace SubastaMaestra_Escritorio
{
    public partial class InformeGanancias : Form
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IMapper _mapper;
        private List<SaleDTO> _sales;
        public InformeGanancias(ISaleRepository saleRepository,IMapper mapper)
        {
            InitializeComponent();
            _saleRepository = saleRepository;
            _mapper = mapper;
            this.Load += InformeGanancias_Load;
            
        }

        private async void InformeGanancias_Load(object sender, EventArgs e)
        {
            await LoadSales();
        }

        private async Task LoadSales()
        {
            var (result, error) = await ApiHelper.GetAsync<List<SaleDTO>>(ApiUrl.LocalURL + "list");
            if (result != null)
            {
                // Asigna el resultado a _sales para realizar cálculos adicionales
                _sales = result;

                // Calcula la deducción (10% del monto de cada venta)
                foreach (var sale in _sales)
                {
                    sale.Deduccion = sale.Amount * 0.10f;
                }

                // Configura la vista para el DataGridView
                var salesView = _sales.Select(s => new
                {
                    Id = s.Id,
                    ProductName = s.Product?.Name ?? "N/A",
                    BuyerName = s.Buyer?.Name ?? "N/A",
                    SellerName = s.Seller?.Name ?? "N/A",
                    Amount = s.Amount,
                    SaleDate = s.SaleDate.ToString("dd/MM/yyyy"),
                    Deduccion = s.Deduccion,
                    PaymentMethod = s.PaymentMethod?.ToString() ?? "N/A"
                }).ToList();

                // Asigna la vista al DataGridView
                dataGridView1.DataSource = salesView;
            }
            else
            {
                // Muestra el mensaje de error si no se pudo obtener el resultado
                MessageBox.Show(error);
            }
        }

        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "PDF Files|*.pdf",
                Title = "Guardar informe de Gestion"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                GeneratePdfReport(filePath);
                MessageBox.Show("Informe guardado exitosamente");
            }
        }

        private void GeneratePdfReport(string filePath)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            document.Add(new Paragraph("Informe de Gestión de Ventas"));
            document.Add(new Paragraph("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy")));
            document.Add(new Paragraph("\n"));

            PdfPTable table = new PdfPTable(5);
            table.AddCell("Producto");
            table.AddCell("Comprador");
            table.AddCell("Vendedor");
            table.AddCell("Monto Total");
            table.AddCell("Ganancia Empresa (10%)");

            foreach (var sale in _sales)
            {
                table.AddCell(sale.Product.Name);
                table.AddCell(sale.Buyer?.Name ?? "N/A");
                table.AddCell(sale.Seller?.Name ?? "N/A");
                table.AddCell(sale.Amount.ToString("C"));
                table.AddCell(sale.Deduccion.HasValue ? sale.Deduccion.Value.ToString("C") : "0");
            }

            document.Add(table);
            document.Close();
        }

       
    }
}
