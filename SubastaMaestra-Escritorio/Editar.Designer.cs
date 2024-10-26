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
            dateTimePickerFinish.Location = new Point(112, 195);
            dateTimePickerFinish.Name = "dateTimePickerFinish";
            dateTimePickerFinish.Size = new Size(214, 23);
            dateTimePickerFinish.TabIndex = 18;
            // 
            // dateTimePickerStar
            // 
            dateTimePickerStar.Location = new Point(112, 141);
            dateTimePickerStar.Name = "dateTimePickerStar";
            dateTimePickerStar.Size = new Size(214, 23);
            dateTimePickerStar.TabIndex = 17;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(410, 134);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.RightToLeft = RightToLeft.No;
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 16;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(111, 83);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(215, 23);
            textBoxTitle.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 203);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 14;
            label3.Text = "FinishDate:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 142);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 13;
            label2.Text = "StarDate:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 83);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 12;
            label1.Text = "Title:";
            // 
            // buttonGuardar
            // 
            buttonGuardar.ForeColor = Color.Black;
            buttonGuardar.Location = new Point(410, 83);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.RightToLeft = RightToLeft.No;
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 11;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 258);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 19;
            label4.Text = "State:";
            // 
            // comboBoxState
            // 
            comboBoxState.FormattingEnabled = true;
            comboBoxState.Location = new Point(112, 258);
            comboBoxState.Name = "comboBoxState";
            comboBoxState.Size = new Size(214, 23);
            comboBoxState.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(159, 27);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 21;
            label5.Text = "Editar Subasta";
            // 
            // Editar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 321);
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
            Name = "Editar";
            Text = "Editar";
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