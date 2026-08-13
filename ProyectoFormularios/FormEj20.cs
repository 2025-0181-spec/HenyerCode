using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoFormularios
{
    public class FormEj20 : Form
    {
        private TextBox t0 = new TextBox();
        private TextBox t1 = new TextBox();
        private TextBox t2 = new TextBox();
        private Button btn = new Button();
        private TextBox txtOut = new TextBox();

        public FormEj20()
        {
            this.Text = "Ejercicio 20 - Ecuacion cuadratica";
            this.Size = new Size(540, 462);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label titulo = new Label();
            titulo.Text = "Raices de aX^2 + bX + c, incluyendo imaginarias.";
            titulo.SetBounds(20, 15, 490, 45);
            titulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.Controls.Add(titulo);
            int y = 70;

            Label l0 = new Label();
            l0.Text = "Coeficiente a:";
            l0.SetBounds(20, y, 180, 22);
            this.Controls.Add(l0);
            t0.SetBounds(210, y, 300, 24);
            this.Controls.Add(t0);
            y += 34;

            Label l1 = new Label();
            l1.Text = "Coeficiente b:";
            l1.SetBounds(20, y, 180, 22);
            this.Controls.Add(l1);
            t1.SetBounds(210, y, 300, 24);
            this.Controls.Add(t1);
            y += 34;

            Label l2 = new Label();
            l2.Text = "Coeficiente c:";
            l2.SetBounds(20, y, 180, 22);
            this.Controls.Add(l2);
            t2.SetBounds(210, y, 300, 24);
            this.Controls.Add(t2);
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
                double a = double.Parse(t0.Text);
                double b = double.Parse(t1.Text);
                double c = double.Parse(t2.Text);
                string res;
                double disc = Math.Pow(b, 2) - 4 * a * c;
                if (a == 0) res = "No es una ecuacion cuadratica: 'a' debe ser distinto de 0.";
                else if (disc > 0) {
                    double x1 = Math.Round((-b + Math.Sqrt(disc)) / (2 * a), 3);
                    double x2 = Math.Round((-b - Math.Sqrt(disc)) / (2 * a), 3);
                    res = "Discriminante positivo. Dos raices reales:\r\nx1 = " + x1 + "\r\nx2 = " + x2;
                } else if (disc == 0) {
                    double x = Math.Round(-b / (2 * a), 3);
                    res = "Discriminante 0. Una raiz doble:\r\nx = " + x;
                } else {
                    double real = Math.Round(-b / (2 * a), 3);
                    double imag = Math.Round(Math.Sqrt(-disc) / (2 * a), 3);
                    res = "Discriminante negativo. Raices imaginarias:\r\nx1 = " + real + " + " + imag + "i\r\nx2 = " + real + " - " + imag + "i";
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
