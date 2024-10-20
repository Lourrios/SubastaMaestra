﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SubastaMaestra.Models;
using SubastaMaestra.Models.DTOs.Auction;


namespace SubastaMaestra_Escritorio
{
    public partial class SubastaAbiertas : Form
    {
        public SubastaAbiertas()
        {
            InitializeComponent();


        }
        private void Form2_Load_1(object sender, EventArgs e)
        {
            // Crear columnas
            dataGridView1.Columns.Add("NombreSubasta", "Nombre Subasta");
            dataGridView1.Columns.Add("FechaInicio", "Fecha Inicio");
            dataGridView1.Columns.Add("FechaCierre", "Fecha Cierre");
            dataGridView1.Columns.Add("CantidadProductos", "Cantidad de Productos");
            dataGridView1.Columns.Add("EstadoSubasta", "Estado");
            dataGridView1.Columns.Add("NumeroOfertas", "Número de Ofertas");

            // Datos ficticios
            dataGridView1.Rows.Add("Subasta Muebles", "02/10/2024", "12/10/2024", "3", "Activa", "2");
            dataGridView1.Rows.Add("Subasta Electrónica", "03/10/2024", "13/10/2024", "4", "Finalizada", "5");
            dataGridView1.Rows.Add("Subasta Inmuebles", "01/10/2024", "05/10/2024", "1", "Activa", "1");
            dataGridView1.Rows.Add("Subasta Arte", "06/10/2024", "14/10/2024", "2", "Activa", "4");


        }



        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            string filtro = textBoxBuscarNombre.Text;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["NombreSubasta"].Value != null)
                {
                    bool visible = row.Cells["NombreSubasta"].Value.ToString().Contains(filtro, StringComparison.OrdinalIgnoreCase);
                    row.Visible = visible;
                }
            }
        }



        private void FiltrarPorFechas(DateTime fechaInicio, DateTime fechaCierre)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["FechaInicio"].Value != null && row.Cells["FechaCierre"].Value != null)
                {
                    DateTime inicio = DateTime.Parse(row.Cells["FechaInicio"].Value.ToString());
                    DateTime cierre = DateTime.Parse(row.Cells["FechaCierre"].Value.ToString());

                    bool visible = (inicio >= fechaInicio && cierre <= fechaCierre);
                    row.Visible = visible;
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int cantidadProductos = (int)numericUpDown2.Value;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["CantidadProductos"].Value != null)
                {
                    int productos = int.Parse(row.Cells["CantidadProductos"].Value.ToString());
                    row.Visible = (productos >= cantidadProductos);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow row = dataGridView1.SelectedRows[0];
            //    string nombreSubasta = row.Cells["NombreSubasta"].Value.ToString();
            //    string condiciones = "Pago: Efectivo / Entrega: Envío a domicilio"; // Simulado

            //    labelDetalles1.Text = $"Subasta: {nombreSubasta}" +
            //        $"\nCondiciones: {condiciones}";
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                row.Cells["EstadoSubasta"].Value = "Finalizada";

                MessageBox.Show("Subasta finalizada correctamente.");
            }
            else
            {
                MessageBox.Show("Selecciona una subasta para finalizar.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                // Mostrar los detalles en el panel
                labelDetalles.Text = $"Subasta: {row.Cells["NombreSubasta"].Value}" +
                    $"\nFecha de Inicio: {row.Cells["FechaInicio"].Value}" +
                    $"\nFecha de Cierre: {row.Cells["FechaCierre"].Value}" +
                    $"\nCantidad de Productos: {row.Cells["CantidadProductos"].Value}" +
                    $"\nEstado: {row.Cells["EstadoSubasta"].Value}" +
                    $"\nNúmero de Ofertas: {row.Cells["NumeroOfertas"].Value}";

                panel1.Show();  // Mostrar el panel con los detalles
            }
            else
            {
                MessageBox.Show("Selecciona una subasta para ver los detalles.");
            }
        }



        private void buttonFecha_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dateTimePicker1.Value;
            DateTime fechaCierre = dateTimePicker2.Value;

            FiltrarPorFechas(fechaInicio, fechaCierre);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCantProd_Click(object sender, EventArgs e)
        {
            // Obtener el valor seleccionado en el NumericUpDown
            int cantidadProductos = (int)numericUpDown2.Value;

            // Filtrar las subastas por la cantidad de productos
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["CantidadProductos"].Value != null)
                {
                    int productos = int.Parse(row.Cells["CantidadProductos"].Value.ToString());
                    row.Visible = (productos >= cantidadProductos);
                }
            }
        }
    }
}