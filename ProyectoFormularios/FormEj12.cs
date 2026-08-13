using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoFormularios
{
    public class FormEj12 : Form
    {
        private TextBox tm = new TextBox();
        private Button btn = new Button();
        private TextBox txtOut = new TextBox();

        public FormEj12()
        {
            this.Text = "Ejercicio 12 - Contar pares/impares/pos/neg";
            this.Size = new Size(540, 530);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label titulo = new Label();
            titulo.Text = "Cuenta pares, impares, positivos y negativos de una lista.";
            titulo.SetBounds(20, 15, 490, 45);
            titulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.Controls.Add(titulo);
            int y = 70;

            Label lm = new Label();
            lm.Text = "Escribe un numero por linea";
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
                int pares = 0, impares = 0, positivos = 0, negativos = 0;
                foreach (string linea in tm.Lines) {
                    string l = linea.Trim(); if (l == "") continue;
                    int numero = int.Parse(l);
                    if (numero % 2 == 0) pares++; else impares++;
                    if (numero > 0) positivos++; else negativos++;
                }
                string res = "Pares: " + pares + "\r\nImpares: " + impares +
                    "\r\nPositivos: " + positivos + "\r\nNegativos: " + negativos;
                txtOut.Text = res;
            }
            catch (Exception ex)
            {
                txtOut.Text = "Error: revisa los datos ingresados. (" + ex.Message + ")";
            }
        }
    }
}
