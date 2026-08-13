using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoFormularios
{
    public class FormEj29 : Form
    {
        private TextBox tm = new TextBox();
        private Button btn = new Button();
        private TextBox txtOut = new TextBox();

        public FormEj29()
        {
            this.Text = "Ejercicio 29 - Egresos en caja";
            this.Size = new Size(540, 530);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label titulo = new Label();
            titulo.Text = "Caja inicial de 3.71; suma egresos hasta -1 y muestra el sobrante.";
            titulo.SetBounds(20, 15, 490, 45);
            titulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.Controls.Add(titulo);
            int y = 70;

            Label lm = new Label();
            lm.Text = "Escribe un egreso por linea (usa -1 para terminar)";
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
                double caja = 3.71;
                double totalEgresos = 0;
                foreach (string linea in tm.Lines) {
                    string l = linea.Trim(); if (l == "") continue;
                    double egreso = double.Parse(l);
                    if (egreso == -1) break;
                    totalEgresos += egreso;
                }
                double sobrante = caja - totalEgresos;
                string res = "El total de egresos es: " + totalEgresos + "\r\nLo sobrante en caja es: " + sobrante;
                txtOut.Text = res;
            }
            catch (Exception ex)
            {
                txtOut.Text = "Error: revisa los datos ingresados. (" + ex.Message + ")";
            }
        }
    }
}
