using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoFormularios
{
    public class FormEj18 : Form
    {
        private TextBox tm = new TextBox();
        private Button btn = new Button();
        private TextBox txtOut = new TextBox();

        public FormEj18()
        {
            this.Text = "Ejercicio 18 - Primera vocal";
            this.Size = new Size(540, 530);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label titulo = new Label();
            titulo.Text = "Muestra la primera vocal ingresada de una lista de caracteres.";
            titulo.SetBounds(20, 15, 490, 45);
            titulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.Controls.Add(titulo);
            int y = 70;

            Label lm = new Label();
            lm.Text = "Escribe un caracter por linea";
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
                string res = "No se ingreso ninguna vocal.";
                foreach (string linea in tm.Lines) {
                    string c = linea.Trim().ToLower();
                    if (c == "a" || c == "e" || c == "i" || c == "o" || c == "u") {
                        res = "La primera vocal ingresada fue: " + c;
                        break;
                    }
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
