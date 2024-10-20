namespace SubastaMaestra_Escritorio
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelLateral = new Panel();
            panelInforme = new Panel();
            buttonInfoProdSinOferta = new Button();
            buttonInfoProdVendidos = new Button();
            buttonInfoGanancias = new Button();
            buttonInforme = new Button();
            panelProducto = new Panel();
            buttonAprobarProducto = new Button();
            buttonListaProducto = new Button();
            buttonProducto = new Button();
            panelSubastas = new Panel();
            buttonProximasSubastas = new Button();
            buttonModificarSubasta = new Button();
            buttonCrearSubasta = new Button();
            buttonSubastasAbiertas = new Button();
            buttonSubasta = new Button();
            panelLogo = new Panel();
            panelHijo = new Panel();
            pictureBox1 = new PictureBox();
            panelLateral.SuspendLayout();
            panelInforme.SuspendLayout();
            panelProducto.SuspendLayout();
            panelSubastas.SuspendLayout();
            panelHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelLateral
            // 
            panelLateral.AutoScroll = true;
            panelLateral.BackgroundImageLayout = ImageLayout.Center;
            panelLateral.BorderStyle = BorderStyle.FixedSingle;
            panelLateral.Controls.Add(panelInforme);
            panelLateral.Controls.Add(buttonInforme);
            panelLateral.Controls.Add(panelProducto);
            panelLateral.Controls.Add(buttonProducto);
            panelLateral.Controls.Add(panelSubastas);
            panelLateral.Controls.Add(buttonSubasta);
            panelLateral.Controls.Add(panelLogo);
            panelLateral.Dock = DockStyle.Left;
            panelLateral.Location = new Point(0, 0);
            panelLateral.Name = "panelLateral";
            panelLateral.Padding = new Padding(10, 0, 0, 0);
            panelLateral.Size = new Size(216, 561);
            panelLateral.TabIndex = 0;
            // 
            // panelInforme
            // 
            panelInforme.Controls.Add(buttonInfoProdSinOferta);
            panelInforme.Controls.Add(buttonInfoProdVendidos);
            panelInforme.Controls.Add(buttonInfoGanancias);
            panelInforme.Dock = DockStyle.Top;
            panelInforme.Location = new Point(10, 438);
            panelInforme.Name = "panelInforme";
            panelInforme.Size = new Size(204, 97);
            panelInforme.TabIndex = 6;
            panelInforme.Visible = false;
            // 
            // buttonInfoProdSinOferta
            // 
            buttonInfoProdSinOferta.Dock = DockStyle.Top;
            buttonInfoProdSinOferta.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInfoProdSinOferta.Location = new Point(0, 46);
            buttonInfoProdSinOferta.Name = "buttonInfoProdSinOferta";
            buttonInfoProdSinOferta.Padding = new Padding(20, 0, 0, 0);
            buttonInfoProdSinOferta.Size = new Size(204, 23);
            buttonInfoProdSinOferta.TabIndex = 2;
            buttonInfoProdSinOferta.Text = "Informe De Productos Sin Ofertar";
            buttonInfoProdSinOferta.TextAlign = ContentAlignment.MiddleLeft;
            buttonInfoProdSinOferta.UseVisualStyleBackColor = true;
            buttonInfoProdSinOferta.Click += buttonInfoProdSinOferta_Click;
            // 
            // buttonInfoProdVendidos
            // 
            buttonInfoProdVendidos.Dock = DockStyle.Top;
            buttonInfoProdVendidos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInfoProdVendidos.Location = new Point(0, 23);
            buttonInfoProdVendidos.Name = "buttonInfoProdVendidos";
            buttonInfoProdVendidos.Padding = new Padding(20, 0, 0, 0);
            buttonInfoProdVendidos.Size = new Size(204, 23);
            buttonInfoProdVendidos.TabIndex = 1;
            buttonInfoProdVendidos.Text = "Informe De Productos Vendidos";
            buttonInfoProdVendidos.TextAlign = ContentAlignment.MiddleLeft;
            buttonInfoProdVendidos.UseVisualStyleBackColor = true;
            buttonInfoProdVendidos.Click += buttonInfoProdVendidos_Click;
            // 
            // buttonInfoGanancias
            // 
            buttonInfoGanancias.Dock = DockStyle.Top;
            buttonInfoGanancias.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInfoGanancias.Location = new Point(0, 0);
            buttonInfoGanancias.Name = "buttonInfoGanancias";
            buttonInfoGanancias.Padding = new Padding(20, 0, 0, 0);
            buttonInfoGanancias.Size = new Size(204, 23);
            buttonInfoGanancias.TabIndex = 0;
            buttonInfoGanancias.Text = "Informe d Ganancias";
            buttonInfoGanancias.TextAlign = ContentAlignment.MiddleLeft;
            buttonInfoGanancias.UseVisualStyleBackColor = true;
            buttonInfoGanancias.Click += buttonInfoGanancias_Click;
            // 
            // buttonInforme
            // 
            buttonInforme.Dock = DockStyle.Top;
            buttonInforme.FlatStyle = FlatStyle.Flat;
            buttonInforme.Location = new Point(10, 393);
            buttonInforme.Name = "buttonInforme";
            buttonInforme.Padding = new Padding(10, 0, 0, 0);
            buttonInforme.Size = new Size(204, 45);
            buttonInforme.TabIndex = 5;
            buttonInforme.Text = "Informes de Gestion";
            buttonInforme.TextAlign = ContentAlignment.MiddleLeft;
            buttonInforme.UseVisualStyleBackColor = true;
            buttonInforme.Click += buttonInforme_Click;
            // 
            // panelProducto
            // 
            panelProducto.Controls.Add(buttonAprobarProducto);
            panelProducto.Controls.Add(buttonListaProducto);
            panelProducto.Dock = DockStyle.Top;
            panelProducto.Location = new Point(10, 296);
            panelProducto.Name = "panelProducto";
            panelProducto.Size = new Size(204, 97);
            panelProducto.TabIndex = 4;
            panelProducto.Visible = false;
            // 
            // buttonAprobarProducto
            // 
            buttonAprobarProducto.Dock = DockStyle.Top;
            buttonAprobarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAprobarProducto.Location = new Point(0, 23);
            buttonAprobarProducto.Name = "buttonAprobarProducto";
            buttonAprobarProducto.Padding = new Padding(35, 0, 0, 0);
            buttonAprobarProducto.Size = new Size(204, 23);
            buttonAprobarProducto.TabIndex = 1;
            buttonAprobarProducto.Text = "Aprobacion De Productos";
            buttonAprobarProducto.TextAlign = ContentAlignment.MiddleLeft;
            buttonAprobarProducto.UseVisualStyleBackColor = true;
            buttonAprobarProducto.Click += buttonAprobarProducto_Click;
            // 
            // buttonListaProducto
            // 
            buttonListaProducto.Dock = DockStyle.Top;
            buttonListaProducto.ImageAlign = ContentAlignment.MiddleLeft;
            buttonListaProducto.Location = new Point(0, 0);
            buttonListaProducto.Name = "buttonListaProducto";
            buttonListaProducto.Padding = new Padding(35, 0, 0, 0);
            buttonListaProducto.Size = new Size(204, 23);
            buttonListaProducto.TabIndex = 0;
            buttonListaProducto.Text = "Lista de Productos";
            buttonListaProducto.TextAlign = ContentAlignment.MiddleLeft;
            buttonListaProducto.UseVisualStyleBackColor = true;
            buttonListaProducto.Click += buttonListaProducto_Click;
            // 
            // buttonProducto
            // 
            buttonProducto.Dock = DockStyle.Top;
            buttonProducto.FlatStyle = FlatStyle.Flat;
            buttonProducto.Location = new Point(10, 251);
            buttonProducto.Name = "buttonProducto";
            buttonProducto.Padding = new Padding(10, 0, 0, 0);
            buttonProducto.Size = new Size(204, 45);
            buttonProducto.TabIndex = 3;
            buttonProducto.Text = "Solicitudes De Productos";
            buttonProducto.TextAlign = ContentAlignment.MiddleLeft;
            buttonProducto.UseVisualStyleBackColor = true;
            buttonProducto.Click += button1_Click;
            // 
            // panelSubastas
            // 
            panelSubastas.Controls.Add(buttonProximasSubastas);
            panelSubastas.Controls.Add(buttonModificarSubasta);
            panelSubastas.Controls.Add(buttonCrearSubasta);
            panelSubastas.Controls.Add(buttonSubastasAbiertas);
            panelSubastas.Dock = DockStyle.Top;
            panelSubastas.Location = new Point(10, 140);
            panelSubastas.Name = "panelSubastas";
            panelSubastas.Size = new Size(204, 111);
            panelSubastas.TabIndex = 2;
            panelSubastas.Visible = false;
            // 
            // buttonProximasSubastas
            // 
            buttonProximasSubastas.Dock = DockStyle.Top;
            buttonProximasSubastas.Location = new Point(0, 69);
            buttonProximasSubastas.Name = "buttonProximasSubastas";
            buttonProximasSubastas.Padding = new Padding(35, 0, 0, 0);
            buttonProximasSubastas.Size = new Size(204, 25);
            buttonProximasSubastas.TabIndex = 3;
            buttonProximasSubastas.Text = "Proximas Subastas";
            buttonProximasSubastas.TextAlign = ContentAlignment.MiddleLeft;
            buttonProximasSubastas.UseVisualStyleBackColor = true;
            buttonProximasSubastas.Click += buttonProximasSubastas_Click;
            // 
            // buttonModificarSubasta
            // 
            buttonModificarSubasta.Dock = DockStyle.Top;
            buttonModificarSubasta.Location = new Point(0, 46);
            buttonModificarSubasta.Name = "buttonModificarSubasta";
            buttonModificarSubasta.Padding = new Padding(35, 0, 0, 0);
            buttonModificarSubasta.Size = new Size(204, 23);
            buttonModificarSubasta.TabIndex = 2;
            buttonModificarSubasta.Text = "Editar/eliminar Subastas";
            buttonModificarSubasta.TextAlign = ContentAlignment.MiddleLeft;
            buttonModificarSubasta.UseVisualStyleBackColor = true;
            buttonModificarSubasta.Click += buttonModificarSubasta_Click;
            // 
            // buttonCrearSubasta
            // 
            buttonCrearSubasta.Dock = DockStyle.Top;
            buttonCrearSubasta.Location = new Point(0, 23);
            buttonCrearSubasta.Name = "buttonCrearSubasta";
            buttonCrearSubasta.Padding = new Padding(35, 0, 0, 0);
            buttonCrearSubasta.Size = new Size(204, 23);
            buttonCrearSubasta.TabIndex = 1;
            buttonCrearSubasta.Text = "Crear Subasta";
            buttonCrearSubasta.TextAlign = ContentAlignment.MiddleLeft;
            buttonCrearSubasta.UseVisualStyleBackColor = true;
            buttonCrearSubasta.Click += buttonCrearSubasta_Click;
            // 
            // buttonSubastasAbiertas
            // 
            buttonSubastasAbiertas.Dock = DockStyle.Top;
            buttonSubastasAbiertas.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSubastasAbiertas.Location = new Point(0, 0);
            buttonSubastasAbiertas.Name = "buttonSubastasAbiertas";
            buttonSubastasAbiertas.Padding = new Padding(35, 0, 0, 0);
            buttonSubastasAbiertas.Size = new Size(204, 23);
            buttonSubastasAbiertas.TabIndex = 0;
            buttonSubastasAbiertas.Text = "Subastas Abiertas";
            buttonSubastasAbiertas.TextAlign = ContentAlignment.MiddleLeft;
            buttonSubastasAbiertas.UseVisualStyleBackColor = true;
            buttonSubastasAbiertas.Click += buttonSubastasAbiertas_Click;
            // 
            // buttonSubasta
            // 
            buttonSubasta.Dock = DockStyle.Top;
            buttonSubasta.FlatStyle = FlatStyle.Flat;
            buttonSubasta.Location = new Point(10, 95);
            buttonSubasta.Name = "buttonSubasta";
            buttonSubasta.Padding = new Padding(10, 0, 0, 0);
            buttonSubasta.Size = new Size(204, 45);
            buttonSubasta.TabIndex = 1;
            buttonSubasta.Text = "Administracion de Subastas";
            buttonSubasta.TextAlign = ContentAlignment.MiddleLeft;
            buttonSubasta.UseVisualStyleBackColor = true;
            buttonSubasta.Click += buttonSubasta_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = SystemColors.ControlDark;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(10, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(204, 95);
            panelLogo.TabIndex = 0;
            // 
            // panelHijo
            // 
            panelHijo.Anchor = AnchorStyles.None;
            panelHijo.Controls.Add(pictureBox1);
            panelHijo.Location = new Point(216, -1);
            panelHijo.Name = "panelHijo";
            panelHijo.Size = new Size(718, 561);
            panelHijo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.image;
            pictureBox1.Location = new Point(155, 173);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(462, 147);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(934, 561);
            Controls.Add(panelHijo);
            Controls.Add(panelLateral);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panelLateral.ResumeLayout(false);
            panelInforme.ResumeLayout(false);
            panelProducto.ResumeLayout(false);
            panelSubastas.ResumeLayout(false);
            panelHijo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLateral;
        private Button buttonSubasta;
        private Panel panelLogo;
        private Panel panelSubastas;
        private Button buttonSubastasAbiertas;
        private Button buttonModificarSubasta;
        private Button buttonCrearSubasta;
        private Button buttonProximasSubastas;
        private Panel panelProducto;
        private Button buttonListaProducto;
        private Button buttonProducto;
        private Panel panelInforme;
        private Button buttonInfoProdVendidos;
        private Button buttonInfoGanancias;
        private Button buttonInforme;
        private Button buttonAprobarProducto;
        private Button buttonInfoProdSinOferta;
        private Panel panelHijo;
        private PictureBox pictureBox1;
    }
}
