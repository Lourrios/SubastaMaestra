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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace SubastaMaestra_Escritorio
{
    public partial class InformeProductosSinOferta : Form


    {
        private List<ProductDTO> _productos = new List<ProductDTO>();

        public InformeProductosSinOferta()
        {
            InitializeComponent();
        }

        private async void InformeProductosSinOferta_Load(object sender, EventArgs e)
        {
            var (resultado, error) = await ApiHelper.GetAsync<OperationResult<List<ProductDTO>>>(ApiUrl.LocalURL + "api/Product/sinOfertas");

            if (resultado != null && resultado.Success)
            {
                // Asigna el resultado al campo _productos
                _productos = resultado.Value;

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Clear(); // Asegura que no haya columnas duplicadas

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Id",
                    HeaderText = "ID Producto",
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
                    DataPropertyName = "CreatedAt",
                    HeaderText = "Fecha de Creación",
                    Name = "CreatedAt",
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
                });

                // Asigna la lista de productos al DataGridView
                dataGridView1.DataSource = _productos;
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los productos sin ofertas. " + $"{error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF Files|*.pdf", FileName = "ProductosSinOfertas.pdf" })
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
                            string logoPath = "C://Escritorio//SubastaMaestra-master//SubastaMaestra//logo//image.png"; // Ruta al logo
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

                            // Título del informe
                            doc.Add(new Paragraph("Resumen de Productos sin Ofertas", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)));
                            doc.Add(new Paragraph("Fecha de Generación: " + DateTime.Now.ToString("dd/MM/yyyy")));
                            doc.Add(new Paragraph("\n")); // Espacio

                            // Crear tabla PDF
                            PdfPTable table = new PdfPTable(5); // Ajusta el número de columnas según tus datos
                            table.WidthPercentage = 100;
                            table.SetWidths(new float[] { 2, 3, 2, 2, 3 });

                            // Encabezados de la tabla
                            table.AddCell(new PdfPCell(new Phrase("ID Producto", FontFactory.GetFont(FontFactory.HELVETICA_BOLD))) { BackgroundColor = BaseColor.LIGHT_GRAY });
                            table.AddCell(new PdfPCell(new Phrase("Nombre", FontFactory.GetFont(FontFactory.HELVETICA_BOLD))) { BackgroundColor = BaseColor.LIGHT_GRAY });
                            table.AddCell(new PdfPCell(new Phrase("Condición", FontFactory.GetFont(FontFactory.HELVETICA_BOLD))) { BackgroundColor = BaseColor.LIGHT_GRAY });
                            table.AddCell(new PdfPCell(new Phrase("Precio Inicial", FontFactory.GetFont(FontFactory.HELVETICA_BOLD))) { BackgroundColor = BaseColor.LIGHT_GRAY });
                            table.AddCell(new PdfPCell(new Phrase("Fecha de Creación", FontFactory.GetFont(FontFactory.HELVETICA_BOLD))) { BackgroundColor = BaseColor.LIGHT_GRAY });

                            // Llenar la tabla con los datos del DataGridView
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                table.AddCell(row.Cells["Id"].Value?.ToString() ?? "");
                                table.AddCell(row.Cells["Name"].Value?.ToString() ?? "");
                                table.AddCell(row.Cells["Condition"].Value?.ToString() ?? "");
                                table.AddCell(row.Cells["InitialPrice"].Value?.ToString() ?? "");
                                table.AddCell(Convert.ToDateTime(row.Cells["CreatedAt"].Value).ToString("dd/MM/yyyy"));
                            }

                            // Agregar tabla al documento
                            doc.Add(table);

                            // Pie de página con nota
                            doc.Add(new Paragraph("\nEste informe cumple con los requisitos para ser presentado ante las autoridades correspondientes.", FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.GRAY)));
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
