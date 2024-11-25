using iTextSharp.text.pdf;
using iTextSharp.text;
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

namespace SubastaMaestra_Escritorio
{
    public partial class InformeUsuariosMasActivos : Form
    {
        private IUserRepository _userRepository;
        private List<MostActiveUserDTO> _usuariosMasActivos;
        public InformeUsuariosMasActivos(IUserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;


        }

        private async void InformeUsuariosMasActivos_Load(object sender, EventArgs e)
        {
            // Llamada a la API
            var (resultado, error) = await ApiHelper.GetAsync<List<MostActiveUserDTO>>(ApiUrl.LocalURL + "api/User/masActivos");

            if (resultado != null)
            {
                _usuariosMasActivos = resultado;

                dataGridViewUserMasActivo.AutoGenerateColumns = false;
                dataGridViewUserMasActivo.Columns.Clear();

                // Configuración de columnas
                dataGridViewUserMasActivo.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "UserId",
                    HeaderText = "ID Usuario",
                    Name = "UserId"
                });
                dataGridViewUserMasActivo.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "UserName",
                    HeaderText = "Nombre",
                    Name = "UserName"
                });
                dataGridViewUserMasActivo.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "TotalBids",
                    HeaderText = "Total Ofertas",
                    Name = "TotalBids"
                });
                dataGridViewUserMasActivo.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "HighestBidAmount",
                    HeaderText = "Oferta Más Alta",
                    Name = "HighestBidAmount"
                });
                dataGridViewUserMasActivo.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ProductName",
                    HeaderText = "Producto",
                    Name = "ProductName"
                });
                dataGridViewUserMasActivo.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "HighestBidDate",
                    HeaderText = "Fecha Oferta",
                    Name = "HighestBidDate",
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
                });

                // Asignar datos al DataGridView
                dataGridViewUserMasActivo.DataSource = _usuariosMasActivos;
            }
            else
            {
                MessageBox.Show($"No se pudieron cargar los datos. Error: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF Files|*.pdf", FileName = "UsuariosMasActivos.pdf" })
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
                            doc.Add(new Paragraph("Informe de Usuarios Más Activos"));
                            doc.Add(new Paragraph(" "));
                            doc.Add(new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy}"));

                            // Tabla PDF
                            PdfPTable table = new PdfPTable(6);
                            table.WidthPercentage = 100;
                            table.SetWidths(new float[] { 2, 3, 2, 2, 3, 3 });

                            // Encabezados
                            table.AddCell("ID Usuario");
                            table.AddCell("Nombre");
                            table.AddCell("Total Ofertas");
                            table.AddCell("Oferta Más Alta");
                            table.AddCell("Producto");
                            table.AddCell("Fecha Oferta");

                            // Filas de datos
                            foreach (DataGridViewRow row in dataGridViewUserMasActivo.Rows)
                            {
                                table.AddCell(row.Cells["UserId"].Value?.ToString() ?? "");
                                table.AddCell(row.Cells["UserName"].Value?.ToString() ?? "");
                                table.AddCell(row.Cells["TotalBids"].Value?.ToString() ?? "");
                                table.AddCell(row.Cells["HighestBidAmount"].Value?.ToString() ?? "");
                                table.AddCell(row.Cells["ProductName"].Value?.ToString() ?? "");
                                table.AddCell(Convert.ToDateTime(row.Cells["HighestBidDate"].Value).ToString("dd/MM/yyyy"));
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

        private void dataGridViewUserMasActivo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    

