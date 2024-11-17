namespace SubastaMaestra_Escritorio
{
    partial class InformeGanancias
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
            buttonGenerar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.MenuBar;
            dataGridView1.Location = new Point(52, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(461, 363);
            dataGridView1.TabIndex = 0;
            // 
            // buttonGenerar
            // 
            buttonGenerar.Location = new Point(544, 94);
            buttonGenerar.Name = "buttonGenerar";
            buttonGenerar.Size = new Size(107, 23);
            buttonGenerar.TabIndex = 1;
            buttonGenerar.Text = "Generar Informe";
            buttonGenerar.UseVisualStyleBackColor = true;
            buttonGenerar.Click += buttonGenerar_Click;
            // 
            // InformeGanancias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 522);
            Controls.Add(buttonGenerar);
            Controls.Add(dataGridView1);
            Name = "InformeGanancias";
            Text = "InformeGanancias";
            Load += InformeGanancias_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonGenerar;
    }
}