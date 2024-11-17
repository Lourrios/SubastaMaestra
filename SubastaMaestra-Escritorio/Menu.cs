using AutoMapper;
using SubastaMaestra.Data.Interfaces;
using SubastaMaestra.Entities.Enums;
using SubastaMaestra.Models.DTOs.Auction;
namespace SubastaMaestra_Escritorio
{
    public partial class Menu : Form
    {

        private readonly IAuctionRepository _auctionRepository;
        private readonly IMapper _mapper;
        private List<AuctionDTO> listaSubastas = new List<AuctionDTO>();
        private AuctionDTO subastaSeleccionada;
        private AuctionCreateDTO subastaNueva;
        private AuctionUpdateDTO subasta;


        public Menu(IAuctionRepository auctionRepository, IMapper mapper)
        {

            _auctionRepository=auctionRepository;
            InitializeComponent();

            _mapper=mapper;
            CargarSubastas();
            dataGridViewSubastas.AutoGenerateColumns= true;
            
        }


        private async void CrearSubasta_Load(object sender, EventArgs e)

        {
           

        }

        private async Task CargarSubastas()
        {

            var resultado = await _auctionRepository.GetAllAuctionsAsync();

            if (resultado.Success)
            {
                listaSubastas = resultado.Value;  // Asignar el valor al DataSource
                dataGridViewSubastas.DataSource = listaSubastas;
            }
            else
            {
                MessageBox.Show(resultado.Message, "Error al cargar las subastas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCrear_Click_1(object sender, EventArgs e)
        {
            var crearSubastaForm = new CrearSubastaForm(_auctionRepository);


            if (crearSubastaForm.ShowDialog() == DialogResult.OK)
            {
                CargarSubastas();
            }

        }



        private async void buttonEditar_Click(object sender, EventArgs e)
        {


            if (dataGridViewSubastas.SelectedRows.Count >0)
            {
                var subastaSeleccionada = (AuctionUpdateDTO)dataGridViewSubastas.SelectedRows[0].DataBoundItem;

                var subastaUpdateDTO = new AuctionUpdateDTO
                {
                    Id = subasta.Id,
                    Title = subasta.Title,
                    StartDate = subasta.StartDate,
                    FinishDate = subasta.FinishDate
                };

                var editarSubastaForm = new Editar(_auctionRepository, subastaSeleccionada);

                if (editarSubastaForm.ShowDialog() == DialogResult.OK)
                {
                    CargarSubastas();


                }
                else
                {
                    MessageBox.Show("Seleccione una subasta para editar.", "Editar Subasta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }


        //private void ConfigurarDataGridView()
        //{
        //    dataGridViewSubastas.AutoGenerateColumns = false;

        //    dataGridViewSubastas.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        DataPropertyName = "Title",
        //        HeaderText = "Nombre"
        //    });

        //    dataGridViewSubastas.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        DataPropertyName = "StartDate",
        //        HeaderText = "Fecha Inicio"
        //    });

        //    dataGridViewSubastas.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        DataPropertyName = "FinishDate",
        //        HeaderText = "Fecha Cierre"
        //    });

        //    dataGridViewSubastas.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        DataPropertyName = "State",
        //        HeaderText = "Estado"
        //    });
        //}






        private async void CargarTodasLasSubastas()
        {
            // Llamada al método para obtener todas las subastas
            var resultado = await _auctionRepository.GetAllAuctionsAsync();

            // Verificación de si el resultado es exitoso
            if (resultado.Success)
            {
                // Asegúrate de que resultado.Value no sea null
                if (resultado.Value != null)
                {
                    // Asignar la lista completa de subastas al DataGridView
                    dataGridViewSubastas.DataSource = resultado.Value.ToList();

                    // Verificar si no hay subastas
                    if (resultado.Value.Count == 0)
                    {
                        MessageBox.Show("No se encontraron subastas.");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron subastas.");
                }
            }
            else
            {
                MessageBox.Show("Error al cargar las subastas: " + resultado.Message);
            }
        }

        private async void buttonDeshabilitar_Click(object sender, EventArgs e)
        {
            //if (dataGridViewSubastas.SelectedRows.Count > 0)
            //{
            //    // Obtener la subasta seleccionada
            //    var subastaSeleccionada = (AuctionDTO)dataGridViewSubastas.SelectedRows[0].DataBoundItem;

            //    // Verificar que la subasta esté activa para deshabilitarla
            //    if (subastaSeleccionada.State == AuctionState.Active)
            //    {
            //        // Cambiar el estado de la subasta 
            //        subastaSeleccionada.State = AuctionState.Canceled;

            //        // Llamar al método para actualizar la subasta
            //        var resultado = await _auctionRepository.EditAuctionAsync(subastaSeleccionada, subastaSeleccionada.Id);

            //        // Verificar el resultado
            //        if (resultado.Success)
            //        {
            //            MessageBox.Show("Subasta deshabilitada con éxito.");
            //            CargarSubastas(); // Recargar la lista de subastas
            //        }
            //        else
            //        {
            //            MessageBox.Show($"Error al deshabilitar la subasta: {resultado.Message}");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("La subasta ya está deshabilitada.", "Deshabilitar Subasta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Seleccione una subasta para deshabilitar.", "Deshabilitar Subasta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            if (dataGridViewSubastas.SelectedRows.Count > 0)
            {
                // Obtener la subasta seleccionada
                var subastaSeleccionada = (AuctionDTO)dataGridViewSubastas.SelectedRows[0].DataBoundItem;

                // Verificar que la subasta esté activa para deshabilitarla
                if (subastaSeleccionada.State == AuctionState.Active)
                {
                    // Cambiar el estado de la subasta a 'Canceled' o deshabilitada
                    subastaSeleccionada.State = AuctionState.Canceled;

                    try
                    {
                        // Llamar al método para actualizar la subasta en el repositorio
                        var resultado = await _auctionRepository.EditAuctionAsync(subasta, subasta.Id);

                        // Verificar el resultado
                        if (resultado.Success)
                        {
                            MessageBox.Show("Subasta deshabilitada con éxito.");
                            CargarSubastas(); // Recargar la lista de subastas
                        }
                        else
                        {
                            MessageBox.Show($"Error al deshabilitar la subasta: {resultado.Message}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al intentar deshabilitar la subasta: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("La subasta ya está deshabilitada.", "Deshabilitar Subasta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una subasta para deshabilitar.", "Deshabilitar Subasta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            CargarSubastas();
        }


    }

}

