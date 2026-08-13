using System;
using System.Windows.Forms;
using System.Drawing;
using System.Numerics;

namespace ProyectoFormularios
{
    public class FormEj15 : Form
    {
        private Button btn = new Button();
        private TextBox txtOut = new TextBox();

        public FormEj15()
        {
            this.Text = "Ejercicio 15 - Suma y producto pares 20-400";
            this.Size = new Size(540, 360);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label titulo = new Label();
            titulo.Text = "Suma y producto de los numeros pares entre 20 y 400 inclusive.";
            titulo.SetBounds(20, 15, 490, 45);
            titulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.Controls.Add(titulo);
            int y = 70;

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
                long suma = 0;
                System.Numerics.BigInteger producto = 1;
                for (int x = 20; x <= 400; x += 2) { suma += x; producto *= x; }
                string res = "Numeros pares del 20 al 400\r\nLa suma es: " + suma + "\r\nEl producto es: " + producto;
                txtOut.Text = res;
            }
            catch (Exception ex)
            {
                txtOut.Text = "Error: revisa los datos ingresados. (" + ex.Message + ")";
            }
        }
    }
}
