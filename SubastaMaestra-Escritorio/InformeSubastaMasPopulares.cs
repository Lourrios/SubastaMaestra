using SubastaMaestra.Data.Interfaces;
using SubastaMaestra.Models.DTOs.Reports;
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
using AutoMapper;

namespace SubastaMaestra_Escritorio
{
    public partial class InformeSubastaMasPopulares : Form
    {
        private IAuctionRepository _auctionRepository;
        private IMapper _mapper;
        private List<AuctionReportDTO> _auctionReports;
        public InformeSubastaMasPopulares(IAuctionRepository auctionRepository, IMapper mapper)
        {
            InitializeComponent();
            _auctionRepository = auctionRepository;
            _mapper = mapper;

        }


        private async void buttonBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dateTimePickerInicio.Value.Date;
            DateTime fechaFin = dateTimePickerFin.Value.Date;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var (result, error) = await ApiHelper.GetAsync<List<AuctionReportDTO>>(
                $"{ApiUrl.LocalURL}api/Auction/masPopulares?start={fechaInicio:yyyy-MM-dd}&finish={fechaFin:yyyy-MM-dd}"
            );

            if (result != null)
            {
                // Guardar resultados en variable global para exportar a PDF
                _auctionReports = result;

                // Cargar al DataGridView
                dataGridViewMasPopulares.DataSource = _auctionReports.Select(d => new
                {
                    Título = d.Title,
                    FechaFinalización = d.FinishDate.ToString("yyyy/MM/dd"),
                    TotalOfertas = d.TotalOfertas,
                    MontoMáximoOferta = d.HighestBidAmount.ToString("C")
                }).ToList();
            }
            else
            {
                MessageBox.Show($"Error al cargar datos: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (_auctionReports == null || !_auctionReports.Any())
            {
                MessageBox.Show("No hay datos para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF Files|*.pdf", FileName = "InformeSubastasPopulares.pdf" })
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

                            // Logo de la empresa (opcional)
                            string logoPath = "C://Escritorio//SubastaMaestra-master//SubastaMaestra//logo//image.png"; // Cambia a la ruta real del logo
                            if (File.Exists(logoPath))
                            {
                                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                                logo.ScaleAbsoluteWidth(100);
                                logo.ScaleAbsoluteHeight(50);
                                logo.Alignment = Element.ALIGN_LEFT;
                                doc.Add(logo);
                            }

                            // Información de la empresa
                            Paragraph companyInfo = new Paragraph();
                            companyInfo.Add(new Paragraph("Puja Maestra S.A.", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)));
                            companyInfo.Add(new Paragraph("CUIT: 30-12345678-9"));
                            companyInfo.Add(new Paragraph("Tipo de Sociedad: Sociedad Anónima (S.A.)"));
                            companyInfo.Add(new Paragraph("Dirección: Calle Ejemplo 123, Ciudad Ejemplo"));
                            companyInfo.Add(new Paragraph("Teléfono: +54 9 1234-567890"));
                            companyInfo.Add(new Paragraph("Correo Electrónico: contacto@pujamaestra.com"));
                            companyInfo.SpacingAfter = 20; // Espacio después de la sección
                            doc.Add(companyInfo);

                            // Título del documento
                            doc.Add(new Paragraph("Informe de Subastas Más Populares", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)));
                            doc.Add(new Paragraph($"Período: {dateTimePickerInicio.Value:dd/MM/yyyy} - {dateTimePickerFin.Value:dd/MM/yyyy}"));
                            doc.Add(new Paragraph($"Generado el: {DateTime.Now:dd/MM/yyyy HH:mm:ss}"));
                            doc.Add(new Paragraph("\n")); // Espacio

                            // Crear tabla PDF
                            PdfPTable table = new PdfPTable(4);
                            table.WidthPercentage = 100;
                            table.SetWidths(new float[] { 2, 2, 1, 2 });

                            // Encabezados de la tabla
                            table.AddCell(new PdfPCell(new Phrase("Título", FontFactory.GetFont(FontFactory.HELVETICA_BOLD))) { BackgroundColor = BaseColor.LIGHT_GRAY });
                            table.AddCell(new PdfPCell(new Phrase("Fecha Finalización", FontFactory.GetFont(FontFactory.HELVETICA_BOLD))) { BackgroundColor = BaseColor.LIGHT_GRAY });
                            table.AddCell(new PdfPCell(new Phrase("Total Ofertas", FontFactory.GetFont(FontFactory.HELVETICA_BOLD))) { BackgroundColor = BaseColor.LIGHT_GRAY });
                            table.AddCell(new PdfPCell(new Phrase("Monto Máximo", FontFactory.GetFont(FontFactory.HELVETICA_BOLD))) { BackgroundColor = BaseColor.LIGHT_GRAY });

                            // Llenar la tabla con los datos
                            foreach (var auction in _auctionReports)
                            {
                                table.AddCell(auction.Title);
                                table.AddCell(auction.FinishDate.ToString("dd/MM/yyyy"));
                                table.AddCell(auction.TotalOfertas.ToString());
                                table.AddCell($"${auction.HighestBidAmount.ToString("N2")}");
                            }

                            // Agregar tabla al documento
                            doc.Add(table);

                            // Pie de página
                            doc.Add(new Paragraph("\nEste informe es propiedad de Puja Maestra S.A.", FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.GRAY)));
                            doc.Add(new Paragraph("Todos los derechos reservados.", FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.GRAY)));

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
