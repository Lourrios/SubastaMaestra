namespace SubastaMaestra_Escritorio
{
    partial class CrearSubastaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearSubastaForm));
            buttonGuardar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxTitle = new TextBox();
            buttonCancelar = new Button();
            dateTimePickerStar = new DateTimePicker();
            dateTimePickerFinish = new DateTimePicker();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonGuardar
            // 
            buttonGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            buttonGuardar.FlatAppearance.MouseOverBackColor = Color.Green;
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGuardar.ForeColor = Color.Black;
            buttonGuardar.Image = (Image)resources.GetObject("buttonGuardar.Image");
            buttonGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonGuardar.Location = new Point(405, 79);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.RightToLeft = RightToLeft.No;
            buttonGuardar.Size = new Size(97, 23);
            buttonGuardar.TabIndex = 0;
            buttonGuardar.Text = "    Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 79);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 1;
            label1.Text = "Titulo:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 137);
            label2.Name = "label2";
            label2.Size = new Size(110, 17);
            label2.TabIndex = 2;
            label2.Text = "Fecha de Inicio:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 199);
            label3.Name = "label3";
            label3.Size = new Size(93, 17);
            label3.TabIndex = 3;
            label3.Text = "Fecha de Fin:";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTitle.Font = new Font("Century Gothic", 9.75F);
            textBoxTitle.Location = new Point(151, 80);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(215, 23);
            textBoxTitle.TabIndex = 4;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            buttonCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCancelar.Image = (Image)resources.GetObject("buttonCancelar.Image");
            buttonCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancelar.Location = new Point(405, 130);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.RightToLeft = RightToLeft.No;
            buttonCancelar.Size = new Size(97, 24);
            buttonCancelar.TabIndex = 8;
            buttonCancelar.Text = "   Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerStar
            // 
            dateTimePickerStar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerStar.Font = new Font("Century Gothic", 9.75F);
            dateTimePickerStar.Location = new Point(152, 137);
            dateTimePickerStar.Name = "dateTimePickerStar";
            dateTimePickerStar.Size = new Size(214, 23);
            dateTimePickerStar.TabIndex = 9;
            // 
            // dateTimePickerFinish
            // 
            dateTimePickerFinish.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerFinish.Font = new Font("Century Gothic", 9.75F);
            dateTimePickerFinish.Location = new Point(152, 193);
            dateTimePickerFinish.Name = "dateTimePickerFinish";
            dateTimePickerFinish.Size = new Size(214, 23);
            dateTimePickerFinish.TabIndex = 10;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(170, 30);
            label4.Name = "label4";
            label4.Size = new Size(158, 24);
            label4.TabIndex = 11;
            label4.Text = "Crear Subasta:";
            // 
            // CrearSubastaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(514, 303);
            Controls.Add(label4);
            Controls.Add(dateTimePickerFinish);
            Controls.Add(dateTimePickerStar);
            Controls.Add(buttonCancelar);
            Controls.Add(textBoxTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonGuardar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CrearSubastaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrearSubastaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGuardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxTitle;
        private Button buttonCancelar;
        private DateTimePicker dateTimePickerStar;
        private DateTimePicker dateTimePickerFinish;
        private Label label4;
    }
}