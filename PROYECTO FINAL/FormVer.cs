using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class FormVer : Form
    {
        string archivo = "prestamos.txt";
        public FormVer()
        {
            InitializeComponent();
        }

        private void bactu_Click(object sender, EventArgs e)
        {
            Cargardatos();
        }

        private void FormVer_Load(object sender, EventArgs e)
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

            if (!File.Exists(archivo))
            {
                return;
            }

            string[] lineas = File.ReadAllLines(archivo);

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(';');

                if (datos.Length == 5)
                {
                    dgvPrestamos.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4]);
                }
            }
        }

        private void bvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
