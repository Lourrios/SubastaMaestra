using AutoMapper;


using SubastaMaestra.Data.Interfaces;
using SubastaMaestra.Models.DTOs.Auction;
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

namespace SubastaMaestra_Escritorio
{
    public partial class FiltroSubasta : Form
    {


        private readonly IAuctionRepository _auctionRepository;
        private readonly IMapper _mapper;
        public FiltroSubasta(IAuctionRepository auctionRepository, IMapper mapper)
        {
            _auctionRepository = auctionRepository;
            _mapper = mapper;
            InitializeComponent();
           
            ConfigurarDataGridView();

            comboBoxSubastas.SelectedIndexChanged += comboBoxSubastas_SelectedIndexChanged;

         
            LoadComboBox();
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


        private async void LoadComboBox()
        {
            var subastaTipos = new List<string> { "Todas", "Abiertas", "Cerradas", "Pendientes" };
            comboBoxSubastas.DataSource = subastaTipos;
        }

        private async void comboBoxSubastas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoSubasta = comboBoxSubastas.SelectedItem.ToString();

            switch (tipoSubasta)
            {
                case "Todas":
                    await LoadAllAuctions();
                    break;
                case "Abiertas":
                    await LoadOpenAuctions();
                    break;
                case "Cerradas":
                    await LoadClosedAuctions();
                    break;
                case "Pendientes":
                    await LoadPendingAuctions();
                    break;
            }
        }

        private async Task LoadAllAuctions()
        {

            //var result = await _auctionRepository.GetAllAuctionsAsync();
            var (result, error) = await ApiHelper.GetAsync<OperationResult<List<AuctionDTO>>>(ApiUrl.LocalURL + "api/Auction/list");
            if (result.Success)
            {
                dataGridViewSubastas.DataSource = result.Value;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private async Task LoadOpenAuctions()
        {
            string tipoSubasta = "Active";

            //
            var (result, error) = await ApiHelper.GetAsync<OperationResult<List<AuctionDTO>>>(ApiUrl.LocalURL + $"api/Auction/listByState/{tipoSubasta}"); 
            //var result = await _auctionRepository.GetAllOpenAuctionAsync();
            if (result.Success)
            {
                dataGridViewSubastas.DataSource = result.Value;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private async Task LoadClosedAuctions()
        {

            string tipoSubasta = "Closed";

            var (result, error) = await ApiHelper.GetAsync<OperationResult<List<AuctionDTO>>>(ApiUrl.LocalURL + $"api/Auction/listByState/{tipoSubasta}");
            //var result = await _auctionRepository.GetAllClosedAuctionAsync();
            if (result.Success)
            {
                dataGridViewSubastas.DataSource = result.Value;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }

        private async Task LoadPendingAuctions()
        {

            string tipoSubasta = "Pending";

            var (result, error) = await ApiHelper.GetAsync<OperationResult<List<AuctionDTO>>>(ApiUrl.LocalURL + $"api/Auction/listByState/{tipoSubasta}");
            //var result = await _auctionRepository.GetAllPendingAuctionsAsync();
            if (result.Success)
            {
                dataGridViewSubastas.DataSource = result.Value;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}
