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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(497, 372);
            dataGridView1.TabIndex = 0;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(543, 82);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(110, 23);
            buttonGuardar.TabIndex = 1;
            buttonGuardar.Text = "Guardar Informe";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // InformeProductosSinOferta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 522);
            Controls.Add(buttonGuardar);
            Controls.Add(dataGridView1);
            Name = "InformeProductosSinOferta";
            Text = "InformeProductosSinOferta";
            Load += InformeProductosSinOferta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonGuardar;
    }
}