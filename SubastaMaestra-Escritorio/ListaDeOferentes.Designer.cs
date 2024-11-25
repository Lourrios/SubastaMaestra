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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDeOferentes));
            dataGridViewOfertas = new DataGridView();
            label1 = new Label();
            buttonExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOfertas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOfertas
            // 
            dataGridViewOfertas.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewOfertas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOfertas.Location = new Point(7, 87);
            dataGridViewOfertas.Name = "dataGridViewOfertas";
            dataGridViewOfertas.Size = new Size(542, 301);
            dataGridViewOfertas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(217, 24);
            label1.Name = "label1";
            label1.Size = new Size(189, 24);
            label1.TabIndex = 1;
            label1.Text = "Lista de oferentes";
          
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            buttonExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExit.Image = (Image)resources.GetObject("buttonExit.Image");
            buttonExit.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExit.Location = new Point(555, 87);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(69, 28);
            buttonExit.TabIndex = 2;
            buttonExit.Text = " EXIT";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // ListaDeOferentes
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(664, 476);
            Controls.Add(buttonExit);
            Controls.Add(label1);
            Controls.Add(dataGridViewOfertas);
            Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
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