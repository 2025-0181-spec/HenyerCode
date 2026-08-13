using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoFormularios
{
    public class FormEj19 : Form
    {
        private TextBox t0 = new TextBox();
        private Button btn = new Button();
        private TextBox txtOut = new TextBox();

        public FormEj19()
        {
            this.Text = "Ejercicio 19 - Parte fraccionaria";
            this.Size = new Size(540, 394);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label titulo = new Label();
            titulo.Text = "Determina si un numero tiene parte fraccionaria.";
            titulo.SetBounds(20, 15, 490, 45);
            titulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.Controls.Add(titulo);
            int y = 70;

            Label l0 = new Label();
            l0.Text = "Numero:";
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
                double numero = double.Parse(t0.Text);
                double pf = Math.Truncate(numero);
                string res = (numero == pf) ? "El numero NO tiene parte fraccionaria." : "El numero SI tiene parte fraccionaria.";
                txtOut.Text = res;
            }
            catch (Exception ex)
            {
                txtOut.Text = "Error: revisa los datos ingresados. (" + ex.Message + ")";
            }
        }
    }
}
