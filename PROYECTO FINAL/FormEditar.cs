using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class FormEditar : Form
    {
        string archivo = "prestamos.txt";

        // Guardamos todas las líneas del archivo tal cual están
        List<string> lineas = new List<string>();

        // Índice de la línea del archivo que se está editando (-1 = ninguna)
        int lineaSeleccionada = -1;

        public FormEditar()
        {
            InitializeComponent();
        }

        private void FormEditar_Load(object sender, EventArgs e)
        {
            Cargardatos();
        }

        private void Cargardatos()
        {
            dgvPrestamos.Rows.Clear();
            dgvPrestamos.Columns.Clear();

            dgvPrestamos.Columns.Add("Nombre", "Nombre");
            dgvPrestamos.Columns.Add("Numero", "Número");
            dgvPrestamos.Columns.Add("Monto", "Monto");
            dgvPrestamos.Columns.Add("Fecha", "Fecha");
            dgvPrestamos.Columns.Add("Estado", "Estado");

            lineas.Clear();
            lineaSeleccionada = -1;
            LimpiarCampos();

            if (!File.Exists(archivo))
            {
                return;
            }

            lineas.AddRange(File.ReadAllLines(archivo));

            for (int i = 0; i < lineas.Count; i++)
            {
                string[] datos = lineas[i].Split(';');

                if (datos.Length != 5)
                {
                    continue;
                }

                int fila = dgvPrestamos.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4]);

                // Guardamos en el Tag la posición real dentro del archivo
                dgvPrestamos.Rows[fila].Tag = i;
            }
        }

        // Al hacer clic en una fila, se cargan los datos en las cajas de texto
        private void dgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila = dgvPrestamos.Rows[e.RowIndex];

            if (fila.Tag == null)
            {
                return;
            }

            lineaSeleccionada = Convert.ToInt32(fila.Tag);

            string[] datos = lineas[lineaSeleccionada].Split(';');

            txtnombre.Text = datos[0];
            txtnum.Text = datos[1];
            txtmonto.Text = datos[2];
            string estado = datos[4];


            DateTime fecha;

            if (DateTime.TryParse(datos[3], out fecha))
            {
                dtfecha.Value = fecha;
            }
            else
            {
                dtfecha.Value = DateTime.Now;
            }
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            if (lineaSeleccionada == -1)
            {
                MessageBox.Show("Seleccione primero un préstamo en la tabla.");
                return;
            }

            if (txtnombre.Text.Trim() == "" || txtnum.Text.Trim() == "" || txtmonto.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, complete todos los campos antes de guardar.");
                return;
            }

            // El punto y coma es el separador del archivo, no se puede usar dentro de los datos
            if (txtnombre.Text.Contains(";") || txtnum.Text.Contains(";") || txtmonto.Text.Contains(";"))
            {
                MessageBox.Show("No se permite el carácter ';' dentro de los datos.");
                return;
            }

            decimal monto;

            if (!decimal.TryParse(txtmonto.Text, out monto))
            {
                MessageBox.Show("Por favor, ingrese un monto válido.");
                return;
            }

            DialogResult confirmar = MessageBox.Show(
                "¿Seguro que desea guardar los cambios de este préstamo?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmar == DialogResult.No)
            {
                return;
            }

            // Reemplazamos solamente la línea seleccionada y reescribimos el archivo
            string[] datos = lineas[lineaSeleccionada].Split(';');

            string estado = "Pendiente";

            if (datos.Length >= 5)
            {
                estado = datos[4];
            }

            lineas[lineaSeleccionada] =
                txtnombre.Text.Trim() + ";" +
                txtnum.Text.Trim() + ";" +
                txtmonto.Text.Trim() + ";" +
                dtfecha.Value.ToShortDateString() + ";" +
                estado;

            File.WriteAllLines(archivo, lineas);

            MessageBox.Show("Préstamo actualizado correctamente.");

            Cargardatos();
        }

        private void bcancelar_Click(object sender, EventArgs e)
        {
            lineaSeleccionada = -1;
            LimpiarCampos();
            dgvPrestamos.ClearSelection();
        }

        private void LimpiarCampos()
        {
            txtnombre.Clear();
            txtnum.Clear();
            txtmonto.Clear();
            dtfecha.Value = DateTime.Now;
        }

        private void bvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bestado_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.CurrentRow == null)
                return;

            int fila = dgvPrestamos.CurrentRow.Index;

            string[] lineas = File.ReadAllLines(archivo);

            string[] datos = lineas[fila].Split(';');

            if (datos.Length == 4)
            {
                Array.Resize(ref datos, 5);
                datos[4] = "Pendiente";
            }

            datos[4] = "Devuelto";

            lineas[fila] = string.Join(";", datos);

            File.WriteAllLines(archivo, lineas);

            MessageBox.Show("Estado actualizado.");

            Cargardatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.CurrentRow == null)
                return;

            int fila = dgvPrestamos.CurrentRow.Index;

            List<string> lineas = new List<string>(File.ReadAllLines(archivo));

            lineas.RemoveAt(fila);

            File.WriteAllLines(archivo, lineas);

            MessageBox.Show("Préstamo eliminado.");

            Cargardatos();
        }
    }
}
