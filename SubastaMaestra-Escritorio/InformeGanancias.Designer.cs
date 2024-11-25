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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformeGanancias));
            dataGridView1 = new DataGridView();
            buttonGenerar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.MenuBar;
            dataGridView1.Location = new Point(23, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(452, 363);
            dataGridView1.TabIndex = 0;
            // 
            // buttonGenerar
            // 
            buttonGenerar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonGenerar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            buttonGenerar.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            buttonGenerar.FlatStyle = FlatStyle.Flat;
            buttonGenerar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGenerar.Location = new Point(481, 100);
            buttonGenerar.Name = "buttonGenerar";
            buttonGenerar.Size = new Size(124, 23);
            buttonGenerar.TabIndex = 1;
            buttonGenerar.Text = "Generar Informe";
            buttonGenerar.UseVisualStyleBackColor = true;
            buttonGenerar.Click += buttonGenerar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 35);
            label1.Name = "label1";
            label1.Size = new Size(277, 30);
            label1.TabIndex = 2;
            label1.Text = "Informe de ganancias";
            // 
            // InformeGanancias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(664, 522);
            Controls.Add(label1);
            Controls.Add(buttonGenerar);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InformeGanancias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InformeGanancias";
            Load += InformeGanancias_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonGenerar;
        private Label label1;
    }
}