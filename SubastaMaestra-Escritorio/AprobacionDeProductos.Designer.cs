namespace SubastaMaestra_Escritorio
{
    partial class AprobacionDeProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AprobacionDeProductos));
            dataGridView1 = new DataGridView();
            buttonAceptar = new Button();
            buttonRechazar = new Button();
            labelSolicitudes = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(527, 361);
            dataGridView1.TabIndex = 0;
            // 
            // buttonAceptar
            // 
            buttonAceptar.BackColor = Color.White;
            buttonAceptar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            buttonAceptar.FlatAppearance.MouseOverBackColor = Color.Green;
            buttonAceptar.FlatStyle = FlatStyle.Flat;
            buttonAceptar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAceptar.ForeColor = Color.Black;
            buttonAceptar.Location = new Point(556, 81);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(83, 28);
            buttonAceptar.TabIndex = 1;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = false;
            buttonAceptar.Click += button1_Click;
            // 
            // buttonRechazar
            // 
            buttonRechazar.BackColor = Color.White;
            buttonRechazar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            buttonRechazar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            buttonRechazar.FlatStyle = FlatStyle.Flat;
            buttonRechazar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRechazar.Location = new Point(556, 139);
            buttonRechazar.Name = "buttonRechazar";
            buttonRechazar.Size = new Size(83, 29);
            buttonRechazar.TabIndex = 2;
            buttonRechazar.Text = "Rechazar";
            buttonRechazar.UseVisualStyleBackColor = false;
            buttonRechazar.Click += buttonRechazar_Click_1;
            // 
            // labelSolicitudes
            // 
            labelSolicitudes.AutoSize = true;
            labelSolicitudes.Font = new Font("Century Gothic", 18F, FontStyle.Underline);
            labelSolicitudes.Location = new Point(228, 19);
            labelSolicitudes.Name = "labelSolicitudes";
            labelSolicitudes.Size = new Size(311, 30);
            labelSolicitudes.TabIndex = 4;
            labelSolicitudes.Text = "Solicitudes de Productos:";
            // 
            // AprobacionDeProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(664, 522);
            Controls.Add(labelSolicitudes);
            Controls.Add(buttonRechazar);
            Controls.Add(buttonAceptar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AprobacionDeProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AprobacionDeProductos";
            Load += AprobacionDeProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonAceptar;
        private Button buttonRechazar;
        private Label labelSolicitudes;
    }
}