namespace SubastaMaestra_Escritorio
{
    partial class InformeUsuariosMasActivos
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
            dataGridViewUserMasActivo = new DataGridView();
            buttonGuardar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserMasActivo).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUserMasActivo
            // 
            dataGridViewUserMasActivo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewUserMasActivo.BackgroundColor = Color.White;
            dataGridViewUserMasActivo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUserMasActivo.Location = new Point(40, 65);
            dataGridViewUserMasActivo.Name = "dataGridViewUserMasActivo";
            dataGridViewUserMasActivo.Size = new Size(433, 315);
            dataGridViewUserMasActivo.TabIndex = 0;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buttonGuardar.Location = new Point(479, 82);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(111, 23);
            buttonGuardar.TabIndex = 1;
            buttonGuardar.Text = "Guardar Informe";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 25);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 2;
            label1.Text = "USUARIOS MAS ACTIVOS";
            // 
            // InformeUsuariosMasActivos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(665, 450);
            Controls.Add(label1);
            Controls.Add(buttonGuardar);
            Controls.Add(dataGridViewUserMasActivo);
            Name = "InformeUsuariosMasActivos";
            Text = "InformeUsuariosMasActivos";
            Load += InformeUsuariosMasActivos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUserMasActivo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUserMasActivo;
        private Button buttonGuardar;
        private Label label1;
    }
}