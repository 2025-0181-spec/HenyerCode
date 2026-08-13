using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoFormularios
{
    public class FormEj09 : Form
    {
        private TextBox tm = new TextBox();
        private Button btn = new Button();
        private TextBox txtOut = new TextBox();

        public FormEj09()
        {
            this.Text = "Ejercicio 9 - Analisis de N notas";
            this.Size = new Size(540, 530);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label titulo = new Label();
            titulo.Text = "Aprobadas, desaprobadas y promedios (nota > 10.5 = aprobada).";
            titulo.SetBounds(20, 15, 490, 45);
            titulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.Controls.Add(titulo);
            int y = 70;

            Label lm = new Label();
            lm.Text = "Escribe una nota por linea (0 a 20)";
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
                int ca = 0, cd = 0;
                double accApro = 0, accDes = 0, acc = 0;
                foreach (string linea in tm.Lines) {
                    string l = linea.Trim(); if (l == "") continue;
                    double nota = double.Parse(l);
                    if (nota <= 10.5) { cd++; accDes += nota; } else { ca++; accApro += nota; }
                    acc += nota;
                }
                int total = ca + cd;
                double promApro = ca > 0 ? Math.Round(accApro / ca, 1) : 0;
                double promDes = cd > 0 ? Math.Round(accDes / cd, 1) : 0;
                double prom = total > 0 ? Math.Round(acc / total, 1) : 0;
                string res = "Notas aprobadas: " + ca + "\r\nNotas desaprobadas: " + cd +
                    "\r\nPromedio aprobadas: " + promApro + "\r\nPromedio desaprobadas: " + promDes +
                    "\r\nPromedio final: " + prom;
                txtOut.Text = res;
            }
            catch (Exception ex)
            {
                txtOut.Text = "Error: revisa los datos ingresados. (" + ex.Message + ")";
            }
        }
    }
}
