namespace SubastaMaestra_Escritorio
{
    partial class Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
            dateTimePickerFinish = new DateTimePicker();
            dateTimePickerStar = new DateTimePicker();
            buttonCancelar = new Button();
            textBoxTitle = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonGuardar = new Button();
            label4 = new Label();
            comboBoxState = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // dateTimePickerFinish
            // 
            dateTimePickerFinish.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dateTimePickerFinish.Location = new Point(112, 208);
            dateTimePickerFinish.Name = "dateTimePickerFinish";
            dateTimePickerFinish.Size = new Size(214, 22);
            dateTimePickerFinish.TabIndex = 18;
            // 
            // dateTimePickerStar
            // 
            dateTimePickerStar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dateTimePickerStar.Location = new Point(112, 151);
            dateTimePickerStar.Name = "dateTimePickerStar";
            dateTimePickerStar.Size = new Size(214, 22);
            dateTimePickerStar.TabIndex = 17;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            buttonCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Location = new Point(372, 144);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.RightToLeft = RightToLeft.No;
            buttonCancelar.Size = new Size(75, 24);
            buttonCancelar.TabIndex = 16;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxTitle.Location = new Point(111, 88);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(215, 22);
            textBoxTitle.TabIndex = 15;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label3.Location = new Point(23, 216);
            label3.Name = "label3";
            label3.Size = new Size(68, 16);
            label3.TabIndex = 14;
            label3.Text = "FinishDate:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label2.Location = new Point(23, 152);
            label2.Name = "label2";
            label2.Size = new Size(58, 16);
            label2.TabIndex = 13;
            label2.Text = "StarDate:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label1.Location = new Point(23, 88);
            label1.Name = "label1";
            label1.Size = new Size(33, 16);
            label1.TabIndex = 12;
            label1.Text = "Title:";
            // 
            // buttonGuardar
            // 
            buttonGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buttonGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            buttonGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.ForeColor = Color.Black;
            buttonGuardar.Location = new Point(372, 87);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.RightToLeft = RightToLeft.No;
            buttonGuardar.Size = new Size(75, 24);
            buttonGuardar.TabIndex = 11;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label4.Location = new Point(23, 275);
            label4.Name = "label4";
            label4.Size = new Size(38, 16);
            label4.TabIndex = 19;
            label4.Text = "State:";
            // 
            // comboBoxState
            // 
            comboBoxState.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxState.FormattingEnabled = true;
            comboBoxState.Location = new Point(112, 275);
            comboBoxState.Name = "comboBoxState";
            comboBoxState.Size = new Size(214, 24);
            comboBoxState.TabIndex = 20;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 18F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(111, 21);
            label5.Name = "label5";
            label5.Size = new Size(179, 30);
            label5.TabIndex = 21;
            label5.Text = "Editar Subasta";
            label5.Click += label5_Click;
            // 
            // Editar
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 343);
            Controls.Add(label5);
            Controls.Add(comboBoxState);
            Controls.Add(label4);
            Controls.Add(dateTimePickerFinish);
            Controls.Add(dateTimePickerStar);
            Controls.Add(buttonCancelar);
            Controls.Add(textBoxTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonGuardar);
            Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Editar";
            Text = "Editar";
            Load += Editar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerFinish;
        private DateTimePicker dateTimePickerStar;
        private Button buttonCancelar;
        private TextBox textBoxTitle;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonGuardar;
        private Label label4;
        private ComboBox comboBoxState;
        private Label label5;
    }
}