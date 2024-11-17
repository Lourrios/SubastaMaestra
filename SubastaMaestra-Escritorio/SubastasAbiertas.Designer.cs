namespace SubastaMaestra_Escritorio
{
    partial class SubastaAbiertas
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
            buttonRefresh = new Button();
            buttonSalir = new Button();
            dataGridView1 = new DataGridView();
            textBoxBuscarNombre = new TextBox();
            label2 = new Label();
            buttonDetalles = new Button();
            buttonFinalizar = new Button();
            panel1 = new Panel();
            labelDetalles = new Label();
            groupBox1 = new GroupBox();
            buttonCantProd = new Button();
            label6 = new Label();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            buttonFecha = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(300, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 1;
            label1.Text = "Subastas Abiertas";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonRefresh.Location = new Point(327, 500);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(75, 23);
            buttonRefresh.TabIndex = 3;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSalir.Location = new Point(626, 500);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(75, 23);
            buttonSalir.TabIndex = 4;
            buttonSalir.Text = "Exit";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(390, 304);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // textBoxBuscarNombre
            // 
            textBoxBuscarNombre.Location = new Point(128, 16);
            textBoxBuscarNombre.Name = "textBoxBuscarNombre";
            textBoxBuscarNombre.Size = new Size(150, 23);
            textBoxBuscarNombre.TabIndex = 5;
            textBoxBuscarNombre.TextChanged += textBoxBuscarNombre_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 6;
            label2.Text = "Buscar por nombre:";
            // 
            // buttonDetalles
            // 
            buttonDetalles.Location = new Point(12, 500);
            buttonDetalles.Name = "buttonDetalles";
            buttonDetalles.Size = new Size(75, 23);
            buttonDetalles.TabIndex = 7;
            buttonDetalles.Text = "Ver detalles";
            buttonDetalles.UseVisualStyleBackColor = true;
            buttonDetalles.Click += button1_Click;
            // 
            // buttonFinalizar
            // 
            buttonFinalizar.Location = new Point(140, 500);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(75, 23);
            buttonFinalizar.TabIndex = 8;
            buttonFinalizar.Text = "Finalizar Subasta";
            buttonFinalizar.UseVisualStyleBackColor = true;
            buttonFinalizar.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelDetalles);
            panel1.Location = new Point(420, 165);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 304);
            panel1.TabIndex = 9;
            // 
            // labelDetalles
            // 
            labelDetalles.AutoSize = true;
            labelDetalles.Location = new Point(14, 12);
            labelDetalles.Name = "labelDetalles";
            labelDetalles.Size = new Size(38, 15);
            labelDetalles.TabIndex = 0;
            labelDetalles.Text = "label7";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonCantProd);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxBuscarNombre);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 132);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // buttonCantProd
            // 
            buttonCantProd.Location = new Point(288, 103);
            buttonCantProd.Name = "buttonCantProd";
            buttonCantProd.Size = new Size(75, 23);
            buttonCantProd.TabIndex = 15;
            buttonCantProd.Text = "Buscar";
            buttonCantProd.UseVisualStyleBackColor = true;
            buttonCantProd.Click += buttonCantProd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 80);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 14;
            label6.Text = "Cierre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(112, 52);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 13;
            label5.Text = "Inicio";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(171, 74);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(219, 23);
            dateTimePicker2.TabIndex = 12;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(211, 103);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(46, 23);
            numericUpDown2.TabIndex = 11;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 105);
            label4.Name = "label4";
            label4.Size = new Size(172, 15);
            label4.TabIndex = 9;
            label4.Text = "Buscar por cantidad productos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 52);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 8;
            label3.Text = "Buscar por fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(171, 44);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // buttonFecha
            // 
            buttonFecha.Location = new Point(420, 79);
            buttonFecha.Name = "buttonFecha";
            buttonFecha.Size = new Size(75, 23);
            buttonFecha.TabIndex = 11;
            buttonFecha.Text = "Buscar";
            buttonFecha.UseVisualStyleBackColor = true;
            buttonFecha.Click += buttonFecha_Click;
            // 
            // SubastaAbiertas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 522);
            Controls.Add(buttonFecha);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(buttonFinalizar);
            Controls.Add(buttonDetalles);
            Controls.Add(buttonSalir);
            Controls.Add(buttonRefresh);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "SubastaAbiertas";
            Text = "Subasta Abiertas";
            Load += Form2_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button buttonRefresh;
        private Button buttonSalir;
        private DataGridView dataGridView1;
        private TextBox textBoxBuscarNombre;
        private Label label2;
        private Button buttonDetalles;
        private Button buttonFinalizar;
        private Panel panel1;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private Button buttonFecha;
        private Label labelDetalles;
        private Button buttonCantProd;
    }
}