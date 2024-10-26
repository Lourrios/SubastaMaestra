namespace SubastaMaestra_Escritorio
{
    partial class ListaDeOferentes
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
            dataGridViewOfertas = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            buttonOfertas = new Button();
            textBoxIdProd = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOfertas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOfertas
            // 
            dataGridViewOfertas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewOfertas.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewOfertas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOfertas.Location = new Point(12, 104);
            dataGridViewOfertas.Name = "dataGridViewOfertas";
            dataGridViewOfertas.Size = new Size(498, 277);
            dataGridViewOfertas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(334, 34);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(530, 132);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Id Producto:";
            // 
            // buttonOfertas
            // 
            buttonOfertas.Location = new Point(530, 192);
            buttonOfertas.Name = "buttonOfertas";
            buttonOfertas.Size = new Size(128, 32);
            buttonOfertas.TabIndex = 3;
            buttonOfertas.Text = "Cargar Ofertas";
            buttonOfertas.UseVisualStyleBackColor = true;
            buttonOfertas.Click += buttonOfertas_Click;
            // 
            // textBoxIdProd
            // 
            textBoxIdProd.Location = new Point(608, 129);
            textBoxIdProd.Name = "textBoxIdProd";
            textBoxIdProd.Size = new Size(100, 23);
            textBoxIdProd.TabIndex = 4;
            // 
            // ListaDeOferentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxIdProd);
            Controls.Add(buttonOfertas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewOfertas);
            Name = "ListaDeOferentes";
            Text = "ListaDeOferentes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOfertas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewOfertas;
        private Label label1;
        private Label label2;
        private Button buttonOfertas;
        private TextBox textBoxIdProd;
    }
}