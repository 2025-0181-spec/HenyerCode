using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoFormularios
{
    public class FormEj24 : Form
    {
        private TextBox t0 = new TextBox();
        private TextBox t1 = new TextBox();
        private TextBox t2 = new TextBox();
        private Button btn = new Button();
        private TextBox txtOut = new TextBox();

        public FormEj24()
        {
            this.Text = "Ejercicio 24 - Area de triangulo";
            this.Size = new Size(540, 462);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label titulo = new Label();
            titulo.Text = "Area de un triangulo por la formula de Heron (3 lados).";
            titulo.SetBounds(20, 15, 490, 45);
            titulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.Controls.Add(titulo);
            int y = 70;

            Label l0 = new Label();
            l0.Text = "Lado A:";
            l0.SetBounds(20, y, 180, 22);
            this.Controls.Add(l0);
            t0.SetBounds(210, y, 300, 24);
            this.Controls.Add(t0);
            y += 34;

            Label l1 = new Label();
            l1.Text = "Lado B:";
            l1.SetBounds(20, y, 180, 22);
            this.Controls.Add(l1);
            t1.SetBounds(210, y, 300, 24);
            this.Controls.Add(t1);
            y += 34;

            Label l2 = new Label();
            l2.Text = "Lado C:";
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
                double sm = (a + b + c) / 2;
                double area = Math.Round(Math.Sqrt(sm * (sm - a) * (sm - b) * (sm - c)), 2);
                string res = "El area del triangulo es: " + area;
                txtOut.Text = res;
            }
            catch (Exception ex)
            {
                txtOut.Text = "Error: revisa los datos ingresados. (" + ex.Message + ")";
            }
        }
    }
}
