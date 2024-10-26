namespace SubastaMaestra_Escritorio
{
    partial class Menu
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
            label1 = new Label();
            label3 = new Label();
            dataGridViewSubastas = new DataGridView();
            label4 = new Label();
            label2 = new Label();
            button1 = new Button();
            dateTimePickerInicio = new DateTimePicker();
            label5 = new Label();
            textNombreSubasta = new TextBox();
            dateTimePickerCierre = new DateTimePicker();
            buttonModificar = new Button();
            buttonCrear = new Button();
            buttonEditar = new Button();
            buttonRefresh = new Button();
            panel1 = new Panel();
            buttonDeshabilitar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubastas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 36);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Crear Subasta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 124);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // dataGridViewSubastas
            // 
            dataGridViewSubastas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewSubastas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSubastas.Location = new Point(12, 74);
            dataGridViewSubastas.Name = "dataGridViewSubastas";
            dataGridViewSubastas.Size = new Size(457, 376);
            dataGridViewSubastas.TabIndex = 12;
           
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 110);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha de Inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 67);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre de Subasta:";
            // 
            // button1
            // 
            button1.Location = new Point(16, 215);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.Location = new Point(150, 110);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(200, 23);
            dateTimePickerInicio.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 158);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha de Cierre:";
            // 
            // textNombreSubasta
            // 
            textNombreSubasta.Location = new Point(150, 59);
            textNombreSubasta.Name = "textNombreSubasta";
            textNombreSubasta.Size = new Size(200, 23);
            textNombreSubasta.TabIndex = 8;
            // 
            // dateTimePickerCierre
            // 
            dateTimePickerCierre.Location = new Point(150, 158);
            dateTimePickerCierre.Name = "dateTimePickerCierre";
            dateTimePickerCierre.Size = new Size(200, 23);
            dateTimePickerCierre.TabIndex = 6;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(160, 215);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(75, 23);
            buttonModificar.TabIndex = 11;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonCrear
            // 
            buttonCrear.Location = new Point(20, 42);
            buttonCrear.Name = "buttonCrear";
            buttonCrear.Size = new Size(125, 23);
            buttonCrear.TabIndex = 13;
            buttonCrear.Text = "Crear Subasta";
            buttonCrear.UseVisualStyleBackColor = true;
            buttonCrear.Click += buttonCrear_Click_1;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(20, 87);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(125, 23);
            buttonEditar.TabIndex = 14;
            buttonEditar.Text = "Editar Subasta";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(20, 197);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(125, 23);
            buttonRefresh.TabIndex = 23;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Right;
            panel1.Controls.Add(buttonDeshabilitar);
            panel1.Controls.Add(buttonRefresh);
            panel1.Controls.Add(buttonEditar);
            panel1.Controls.Add(buttonCrear);
            panel1.Location = new Point(501, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 376);
            panel1.TabIndex = 24;
            // 
            // buttonDeshabilitar
            // 
            buttonDeshabilitar.Location = new Point(20, 150);
            buttonDeshabilitar.Name = "buttonDeshabilitar";
            buttonDeshabilitar.Size = new Size(125, 23);
            buttonDeshabilitar.TabIndex = 24;
            buttonDeshabilitar.Text = "Deshabilitar";
            buttonDeshabilitar.UseVisualStyleBackColor = true;
            buttonDeshabilitar.Click += buttonDeshabilitar_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 522);
            Controls.Add(panel1);
            Controls.Add(dataGridViewSubastas);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Menu";
            Load += CrearSubasta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubastas).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private DataGridView dataGridViewSubastas;
        private Label label4;
        private Label label2;
        private Button button1;
        private DateTimePicker dateTimePickerInicio;
        private Label label5;
        private TextBox textNombreSubasta;
        private DateTimePicker dateTimePickerCierre;
        private Button buttonModificar;
        private Button buttonCrear;
        private Button buttonEditar;
        private Button buttonRefresh;
        private Panel panel1;
        private Button buttonDeshabilitar;
    }
}