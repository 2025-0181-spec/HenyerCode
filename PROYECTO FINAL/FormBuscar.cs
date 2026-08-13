using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class FormBuscar : Form
    {
        string archivo = "prestamos.txt";

        public FormBuscar()
        {
            InitializeComponent();
        }

        private void FormBuscar_Load(object sender, EventArgs e)
        {
            PrepararTabla();
            lblresultado.Text = "";
            txtbuscar.Focus();
        }

        private void PrepararTabla()
        {
            dgvResultados.Rows.Clear();
            dgvResultados.Columns.Clear();

            dgvResultados.Columns.Add("Nombre", "Nombre");
            dgvResultados.Columns.Add("Numero", "Número");
            dgvResultados.Columns.Add("Monto", "Monto");
            dgvResultados.Columns.Add("Fecha", "Fecha");
            dgvResultados.Columns.Add("Estado", "Estado");
        }

        private void bbuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            string filtro = txtbuscar.Text.Trim().ToLower();

            PrepararTabla();

            if (filtro == "")
            {
                lblresultado.Text = "";
                MessageBox.Show("Escriba un nombre o un número de teléfono para buscar.");
                txtbuscar.Focus();
                return;
            }

            if (!File.Exists(archivo))
            {
                lblresultado.Text = "";
                MessageBox.Show("Todavía no hay préstamos registrados.");
                return;
            }

            string[] lineas = File.ReadAllLines(archivo);
            int encontrados = 0;

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(';');

                if (datos.Length != 5)
                {
                    continue;
                }

                // Busca por nombre o por número (coincidencia parcial)
                if (datos[0].ToLower().Contains(filtro) || datos[1].ToLower().Contains(filtro))
                {
                    dgvResultados.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4]);
                    encontrados++;
                }
            }

            if (encontrados == 0)
            {
                lblresultado.Text = "No se encontró ningún préstamo con ese dato.";
            }
            else if (encontrados == 1)
            {
                lblresultado.Text = "Se encontró 1 préstamo.";
            }
            else
            {
                lblresultado.Text = "Se encontraron " + encontrados + " préstamos.";
            }
        }

        // Permite buscar presionando Enter dentro de la caja de texto
        private void txtbuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Buscar();
            }
        }

        private void bvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
