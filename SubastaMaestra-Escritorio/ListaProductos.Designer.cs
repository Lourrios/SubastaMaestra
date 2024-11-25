namespace SubastaMaestra_Escritorio
{
    partial class ListaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaProductos));
            dataGridView1 = new DataGridView();
            label1 = new Label();
            buttonOferentes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(473, 383);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Underline);
            label1.Location = new Point(187, 23);
            label1.Name = "label1";
            label1.Size = new Size(230, 30);
            label1.TabIndex = 1;
            label1.Text = "Lista de productos";
            // 
            // buttonOferentes
            // 
            buttonOferentes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOferentes.FlatStyle = FlatStyle.Flat;
            buttonOferentes.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonOferentes.Location = new Point(491, 68);
            buttonOferentes.Name = "buttonOferentes";
            buttonOferentes.Size = new Size(107, 29);
            buttonOferentes.TabIndex = 2;
            buttonOferentes.Text = "Ver Oferentes";
            buttonOferentes.UseVisualStyleBackColor = true;
            buttonOferentes.Click += buttonOferentes_Click;
            // 
            // ListaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(664, 522);
            Controls.Add(buttonOferentes);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ListaProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaProductos";
            Load += ListaProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button buttonOferentes;
    }
}