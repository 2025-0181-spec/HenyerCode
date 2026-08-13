using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoFormularios
{
    public class FormEj21 : Form
    {
        private TextBox t0 = new TextBox();
        private TextBox t1 = new TextBox();
        private Button btn = new Button();
        private TextBox txtOut = new TextBox();

        public FormEj21()
        {
            this.Text = "Ejercicio 21 - Operaciones con 2 numeros";
            this.Size = new Size(540, 428);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label titulo = new Label();
            titulo.Text = "Suma, resta, multiplicacion y division de dos numeros.";
            titulo.SetBounds(20, 15, 490, 45);
            titulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.Controls.Add(titulo);
            int y = 70;

            Label l0 = new Label();
            l0.Text = "Primer numero:";
            l0.SetBounds(20, y, 180, 22);
            this.Controls.Add(l0);
            t0.SetBounds(210, y, 300, 24);
            this.Controls.Add(t0);
            y += 34;

            Label l1 = new Label();
            l1.Text = "Segundo numero:";
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
                double a = double.Parse(t0.Text);
                double b = double.Parse(t1.Text);
                string div = (b != 0) ? Math.Round(a / b, 2).ToString() : "indefinida (division entre 0)";
                string res = "Suma: " + (a + b) + "\r\nResta: " + (a - b) +
                    "\r\nMultiplicacion: " + (a * b) + "\r\nDivision: " + div;
                txtOut.Text = res;
            }
            catch (Exception ex)
            {
                txtOut.Text = "Error: revisa los datos ingresados. (" + ex.Message + ")";
            }
        }
    }
}
