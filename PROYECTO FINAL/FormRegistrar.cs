using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class FormRegistrar : Form
    {
        string archivo = Application.StartupPath + "\\prestamos.txt";
        public FormRegistrar()
        {
            InitializeComponent();
        }

        private void FormRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void bregistrar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "" || txtnum.Text == "" || txtmonto.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos antes de registrar el préstamo.");
                return;
            }

            decimal monto;

            if (!decimal.TryParse(txtmonto.Text, out monto))
            {
                MessageBox.Show("Por favor, ingrese un monto válido.");
                return;
            }

            string linea =
                txtnombre.Text + ";" +
                txtnum.Text + ";" +
                txtmonto.Text + ";" +
                dtfecha.Value.ToShortDateString() + ";" +
                "Pendiente";

            File.AppendAllText(archivo, linea + Environment.NewLine);

            MessageBox.Show("Préstamo registrado correctamente.");

            txtnombre.Clear();
            txtnum.Clear();
            txtmonto.Clear();

            dtfecha.Value = DateTime.Now;

            txtnombre.Focus();


        }

        private void bvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
