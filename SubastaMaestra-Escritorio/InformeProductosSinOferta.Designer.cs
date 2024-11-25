namespace SubastaMaestra_Escritorio
{
    partial class InformeProductosSinOferta
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
            buttonGuardar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.InfoText;
            dataGridView1.Location = new Point(28, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(490, 414);
            dataGridView1.TabIndex = 0;
            // 
            // buttonGuardar
            // 
            buttonGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            buttonGuardar.FlatAppearance.MouseOverBackColor = Color.Green;
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGuardar.Location = new Point(524, 94);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(134, 28);
            buttonGuardar.TabIndex = 1;
            buttonGuardar.Text = "Guardar Informe";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 31);
            label1.Name = "label1";
            label1.Size = new Size(349, 24);
            label1.TabIndex = 2;
            label1.Text = "Informe de Productos Sin Ofertas:";
            // 
            // InformeProductosSinOferta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(664, 522);
            Controls.Add(label1);
            Controls.Add(buttonGuardar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "InformeProductosSinOferta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InformeProductosSinOferta";
            Load += InformeProductosSinOferta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonGuardar;
        private Label label1;
    }
}