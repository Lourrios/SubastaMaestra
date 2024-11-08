using Microsoft.Extensions.DependencyInjection;
using SubastaMaestra.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SubastaMaestra_Escritorio
{

    
    public partial class Home : Form
    { 

        private readonly AuctionHandlerService _handlerService;
        public Home(AuctionHandlerService handlerService)
        {
            InitializeComponent();
            _handlerService=handlerService;
        }

        private void hideSubMenu()
        {
            if (panelSubastas.Visible == true)
                panelSubastas.Visible = false;
            if (panelProducto.Visible == true)
                panelProducto.Visible = false;
            if (panelInforme.Visible == true)
                panelInforme.Visible = false;
        }


        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        private void buttonSubasta_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubastas);
        }

        private void buttonSubastasAbiertas_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(Program.ServiceProvider.GetRequiredService<SubastaAbiertas>());
            //
            // Otro codigo...
            //
            hideSubMenu();


        }

        private void buttonCrearSubasta_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(Program.ServiceProvider.GetRequiredService<Menu>());
            //
            // Otro codigo...
            //
            hideSubMenu();
        }

        private void buttonModificarSubasta_Click(object sender, EventArgs e)
        {
            // openChildFormInPanel(Program.ServiceProvider.GetRequiredService<Editar>());
            //
            // Otro codigo...
            //
            hideSubMenu();
        }

        private void buttonProximasSubastas_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(Program.ServiceProvider.GetRequiredService<FiltroSubasta>());
            //
            // Otro codigo...
            //
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProducto);
        }

        private void buttonListaProducto_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(Program.ServiceProvider.GetRequiredService<ListaProductos>());
            //
            // Otro codigo...
            //
            hideSubMenu();
        }

        private void buttonAprobarProducto_Click(object sender, EventArgs e)
        {
            //
            // Otro codigo...
            //
            hideSubMenu();
        }

        private void buttonInforme_Click(object sender, EventArgs e)
        {
            showSubMenu(panelInforme);
        }

        private void buttonInfoGanancias_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(Program.ServiceProvider.GetRequiredService<InformeGanancias>());
            //
            // Otro codigo...
            //
            hideSubMenu();
        }

        private void buttonInfoProdVendidos_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(Program.ServiceProvider.GetRequiredService<InformeProductosVendidos>());
            //
            // Otro codigo...
            //
            hideSubMenu();
        }

        private void buttonInfoProdSinOferta_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(Program.ServiceProvider.GetRequiredService<InformeProductosSinOferta>());
            //
            // Otro codigo...
            //
            hideSubMenu();
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelHijo.Controls.Add(childForm);
            panelHijo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildFormInPanel(Program.ServiceProvider.GetRequiredService<ListaDeOferentes>());
            //
            // Otro codigo...
            //
            hideSubMenu();
        }
    }
}
