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
            dataGridView1 = new DataGridView();
            buttonAceptar = new Button();
            buttonRechazar = new Button();
            labelError = new Label();
            labelSolicitudes = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(486, 289);
            dataGridView1.TabIndex = 0;
            // 
            // buttonAceptar
            // 
            buttonAceptar.BackColor = Color.FromArgb(128, 255, 128);
            buttonAceptar.ForeColor = Color.Black;
            buttonAceptar.Location = new Point(556, 81);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(75, 23);
            buttonAceptar.TabIndex = 1;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = false;
            buttonAceptar.Click += button1_Click;
            // 
            // buttonRechazar
            // 
            buttonRechazar.BackColor = Color.Red;
            buttonRechazar.Location = new Point(556, 142);
            buttonRechazar.Name = "buttonRechazar";
            buttonRechazar.Size = new Size(75, 23);
            buttonRechazar.TabIndex = 2;
            buttonRechazar.Text = "Rechazar";
            buttonRechazar.UseVisualStyleBackColor = false;
            buttonRechazar.Click += buttonRechazar_Click_1;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(567, 205);
            labelError.Name = "labelError";
            labelError.Size = new Size(38, 15);
            labelError.TabIndex = 3;
            labelError.Text = "Error: ";
            // 
            // labelSolicitudes
            // 
            labelSolicitudes.AutoSize = true;
            labelSolicitudes.Location = new Point(228, 19);
            labelSolicitudes.Name = "labelSolicitudes";
            labelSolicitudes.Size = new Size(64, 15);
            labelSolicitudes.TabIndex = 4;
            labelSolicitudes.Text = "Solicitudes";
            // 
            // AprobacionDeProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSolicitudes);
            Controls.Add(labelError);
            Controls.Add(buttonRechazar);
            Controls.Add(buttonAceptar);
            Controls.Add(dataGridView1);
            Name = "AprobacionDeProductos";
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
        private Label labelError;
        private Label labelSolicitudes;
    }
}