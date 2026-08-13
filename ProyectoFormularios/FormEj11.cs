using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoFormularios
{
    public class FormEj11 : Form
    {
        private TextBox t0 = new TextBox();
        private TextBox t1 = new TextBox();
        private Button btn = new Button();
        private TextBox txtOut = new TextBox();

        public FormEj11()
        {
            this.Text = "Ejercicio 11 - Factura con IVA";
            this.Size = new Size(540, 428);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label titulo = new Label();
            titulo.Text = "IVA del 15% y descuento del 5% si el precio bruto supera 50.";
            titulo.SetBounds(20, 15, 490, 45);
            titulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.Controls.Add(titulo);
            int y = 70;

            Label l0 = new Label();
            l0.Text = "Precio unitario:";
            l0.SetBounds(20, y, 180, 22);
            this.Controls.Add(l0);
            t0.SetBounds(210, y, 300, 24);
            this.Controls.Add(t0);
            y += 34;

            Label l1 = new Label();
            l1.Text = "Numero de articulos:";
            l1.SetBounds(20, y, 180, 22);
            this.Controls.Add(l1);
            t1.SetBounds(210, y, 300, 24);
            this.Controls.Add(t1);
            y += 34;

            btn.Text = "Calcular";
            btn.SetBounds(20, y, 110, 32);
            btn.Click += btn_Click;
            this.Controls.Add(btn);
            y += 42;

            txtOut.Multiline = true;
            txtOut.ReadOnly = true;
            txtOut.ScrollBars = ScrollBars.Vertical;
            txtOut.BackColor = Color.White;
            txtOut.SetBounds(20, y, 490, 130);
            this.Controls.Add(txtOut);
        }

        private void btn_Click(object? sender, EventArgs e)
        {
            try
            {
                double precio = double.Parse(t0.Text);
                double num = double.Parse(t1.Text);
                double precioVenta = precio * num;
                double iva = Math.Round(precioVenta * 0.15, 2);
                double bruto = precioVenta + iva;
                double descuento = bruto >= 50 ? Math.Round(bruto * 5 / 100.0, 2) : 0;
                double totalPagar = bruto - descuento;
                string res = "Precio de venta: " + precioVenta + "\r\nIVA (15%): " + iva +
                    "\r\nPrecio bruto: " + bruto + "\r\nDescuento: " + descuento +
                    "\r\nTotal a pagar: " + totalPagar;
                txtOut.Text = res;
            }
            catch (Exception ex)
            {
                txtOut.Text = "Error: revisa los datos ingresados. (" + ex.Message + ")";
            }
        }
    }
}
