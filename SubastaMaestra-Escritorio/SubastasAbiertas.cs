using AutoMapper;
using SubastaMaestra.Data;
using SubastaMaestra.Data.Interfaces;
using SubastaMaestra.Models.DTOs.Auction;
using SubastaMaestra.Models.Utils;


namespace SubastaMaestra_Escritorio
{
    public partial class SubastaAbiertas : Form
    {
        private readonly AuctionHandlerService _handlerService;
        private readonly IAuctionRepository _auctionRepository;
        private readonly IMapper _mapper;
        private AuctionDTO auctionDTO;
        public SubastaAbiertas(IAuctionRepository auctionRepository, IMapper mapper, AuctionHandlerService auctionHandlerService)
        {
            _handlerService = auctionHandlerService;
            _auctionRepository = auctionRepository;
            _mapper = mapper;
            InitializeComponent();


        }
        private async void Form2_Load_1(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            // Crear columnas
            dataGridView1.Columns.Add("Title", "Nombre Subasta");
            dataGridView1.Columns.Add("StarDate", "Fecha Inicio");
            dataGridView1.Columns.Add("FinishDate", "Fecha Cierre");
            dataGridView1.Columns.Add("State", "Estado");
            dataGridView1.Columns.Add("CantidadProductos", "Cantidad Productos");

            

            await CargarSubastasAbiertasAsync();

        }

        private async Task CargarSubastasAbiertasAsync()
        {

            string tipoSubasta = "Active";
            try
            {
                // Llamamos al método del repositorio para obtener las subastas activas
                var (result, error) = await ApiHelper.GetAsync<OperationResult<List<AuctionDTO>>>(ApiUrl.LocalURL + $"api/Auction/listByState/{tipoSubasta}");
                //var result = await _auctionRepository.GetAllOpenAuctionAsync();

                if (result == null)
                {
                    MessageBox.Show("El resultado de la API es nulo. Verifica la conexión o el formato de la respuesta.");
                    return;
                }

                Console.WriteLine($"Cantidad de subastas obtenidas: {result.Value?.Count}");

                if (!result.Success || result.Value == null || result.Value.Count == 0)
                {
                    MessageBox.Show(result.Message ?? "No se encontraron Subastas Abiertas");
                    return;
                }

                // Limpiar el DataGridView antes de agregar nuevos datos
                dataGridView1.Rows.Clear();

                // Añadir las subastas al DataGridView
                foreach (var subasta in result.Value)
                {
                    Console.WriteLine($"Añadiendo subasta: {subasta.Title}");
                    dataGridView1.Rows.Add(subasta.Title, subasta.StartDate, subasta.FinishDate, subasta.State.ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\nDetalles: " + ex.StackTrace);
            }


        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBoxBuscarNombre.Text;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["NombreSubasta"].Value != null)
                {
                    bool visible = row.Cells["NombreSubasta"].Value.ToString().Contains(filtro, StringComparison.OrdinalIgnoreCase);
                    row.Visible = visible;
                }
            }
        }



        private void FiltrarPorFechas(DateTime fechaInicio, DateTime fechaCierre)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["FechaInicio"].Value != null && row.Cells["FechaCierre"].Value != null)
                {
                    DateTime inicio = DateTime.Parse(row.Cells["FechaInicio"].Value.ToString());
                    DateTime cierre = DateTime.Parse(row.Cells["FechaCierre"].Value.ToString());

                    bool visible = (inicio >= fechaInicio && cierre <= fechaCierre);
                    row.Visible = visible;
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int cantidadProductos = (int)numericUpDown2.Value;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["CantidadProductos"].Value != null)
                {
                    int productos = int.Parse(row.Cells["CantidadProductos"].Value.ToString());
                    row.Visible = (productos >= cantidadProductos);
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                row.Cells["Estado"].Value = "Finalizada";

                MessageBox.Show("Subasta finalizada correctamente.");
            }
            else
            {
                MessageBox.Show("Selecciona una subasta para finalizar.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                // Mostrar los detalles en el panel
                labelDetalles.Text = $"Subasta: {row.Cells["Title"].Value}" +
                    $"\nFecha de Inicio: {row.Cells["StarDate"].Value}" +
                    $"\nFecha de Cierre: {row.Cells["FinishDate"].Value}" +
                    $"\nEstado: {row.Cells["State"].Value}";
                //$"\nCantidad de Productos: {row.Cells["Cantidad de Productos"].Value}";



                panel1.Show();  // Mostrar el panel con los detalles
            }
            else
            {
                MessageBox.Show("Selecciona una subasta para ver los detalles.");
            }
        }



        private void buttonFecha_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dateTimePicker1.Value;
            DateTime fechaCierre = dateTimePicker2.Value;

            FiltrarPorFechas(fechaInicio, fechaCierre);
        }



        private void buttonCantProd_Click(object sender, EventArgs e)
        {
            // Obtener el valor seleccionado en el NumericUpDown
            int cantidadProductos = (int)numericUpDown2.Value;

            // Filtrar las subastas por la cantidad de productos
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["CantidadProductos"].Value != null)
                {
                    int productos = int.Parse(row.Cells["CantidadProductos"].Value.ToString());
                    row.Visible = (productos >= cantidadProductos);
                }
            }
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var nombreSubasta = dataGridView1.Rows[e.RowIndex].Cells["NombreSubasta"].Value.ToString();

                MessageBox.Show($"Subasta seleccionada: {nombreSubasta}");
                // Puedes abrir un nuevo formulario con más detalles de la subasta seleccionada si lo deseas.
            }
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await CargarSubastasAbiertasAsync();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
