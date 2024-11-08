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
        private  List<ProductDTO> _productos = new List<ProductDTO>();

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
                            Document doc = new Document(PageSize.A4);
                            PdfWriter.GetInstance(doc, fs);
                            doc.Open();

                            // Título
                            doc.Add(new Paragraph("Resumen de Productos sin Ofertas"));
                            doc.Add(new Paragraph(" ")); // Espacio

                            // Tabla PDF
                            PdfPTable table = new PdfPTable(5); // Ajusta el número de columnas según tus datos
                            table.WidthPercentage = 100;
                            table.SetWidths(new float[] { 2, 3, 2, 2, 3 });

                            // Encabezados de la tabla
                            table.AddCell("ID Producto");
                            table.AddCell("Nombre");
                            table.AddCell("Condición");
                            table.AddCell("Precio Inicial");
                            table.AddCell("Fecha de Creación");

                            // Llenar la tabla con los datos del DataGridView
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                table.AddCell(row.Cells["Id"].Value?.ToString() ?? "");
                                table.AddCell(row.Cells["Name"].Value?.ToString() ?? "");
                                table.AddCell(row.Cells["Condition"].Value?.ToString() ?? "");
                                table.AddCell(row.Cells["InitialPrice"].Value?.ToString() ?? "");
                                table.AddCell(Convert.ToDateTime(row.Cells["CreatedAt"].Value).ToString("dd/MM/yyyy"));
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
