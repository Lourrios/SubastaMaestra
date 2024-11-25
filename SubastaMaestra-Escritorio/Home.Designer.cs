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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panelLateral = new Panel();
            buttonCerrarSesion = new Button();
            panelInforme = new Panel();
            button2 = new Button();
            button1 = new Button();
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
            buttonCrearSubasta = new Button();
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
            panelLateral.Controls.Add(buttonCerrarSesion);
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
            panelLateral.Size = new Size(249, 561);
            panelLateral.TabIndex = 0;
            // 
            // buttonCerrarSesion
            // 
            buttonCerrarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            buttonCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            buttonCerrarSesion.FlatStyle = FlatStyle.Flat;
            buttonCerrarSesion.Font = new Font("Century Gothic", 9F);
            buttonCerrarSesion.Location = new Point(48, 525);
            buttonCerrarSesion.Name = "buttonCerrarSesion";
            buttonCerrarSesion.Size = new Size(113, 23);
            buttonCerrarSesion.TabIndex = 7;
            buttonCerrarSesion.Text = "CERRAR SESION";
            buttonCerrarSesion.UseVisualStyleBackColor = true;
            buttonCerrarSesion.Click += buttonCerrarSesion_Click;
            // 
            // panelInforme
            // 
            panelInforme.Controls.Add(button2);
            panelInforme.Controls.Add(button1);
            panelInforme.Controls.Add(buttonInfoProdSinOferta);
            panelInforme.Controls.Add(buttonInfoProdVendidos);
            panelInforme.Controls.Add(buttonInfoGanancias);
            panelInforme.Dock = DockStyle.Top;
            panelInforme.Location = new Point(10, 355);
            panelInforme.Name = "panelInforme";
            panelInforme.Size = new Size(237, 164);
            panelInforme.TabIndex = 6;
            panelInforme.Visible = false;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9F);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 92);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(237, 23);
            button2.TabIndex = 4;
            button2.Text = "Informe De Usuarios Mas Activos";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 69);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(237, 23);
            button1.TabIndex = 3;
            button1.Text = "Informe De Subasta Mas Populares";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // buttonInfoProdSinOferta
            // 
            buttonInfoProdSinOferta.Dock = DockStyle.Top;
            buttonInfoProdSinOferta.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            buttonInfoProdSinOferta.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            buttonInfoProdSinOferta.FlatStyle = FlatStyle.Flat;
            buttonInfoProdSinOferta.Font = new Font("Century Gothic", 9F);
            buttonInfoProdSinOferta.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInfoProdSinOferta.Location = new Point(0, 46);
            buttonInfoProdSinOferta.Name = "buttonInfoProdSinOferta";
            buttonInfoProdSinOferta.Padding = new Padding(20, 0, 0, 0);
            buttonInfoProdSinOferta.Size = new Size(237, 23);
            buttonInfoProdSinOferta.TabIndex = 2;
            buttonInfoProdSinOferta.Text = "Informe De Productos Sin Ofertar";
            buttonInfoProdSinOferta.TextAlign = ContentAlignment.MiddleLeft;
            buttonInfoProdSinOferta.UseVisualStyleBackColor = true;
            buttonInfoProdSinOferta.Click += buttonInfoProdSinOferta_Click;
            // 
            // buttonInfoProdVendidos
            // 
            buttonInfoProdVendidos.Dock = DockStyle.Top;
            buttonInfoProdVendidos.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            buttonInfoProdVendidos.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            buttonInfoProdVendidos.FlatStyle = FlatStyle.Flat;
            buttonInfoProdVendidos.Font = new Font("Century Gothic", 9F);
            buttonInfoProdVendidos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInfoProdVendidos.Location = new Point(0, 23);
            buttonInfoProdVendidos.Name = "buttonInfoProdVendidos";
            buttonInfoProdVendidos.Padding = new Padding(20, 0, 0, 0);
            buttonInfoProdVendidos.Size = new Size(237, 23);
            buttonInfoProdVendidos.TabIndex = 1;
            buttonInfoProdVendidos.Text = "Informe De Productos Vendidos";
            buttonInfoProdVendidos.TextAlign = ContentAlignment.MiddleLeft;
            buttonInfoProdVendidos.UseVisualStyleBackColor = true;
            buttonInfoProdVendidos.Click += buttonInfoProdVendidos_Click;
            // 
            // buttonInfoGanancias
            // 
            buttonInfoGanancias.Dock = DockStyle.Top;
            buttonInfoGanancias.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            buttonInfoGanancias.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            buttonInfoGanancias.FlatStyle = FlatStyle.Flat;
            buttonInfoGanancias.Font = new Font("Century Gothic", 9F);
            buttonInfoGanancias.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInfoGanancias.Location = new Point(0, 0);
            buttonInfoGanancias.Name = "buttonInfoGanancias";
            buttonInfoGanancias.Padding = new Padding(20, 0, 0, 0);
            buttonInfoGanancias.Size = new Size(237, 23);
            buttonInfoGanancias.TabIndex = 0;
            buttonInfoGanancias.Text = "Informe d Ganancias";
            buttonInfoGanancias.TextAlign = ContentAlignment.MiddleLeft;
            buttonInfoGanancias.UseVisualStyleBackColor = true;
            buttonInfoGanancias.Click += buttonInfoGanancias_Click;
            // 
            // buttonInforme
            // 
            buttonInforme.Dock = DockStyle.Top;
            buttonInforme.FlatAppearance.MouseDownBackColor = Color.FromArgb(123, 9, 146);
            buttonInforme.FlatAppearance.MouseOverBackColor = Color.FromArgb(123, 9, 146);
            buttonInforme.FlatStyle = FlatStyle.Flat;
            buttonInforme.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            buttonInforme.Location = new Point(10, 310);
            buttonInforme.Name = "buttonInforme";
            buttonInforme.Padding = new Padding(10, 0, 0, 0);
            buttonInforme.Size = new Size(237, 45);
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
            panelProducto.Location = new Point(10, 233);
            panelProducto.Name = "panelProducto";
            panelProducto.Size = new Size(237, 77);
            panelProducto.TabIndex = 4;
            panelProducto.Visible = false;
            // 
            // buttonAprobarProducto
            // 
            buttonAprobarProducto.Dock = DockStyle.Top;
            buttonAprobarProducto.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            buttonAprobarProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            buttonAprobarProducto.FlatStyle = FlatStyle.Flat;
            buttonAprobarProducto.Font = new Font("Century Gothic", 9F);
            buttonAprobarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAprobarProducto.Location = new Point(0, 23);
            buttonAprobarProducto.Name = "buttonAprobarProducto";
            buttonAprobarProducto.Padding = new Padding(35, 0, 0, 0);
            buttonAprobarProducto.Size = new Size(237, 23);
            buttonAprobarProducto.TabIndex = 1;
            buttonAprobarProducto.Text = "Aprobacion De Productos";
            buttonAprobarProducto.TextAlign = ContentAlignment.MiddleLeft;
            buttonAprobarProducto.UseVisualStyleBackColor = true;
            buttonAprobarProducto.Click += buttonAprobarProducto_Click;
            // 
            // buttonListaProducto
            // 
            buttonListaProducto.Dock = DockStyle.Top;
            buttonListaProducto.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            buttonListaProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            buttonListaProducto.FlatStyle = FlatStyle.Flat;
            buttonListaProducto.Font = new Font("Century Gothic", 9F);
            buttonListaProducto.ImageAlign = ContentAlignment.MiddleLeft;
            buttonListaProducto.Location = new Point(0, 0);
            buttonListaProducto.Name = "buttonListaProducto";
            buttonListaProducto.Padding = new Padding(35, 0, 0, 0);
            buttonListaProducto.Size = new Size(237, 23);
            buttonListaProducto.TabIndex = 0;
            buttonListaProducto.Text = "Lista de Productos";
            buttonListaProducto.TextAlign = ContentAlignment.MiddleLeft;
            buttonListaProducto.UseVisualStyleBackColor = true;
            buttonListaProducto.Click += buttonListaProducto_Click;
            // 
            // buttonProducto
            // 
            buttonProducto.Dock = DockStyle.Top;
            buttonProducto.FlatAppearance.MouseDownBackColor = Color.FromArgb(123, 9, 146);
            buttonProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(123, 9, 146);
            buttonProducto.FlatStyle = FlatStyle.Flat;
            buttonProducto.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            buttonProducto.Location = new Point(10, 188);
            buttonProducto.Name = "buttonProducto";
            buttonProducto.Padding = new Padding(10, 0, 0, 0);
            buttonProducto.Size = new Size(237, 45);
            buttonProducto.TabIndex = 3;
            buttonProducto.Text = "Administracion de Productos";
            buttonProducto.TextAlign = ContentAlignment.MiddleLeft;
            buttonProducto.UseVisualStyleBackColor = true;
            buttonProducto.Click += button1_Click;
            // 
            // panelSubastas
            // 
            panelSubastas.Controls.Add(buttonProximasSubastas);
            panelSubastas.Controls.Add(buttonCrearSubasta);
            panelSubastas.Dock = DockStyle.Top;
            panelSubastas.ForeColor = Color.FromArgb(64, 64, 0);
            panelSubastas.Location = new Point(10, 109);
            panelSubastas.Name = "panelSubastas";
            panelSubastas.Size = new Size(237, 79);
            panelSubastas.TabIndex = 2;
            panelSubastas.Visible = false;
            // 
            // buttonProximasSubastas
            // 
            buttonProximasSubastas.Dock = DockStyle.Top;
            buttonProximasSubastas.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            buttonProximasSubastas.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            buttonProximasSubastas.FlatStyle = FlatStyle.Flat;
            buttonProximasSubastas.Font = new Font("Century Gothic", 9F);
            buttonProximasSubastas.Location = new Point(0, 23);
            buttonProximasSubastas.Name = "buttonProximasSubastas";
            buttonProximasSubastas.Padding = new Padding(35, 0, 0, 0);
            buttonProximasSubastas.Size = new Size(237, 25);
            buttonProximasSubastas.TabIndex = 3;
            buttonProximasSubastas.Text = "Todas Subastas";
            buttonProximasSubastas.TextAlign = ContentAlignment.MiddleLeft;
            buttonProximasSubastas.UseVisualStyleBackColor = true;
            buttonProximasSubastas.Click += buttonProximasSubastas_Click;
            // 
            // buttonCrearSubasta
            // 
            buttonCrearSubasta.Dock = DockStyle.Top;
            buttonCrearSubasta.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            buttonCrearSubasta.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            buttonCrearSubasta.FlatStyle = FlatStyle.Flat;
            buttonCrearSubasta.Font = new Font("Century Gothic", 9F);
            buttonCrearSubasta.Location = new Point(0, 0);
            buttonCrearSubasta.Name = "buttonCrearSubasta";
            buttonCrearSubasta.Padding = new Padding(35, 0, 0, 0);
            buttonCrearSubasta.Size = new Size(237, 23);
            buttonCrearSubasta.TabIndex = 1;
            buttonCrearSubasta.Text = "Administracion";
            buttonCrearSubasta.TextAlign = ContentAlignment.MiddleLeft;
            buttonCrearSubasta.UseVisualStyleBackColor = true;
            buttonCrearSubasta.Click += buttonCrearSubasta_Click;
            // 
            // buttonSubasta
            // 
            buttonSubasta.Dock = DockStyle.Top;
            buttonSubasta.FlatAppearance.BorderColor = Color.Black;
            buttonSubasta.FlatAppearance.MouseDownBackColor = Color.FromArgb(123, 9, 146);
            buttonSubasta.FlatAppearance.MouseOverBackColor = Color.FromArgb(123, 9, 146);
            buttonSubasta.FlatStyle = FlatStyle.Flat;
            buttonSubasta.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubasta.Location = new Point(10, 64);
            buttonSubasta.Name = "buttonSubasta";
            buttonSubasta.Padding = new Padding(10, 0, 0, 0);
            buttonSubasta.Size = new Size(237, 45);
            buttonSubasta.TabIndex = 1;
            buttonSubasta.Text = "Administracion de Subastas";
            buttonSubasta.TextAlign = ContentAlignment.MiddleLeft;
            buttonSubasta.UseVisualStyleBackColor = true;
            buttonSubasta.Click += buttonSubasta_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.White;
            panelLogo.BackgroundImage = Properties.Resources.image;
            panelLogo.BackgroundImageLayout = ImageLayout.Stretch;
            panelLogo.BorderStyle = BorderStyle.Fixed3D;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(10, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(237, 64);
            panelLogo.TabIndex = 0;
            // 
            // panelHijo
            // 
            panelHijo.Anchor = AnchorStyles.None;
            panelHijo.BorderStyle = BorderStyle.Fixed3D;
            panelHijo.Controls.Add(pictureBox1);
            panelHijo.Location = new Point(254, -1);
            panelHijo.Name = "panelHijo";
            panelHijo.Size = new Size(680, 561);
            panelHijo.TabIndex = 1;
            panelHijo.Paint += panelHijo_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.Imagen_de_WhatsApp_2024_11_23_a_las_16_01_35_e3e7a1a8;
            pictureBox1.Location = new Point(73, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(542, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += Home_Load;
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
        private Button buttonCerrarSesion;
        private Button button1;
        private Button button2;
    }
}
