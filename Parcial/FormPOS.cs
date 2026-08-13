using System;
using System.Windows.Forms;
using System.Drawing;

namespace PuntoDeVenta
{
    public class FormPOS : Form
    {
        private Articulo articulo;
        private Label lblInfo = new Label();
        private Label lblExistencia = new Label();
        private TextBox txtCantidad = new TextBox();
        private Button btnVender = new Button();
        private TextBox txtConsola = new TextBox();

        public FormPOS()
        {
            articulo = new Articulo("A001", "Teclado mecanico", 1500, 12);
            articulo.Mensaje += MostrarMensaje;

            this.Text = "Punto de Venta - Control de Stock";
            this.Size = new Size(560, 520);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label titulo = new Label();
            titulo.Text = "PUNTO DE VENTA";
            titulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            titulo.SetBounds(20, 15, 400, 32);
            this.Controls.Add(titulo);

            lblInfo.SetBounds(20, 55, 510, 22);
            lblInfo.Font = new Font("Segoe UI", 9F);
            this.Controls.Add(lblInfo);

            lblExistencia.SetBounds(20, 82, 510, 30);
            lblExistencia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.Controls.Add(lblExistencia);

            Label lblCant = new Label();
            lblCant.Text = "Cantidad a vender:";
            lblCant.SetBounds(20, 127, 130, 24);
            this.Controls.Add(lblCant);

            txtCantidad.SetBounds(155, 124, 120, 26);
            this.Controls.Add(txtCantidad);

            btnVender.Text = "Vender";
            btnVender.SetBounds(290, 122, 110, 30);
            btnVender.Click += btnVender_Click;
            this.Controls.Add(btnVender);

            Label lblCon = new Label();
            lblCon.Text = "Consola de alertas:";
            lblCon.SetBounds(20, 165, 200, 20);
            this.Controls.Add(lblCon);

            txtConsola.Multiline = true;
            txtConsola.ReadOnly = true;
            txtConsola.ScrollBars = ScrollBars.Vertical;
            txtConsola.BackColor = Color.Black;
            txtConsola.ForeColor = Color.Lime;
            txtConsola.Font = new Font("Consolas", 10F);
            txtConsola.SetBounds(20, 188, 510, 280);
            this.Controls.Add(txtConsola);

            ActualizarInfo();
        }

        private void ActualizarInfo()
        {
            lblInfo.Text = "Codigo: " + articulo.Codigo + "     Descripcion: " + articulo.Descripcion + "     Precio: " + articulo.Precio;
            lblExistencia.Text = "Existencia actual: " + articulo.Existencia;
        }

        private void MostrarMensaje(string texto)
        {
            txtConsola.AppendText(texto + Environment.NewLine);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = int.Parse(txtCantidad.Text);
                articulo.VenderArticulo(cantidad);
                ActualizarInfo();
                txtCantidad.Clear();
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error: ingresa una cantidad valida (numero entero).");
            }
        }
    }
}
