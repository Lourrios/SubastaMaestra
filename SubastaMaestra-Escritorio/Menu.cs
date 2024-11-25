using AutoMapper;
using SubastaMaestra.Data.Interfaces;
using SubastaMaestra.Entities.Enums;
using SubastaMaestra.Models.DTOs.Auction;
using SubastaMaestra.Models.Utils;

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


            InitializeComponent();
            _auctionRepository=auctionRepository;
            _mapper=mapper;
            CargarSubastas();
            ConfigurarDataGridView();

        }


        private async void CrearSubasta_Load(object sender, EventArgs e)

        {


        }

        private async Task CargarSubastas()
        {
            var (resul, error) = await ApiHelper.GetAsync<OperationResult<List<AuctionDTO>>>(ApiUrl.LocalURL + "api/Auction/list");
            //var resultado = await _auctionRepository.GetAllAuctionsAsync();

            if (resul.Success)
            {
                listaSubastas = resul.Value;  // Asignar el valor al DataSource
                dataGridViewSubastas.DataSource = listaSubastas;
            }
            else
            {
                MessageBox.Show(resul.Message, "Error al cargar las subastas", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var subastaSeleccionada = (AuctionDTO)dataGridViewSubastas.SelectedRows[0].DataBoundItem;



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


        private void ConfigurarDataGridView()
        {
            dataGridViewSubastas.AutoGenerateColumns = false;

            dataGridViewSubastas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Title",
                HeaderText = "Nombre",
                Name = "Title",
            });

            dataGridViewSubastas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StartDate",
                HeaderText = "Fecha Inicio",
                Name =  "StarDate"
            });

            dataGridViewSubastas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FinishDate",
                HeaderText = "Fecha Cierre",
                Name = "FinishDate"

            });

            dataGridViewSubastas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "State",
                HeaderText = "Estado",
                Name ="State"
            });
        }






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


            {
                if (dataGridViewSubastas.SelectedRows.Count > 0)
                {
                    // Obtener la subasta seleccionada del DataGridView
                    var subastaSeleccionada = (AuctionDTO)dataGridViewSubastas.SelectedRows[0].DataBoundItem;

                    // Verificar que la subasta esté activa antes de deshabilitarla
                    if (subastaSeleccionada.State == AuctionState.Active)
                    {
                        try
                        {
                            // Crear un DTO de actualización para modificar el estado
                            var subastaUpdateDTO = new AuctionUpdateDTO
                            {
                                Id = subastaSeleccionada.Id,
                                state = AuctionState.Canceled // Cambiar estado a "Canceled"
                            };

                            var resultado = await ApiHelper.PatchAsync(ApiUrl.LocalURL + $"api/Auction/deshabilitar/{subastaUpdateDTO.Id}", subastaUpdateDTO.Id);
                            // Llamar al método del repositorio para actualizar la subasta
                            //var resultado = await _auctionRepository.EditAuctionAsync(subastaUpdateDTO, subastaSeleccionada.Id);

                            // Verificar el resultado de la operación
                            if (resultado != null)
                            {
                                MessageBox.Show("Subasta deshabilitada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                await CargarSubastas(); // Recargar la lista de subastas
                            }
                            else
                            {
                                MessageBox.Show($"Error al deshabilitar la subasta: {resultado}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ocurrió un error al intentar deshabilitar la subasta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La subasta ya está deshabilitada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una subasta para deshabilitar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            CargarSubastas();
        }

        private async void buttonHabilitar_Click(object sender, EventArgs e)
        {
            if (dataGridViewSubastas.SelectedRows.Count > 0)
            {
                var subastaSeleccionada = (AuctionDTO)dataGridViewSubastas.SelectedRows[0].DataBoundItem;

                // Verifica si la subasta está en estado Cancelado
                if (subastaSeleccionada.State == AuctionState.Canceled)
                {
                    try
                    {
                        var subastaUpdateDTO = new AuctionUpdateDTO
                        {
                            Id = subastaSeleccionada.Id,
                            state = AuctionState.Active // Cambia el estado a Activo
                        };

                        var resultado = await ApiHelper.PatchAsync(ApiUrl.LocalURL + $"api/Auction/activar/{subastaUpdateDTO.Id}", subastaUpdateDTO);

                        if (resultado != null)
                        {
                            MessageBox.Show("Subasta habilitada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await CargarSubastas(); // Recargar las subastas
                        }
                        else
                        {
                            MessageBox.Show($"Error al habilitar la subasta: {resultado}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Solo se pueden habilitar subastas con estado Cancelado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una subasta para habilitar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}

