namespace SubastaMaestra_Escritorio
{
    partial class InformeSubastaMasPopulares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformeSubastaMasPopulares));
            dataGridViewMasPopulares = new DataGridView();
            dateTimePickerInicio = new DateTimePicker();
            dateTimePickerFin = new DateTimePicker();
            buttonGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonBuscar = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMasPopulares).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMasPopulares
            // 
            dataGridViewMasPopulares.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewMasPopulares.BackgroundColor = Color.White;
            dataGridViewMasPopulares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMasPopulares.Location = new Point(12, 178);
            dataGridViewMasPopulares.Name = "dataGridViewMasPopulares";
            dataGridViewMasPopulares.Size = new Size(496, 310);
            dataGridViewMasPopulares.TabIndex = 0;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Font = new Font("Century Gothic", 9.75F);
            dateTimePickerInicio.Location = new Point(127, 72);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(200, 23);
            dateTimePickerInicio.TabIndex = 1;
        
            // 
            // dateTimePickerFin
            // 
            dateTimePickerFin.Font = new Font("Century Gothic", 9.75F);
            dateTimePickerFin.Location = new Point(127, 115);
            dateTimePickerFin.Name = "dateTimePickerFin";
            dateTimePickerFin.Size = new Size(200, 23);
            dateTimePickerFin.TabIndex = 2;
            // 
            // buttonGuardar
            // 
            buttonGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            buttonGuardar.FlatAppearance.MouseOverBackColor = Color.Green;
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGuardar.Location = new Point(514, 188);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(123, 25);
            buttonGuardar.TabIndex = 3;
            buttonGuardar.Text = "Guardar Informe";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 72);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 4;
            label1.Text = "Desde:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 115);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 5;
            label2.Text = "Hasta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(224, 9);
            label3.Name = "label3";
            label3.Size = new Size(255, 22);
            label3.TabIndex = 6;
            label3.Text = "SUBASTAS MAS POPULARES";
            // 
            // buttonBuscar
            // 
            buttonBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            buttonBuscar.FlatAppearance.MouseOverBackColor = Color.Green;
            buttonBuscar.FlatStyle = FlatStyle.Flat;
            buttonBuscar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBuscar.Image = (Image)resources.GetObject("buttonBuscar.Image");
            buttonBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBuscar.Location = new Point(346, 95);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(123, 23);
            buttonBuscar.TabIndex = 7;
            buttonBuscar.Text = "  Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 42);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 8;
            label4.Text = "Periodo de tiempo:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(34, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(445, 110);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // InformeSubastaMasPopulares
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(664, 522);
            Controls.Add(label4);
            Controls.Add(buttonBuscar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonGuardar);
            Controls.Add(dateTimePickerFin);
            Controls.Add(dateTimePickerInicio);
            Controls.Add(dataGridViewMasPopulares);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InformeSubastaMasPopulares";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InformeSubastaMasPopulares";
          
            ((System.ComponentModel.ISupportInitialize)dataGridViewMasPopulares).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMasPopulares;
        private DateTimePicker dateTimePickerInicio;
        private DateTimePicker dateTimePickerFin;
        private Button buttonGuardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonBuscar;
        private Label label4;
        private PictureBox pictureBox1;
    }
}