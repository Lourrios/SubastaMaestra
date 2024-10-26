using AutoMapper;
using SubastaMaestra.Data.Interfaces;
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
            // Asociar el evento de cambio de selección del ComboBox
            comboBoxSubastas.SelectedIndexChanged += comboBoxSubastas_SelectedIndexChanged;

            // Cargar los valores en el ComboBox
            LoadComboBox();
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
            var result = await _auctionRepository.GetAllAuctionsAsync();
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
            var result = await _auctionRepository.GetAllOpenAuctionAsync();
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
            var result = await _auctionRepository.GetAllClosedAuctionAsync();
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
            var result = await _auctionRepository.GetAllPendingAuctionsAsync();
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
