﻿namespace SubastaMaestra_Escritorio
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
            buttonGuardar.ForeColor = Color.Black;
            buttonGuardar.Location = new Point(412, 79);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.RightToLeft = RightToLeft.No;
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 0;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 79);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 1;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 138);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "StarDate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 199);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 3;
            label3.Text = "FinishDate:";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(113, 79);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(215, 23);
            textBoxTitle.TabIndex = 4;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(412, 130);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.RightToLeft = RightToLeft.No;
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 8;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerStar
            // 
            dateTimePickerStar.Location = new Point(114, 137);
            dateTimePickerStar.Name = "dateTimePickerStar";
            dateTimePickerStar.Size = new Size(214, 23);
            dateTimePickerStar.TabIndex = 9;
            // 
            // dateTimePickerFinish
            // 
            dateTimePickerFinish.Location = new Point(114, 191);
            dateTimePickerFinish.Name = "dateTimePickerFinish";
            dateTimePickerFinish.Size = new Size(214, 23);
            dateTimePickerFinish.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 29);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 11;
            label4.Text = "Crear Subasta:";
            // 
            // CrearSubastaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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