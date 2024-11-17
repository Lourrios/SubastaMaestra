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
            buttonExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOfertas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOfertas
            // 
            dataGridViewOfertas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOfertas.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewOfertas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOfertas.Location = new Point(86, 70);
            dataGridViewOfertas.Name = "dataGridViewOfertas";
            dataGridViewOfertas.Size = new Size(542, 277);
            dataGridViewOfertas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(334, 34);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "Lista de oferentes";
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(572, 374);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(56, 23);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // ListaDeOferentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(702, 522);
            Controls.Add(buttonExit);
            Controls.Add(label1);
            Controls.Add(dataGridViewOfertas);
            Name = "ListaDeOferentes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaDeOferentes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOfertas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewOfertas;
        private Label label1;
        private Button buttonExit;
    }
}