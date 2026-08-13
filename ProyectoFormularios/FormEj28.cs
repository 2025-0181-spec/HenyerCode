using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoFormularios
{
    public class FormEj28 : Form
    {
        private TextBox t0 = new TextBox();
        private Button btn = new Button();
        private TextBox txtOut = new TextBox();

        public FormEj28()
        {
            this.Text = "Ejercicio 28 - Suma desde 8 hasta N";
            this.Size = new Size(540, 394);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label titulo = new Label();
            titulo.Text = "Suma de los enteros desde 8 hasta N: 8+9+10+...+N.";
            titulo.SetBounds(20, 15, 490, 45);
            titulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.Controls.Add(titulo);
            int y = 70;

            Label l0 = new Label();
            l0.Text = "Numero N (>=8):";
            l0.SetBounds(20, y, 180, 22);
            this.Controls.Add(l0);
            t0.SetBounds(210, y, 300, 24);
            this.Controls.Add(t0);
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
                int numero = int.Parse(t0.Text);
                string res;
                if (numero < 8) res = "Error: el numero debe ser mayor o igual a 8.";
                else {
                    int suma = 0;
                    for (int x = 8; x <= numero; x++) suma += x;
                    res = "La suma de la serie desde 8 hasta " + numero + " es: " + suma;
                }
                txtOut.Text = res;
            }
            catch (Exception ex)
            {
                txtOut.Text = "Error: revisa los datos ingresados. (" + ex.Message + ")";
            }
        }
    }
}
