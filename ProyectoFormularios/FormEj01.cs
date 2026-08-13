using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoFormularios
{
    public class FormEj01 : Form
    {
        private TextBox t0 = new TextBox();
        private TextBox t1 = new TextBox();
        private Button btn = new Button();
        private TextBox txtOut = new TextBox();

        public FormEj01()
        {
            this.Text = "Ejercicio 1 - Salario con horas extra";
            this.Size = new Size(540, 428);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label titulo = new Label();
            titulo.Text = "Pago por horas con recargo del 50% sobre las 40 horas.";
            titulo.SetBounds(20, 15, 490, 45);
            titulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.Controls.Add(titulo);
            int y = 70;

            Label l0 = new Label();
            l0.Text = "Horas trabajadas:";
            l0.SetBounds(20, y, 180, 22);
            this.Controls.Add(l0);
            t0.SetBounds(210, y, 300, 24);
            this.Controls.Add(t0);
            y += 34;

            Label l1 = new Label();
            l1.Text = "Tarifa por hora:";
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
                double horas = double.Parse(t0.Text);
                double tarifa = double.Parse(t1.Text);
                string res;
                if (horas < 0) res = "Las horas no pueden ser negativas.";
                else if (horas <= 40) res = "El salario es: " + (horas * tarifa);
                else {
                    double extra = horas - 40;
                    double tarifaExtra = tarifa + 0.5 * tarifa;
                    double salario = extra * tarifaExtra + 40 * tarifa;
                    res = "El salario es: " + salario;
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
