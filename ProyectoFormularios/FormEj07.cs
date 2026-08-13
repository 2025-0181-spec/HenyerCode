using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoFormularios
{
    public class FormEj07 : Form
    {
        private TextBox tm = new TextBox();
        private Button btn = new Button();
        private TextBox txtOut = new TextBox();

        public FormEj07()
        {
            this.Text = "Ejercicio 7 - Suma de salarios";
            this.Size = new Size(540, 530);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label titulo = new Label();
            titulo.Text = "Suma los salarios de varios trabajadores (horas x tarifa).";
            titulo.SetBounds(20, 15, 490, 45);
            titulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.Controls.Add(titulo);
            int y = 70;

            Label lm = new Label();
            lm.Text = "Escribe un trabajador por linea:  horas tarifa";
            lm.SetBounds(20, y, 490, 20);
            this.Controls.Add(lm);
            y += 24;
            tm.Multiline = true;
            tm.ScrollBars = ScrollBars.Vertical;
            tm.SetBounds(20, y, 490, 130);
            this.Controls.Add(tm);
            y += 140;

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
                double suma = 0; int cont = 0;
                foreach (string linea in tm.Lines) {
                    string l = linea.Trim(); if (l == "") continue;
                    string[] p = l.Split(new char[]{' ', ',', ';', '\t'}, StringSplitOptions.RemoveEmptyEntries);
                    double horas = double.Parse(p[0]);
                    double tarifa = double.Parse(p[1]);
                    suma += horas * tarifa; cont++;
                }
                string res = "Trabajadores procesados: " + cont + "\r\nLa suma de los salarios es: " + suma;
                txtOut.Text = res;
            }
            catch (Exception ex)
            {
                txtOut.Text = "Error: revisa los datos ingresados. (" + ex.Message + ")";
            }
        }
    }
}
