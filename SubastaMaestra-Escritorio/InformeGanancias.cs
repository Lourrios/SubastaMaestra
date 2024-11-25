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
using SubastaMaestra.Models.DTOs.Reports;


namespace SubastaMaestra_Escritorio
{
    public partial class InformeGanancias : Form
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IMapper _mapper;
        private List<ProfitReportDTO> _profitReports;
        public InformeGanancias(ISaleRepository saleRepository, IMapper mapper)
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
            var (result, error) = await ApiHelper.GetAsync<List<ProfitReportDTO>>(ApiUrl.LocalURL + "api/Auction/reporteGanancias");
            if (result != null)
            {
                // Asigna el resultado a _sales para realizar cálculos adicionales
                _profitReports = result;

                //// Calcula la deducción (10% del monto de cada venta)
                //foreach (var profit in _profitReports)
                //{
                //    profit.GananciaTotal = sale.Amount * 0.10f;
                //}

                // Configura la vista para el DataGridView
                var gananciasView = _profitReports.Select(report => new
                {
                    Subasta = report.AuctionTitle,
                    FechaInicio = report.StartDate.ToString("dd/MM/yyyy"),
                    FechaFin = report.FinishDate.ToString("dd/MM/yyyy"),
                    ProductosVendidos = report.TotalProductosVendidos,
                    TotalVentas = report.MontoTotalVentas.ToString("C"),
                    GananciaEmpresa = report.GananciaTotal.ToString("C")
                }).ToList();

                // Asigna la vista al DataGridView
                dataGridView1.DataSource = gananciasView;
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
                Title = "Guardar informe de Ganancias"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                GeneratePdfReport(filePath);
                MessageBox.Show("Informe generado exitosamente");
            }
        }

        private void GeneratePdfReport(string filePath)
        {
            Document document = new Document(PageSize.A4, 50, 50, 50, 50);
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            // Agregar logo de la empresa
            string logoPath = "C://Escritorio//SubastaMaestra-master//SubastaMaestra//logo//image.png"; // Ruta al logo de la empresa
            if (File.Exists(logoPath))
            {
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                logo.ScaleAbsoluteWidth(100);
                logo.ScaleAbsoluteHeight(50);
                logo.Alignment = Element.ALIGN_LEFT;
                document.Add(logo);
            }

            // Agregar información de la empresa
            document.Add(new Paragraph("Puja Maestra S.A.", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)));
            document.Add(new Paragraph("CUIT: 30-12345678-9"));
            document.Add(new Paragraph("Tipo de Sociedad: Sociedad Anónima (S.A.)"));
            document.Add(new Paragraph("Dirección: Calle Ejemplo 123, Ciudad Ejemplo"));
            document.Add(new Paragraph("Teléfono: +54 9 1234-567890"));
            document.Add(new Paragraph("Correo Electrónico: contacto@pujamaestra.com"));
            document.Add(new Paragraph("\n"));

            // Título del informe
            document.Add(new Paragraph("Informe de Gestión de Ganancias", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)));
            document.Add(new Paragraph("Fecha de Generación: " + DateTime.Now.ToString("dd/MM/yyyy")));
            document.Add(new Paragraph("\n"));

            // Crear tabla de datos
            PdfPTable table = new PdfPTable(6);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 2, 2, 2, 1.5f, 2, 2 });

            // Encabezados
            table.AddCell("Título de Subasta");
            table.AddCell("Fecha de Inicio");
            table.AddCell("Fecha de Fin");
            table.AddCell("Productos Vendidos");
            table.AddCell("Monto Total Ventas");
            table.AddCell("Ganancia Empresa (10%)");

            // Agregar datos a la tabla
            foreach (var report in _profitReports)
            {
                table.AddCell(report.AuctionTitle);
                table.AddCell(report.StartDate.ToString("dd/MM/yyyy"));
                table.AddCell(report.FinishDate.ToString("dd/MM/yyyy"));
                table.AddCell(report.TotalProductosVendidos.ToString());
                table.AddCell($"${report.MontoTotalVentas.ToString("N2")}");
                table.AddCell($"${report.GananciaTotal.ToString("N2")}");
            }

            document.Add(table);

       
            document.Add(new Paragraph("\nEste informe cumple con los requisitos para ser presentado.", FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.GRAY)));
            document.Add(new Paragraph("Puja Maestra S.A.", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, BaseColor.GRAY)));

            document.Close();
        }
    }
}