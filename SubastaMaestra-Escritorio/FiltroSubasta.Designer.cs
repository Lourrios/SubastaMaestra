namespace SubastaMaestra_Escritorio
{
    partial class FiltroSubasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltroSubasta));
            dataGridViewSubastas = new DataGridView();
            label9 = new Label();
            comboBoxSubastas = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubastas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSubastas
            // 
            dataGridViewSubastas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewSubastas.BackgroundColor = Color.White;
            dataGridViewSubastas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSubastas.GridColor = SystemColors.MenuText;
            dataGridViewSubastas.Location = new Point(60, 104);
            dataGridViewSubastas.Name = "dataGridViewSubastas";
            dataGridViewSubastas.Size = new Size(572, 354);
            dataGridViewSubastas.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(80, 73);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 27;
            label9.Text = "Subastas:";
            // 
            // comboBoxSubastas
            // 
            comboBoxSubastas.FlatStyle = FlatStyle.System;
            comboBoxSubastas.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxSubastas.FormattingEnabled = true;
            comboBoxSubastas.Location = new Point(162, 70);
            comboBoxSubastas.Name = "comboBoxSubastas";
            comboBoxSubastas.Size = new Size(121, 25);
            comboBoxSubastas.TabIndex = 26;
            comboBoxSubastas.SelectedIndexChanged += comboBoxSubastas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 25);
            label1.Name = "label1";
            label1.Size = new Size(222, 21);
            label1.TabIndex = 28;
            label1.Text = "Buscar subastas por estado";
            // 
            // FiltroSubasta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(664, 522);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(comboBoxSubastas);
            Controls.Add(dataGridViewSubastas);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FiltroSubasta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Subastas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubastas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSubastas;
        private Label label9;
        private ComboBox comboBoxSubastas;
        private Label label1;
    }
}