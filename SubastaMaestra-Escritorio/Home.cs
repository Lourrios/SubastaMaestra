namespace SubastaMaestra_Escritorio
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
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
            openChildFormInPanel(new SubastaAbiertas());
            //
            // Otro codigo...
            //
            hideSubMenu();


        }

        private void buttonCrearSubasta_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CrearSubasta());
            //
            // Otro codigo...
            //
            hideSubMenu();
        }

        private void buttonModificarSubasta_Click(object sender, EventArgs e)
        {
            //
            // Otro codigo...
            //
            hideSubMenu();
        }

        private void buttonProximasSubastas_Click(object sender, EventArgs e)
        {
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
            //
            // Otro codigo...
            //
            hideSubMenu();
        }

        private void buttonInfoProdVendidos_Click(object sender, EventArgs e)
        {
            //
            // Otro codigo...
            //
            hideSubMenu();
        }

        private void buttonInfoProdSinOferta_Click(object sender, EventArgs e)
        {
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

    }
}
