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
                            Document doc = new Document(PageSize.A4);
                            PdfWriter.GetInstance(doc, fs);
                            doc.Open();

                            // Título del documento
                            doc.Add(new Paragraph("Informe de Subastas Más Populares"));
                            doc.Add(new Paragraph($"Período: {dateTimePickerInicio.Value:dd/MM/yyyy} - {dateTimePickerFin.Value:dd/MM/yyyy}"));
                            doc.Add(new Paragraph($"Generado el: {DateTime.Now:dd/MM/yyyy HH:mm:ss}"));
                            doc.Add(new Paragraph(" ")); // Espacio

                            // Tabla PDF
                            PdfPTable table = new PdfPTable(4);
                            table.WidthPercentage = 100;
                            table.SetWidths(new float[] { 2, 2, 1, 2 });

                            // Encabezados
                            table.AddCell("Título");
                            table.AddCell("Fecha Finalización");
                            table.AddCell("Total Ofertas");
                            table.AddCell("Monto Máximo");

                            // Datos de las subastas
                            foreach (var auction in _auctionReports)
                            {
                                table.AddCell(auction.Title);
                                table.AddCell(auction.FinishDate.ToString("yyyy/MM/dd"));
                                table.AddCell(auction.TotalOfertas.ToString());
                                table.AddCell(auction.HighestBidAmount.ToString("C"));
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
