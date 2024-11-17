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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            buttonOferentes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(63, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(492, 309);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 24);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 1;
            label1.Text = "Lista de productos";
            // 
            // buttonOferentes
            // 
            buttonOferentes.Location = new Point(561, 79);
            buttonOferentes.Name = "buttonOferentes";
            buttonOferentes.Size = new Size(85, 23);
            buttonOferentes.TabIndex = 2;
            buttonOferentes.Text = "Ver Oferentes";
            buttonOferentes.UseVisualStyleBackColor = true;
            buttonOferentes.Click += buttonOferentes_Click;
            // 
            // ListaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOferentes);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ListaProductos";
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