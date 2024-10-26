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
            dataGridViewSubastas = new DataGridView();
            label9 = new Label();
            comboBoxSubastas = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubastas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSubastas
            // 
            dataGridViewSubastas.Anchor = AnchorStyles.Left;
            dataGridViewSubastas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSubastas.Location = new Point(112, 81);
            dataGridViewSubastas.Name = "dataGridViewSubastas";
            dataGridViewSubastas.Size = new Size(572, 282);
            dataGridViewSubastas.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(275, 42);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 27;
            label9.Text = "Subastas:";
            // 
            // comboBoxSubastas
            // 
            comboBoxSubastas.FormattingEnabled = true;
            comboBoxSubastas.Location = new Point(353, 42);
            comboBoxSubastas.Name = "comboBoxSubastas";
            comboBoxSubastas.Size = new Size(121, 23);
            comboBoxSubastas.TabIndex = 26;
            comboBoxSubastas.SelectedIndexChanged += comboBoxSubastas_SelectedIndexChanged;
            // 
            // FiltroSubasta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(comboBoxSubastas);
            Controls.Add(dataGridViewSubastas);
            Name = "FiltroSubasta";
            Text = "FiltroSubasta";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubastas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSubastas;
        private Label label9;
        private ComboBox comboBoxSubastas;
    }
}