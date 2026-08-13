using System;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoFormularios
{
    public class FormEj32 : Form
    {
        private TextBox t0 = new TextBox();
        private TextBox t1 = new TextBox();
        private TextBox t2 = new TextBox();
        private TextBox t3 = new TextBox();
        private TextBox t4 = new TextBox();
        private Button btn = new Button();
        private TextBox txtOut = new TextBox();

        public FormEj32()
        {
            this.Text = "Ejercicio 32 - Claves de la fiesta";
            this.Size = new Size(540, 530);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label titulo = new Label();
            titulo.Text = "Pide 5 claves; si todas son correctas da la bienvenida.";
            titulo.SetBounds(20, 15, 490, 45);
            titulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.Controls.Add(titulo);
            int y = 70;

            Label l0 = new Label();
            l0.Text = "Clave 1:";
            l0.SetBounds(20, y, 180, 22);
            this.Controls.Add(l0);
            t0.SetBounds(210, y, 300, 24);
            this.Controls.Add(t0);
            y += 34;

            Label l1 = new Label();
            l1.Text = "Clave 2:";
            l1.SetBounds(20, y, 180, 22);
            this.Controls.Add(l1);
            t1.SetBounds(210, y, 300, 24);
            this.Controls.Add(t1);
            y += 34;

            Label l2 = new Label();
            l2.Text = "Clave 3:";
            l2.SetBounds(20, y, 180, 22);
            this.Controls.Add(l2);
            t2.SetBounds(210, y, 300, 24);
            this.Controls.Add(t2);
            y += 34;

            Label l3 = new Label();
            l3.Text = "Clave 4:";
            l3.SetBounds(20, y, 180, 22);
            this.Controls.Add(l3);
            t3.SetBounds(210, y, 300, 24);
            this.Controls.Add(t3);
            y += 34;

            Label l4 = new Label();
            l4.Text = "Clave 5:";
            l4.SetBounds(20, y, 180, 22);
            this.Controls.Add(l4);
            t4.SetBounds(210, y, 300, 24);
            this.Controls.Add(t4);
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
                string c1 = t0.Text.Trim().ToLower();
                string c2 = t1.Text.Trim().ToLower();
                string c3 = t2.Text.Trim().ToLower();
                string c4 = t3.Text.Trim().ToLower();
                string c5 = t4.Text.Trim().ToLower();
                string res;
                if (c1 == "tienes" && c2 == "que ser" && c3 == "invitado" && c4 == "para" && c5 == "ingresar")
                    res = "BIENVENIDO A LA FIESTA";
                else res = "TE EQUIVOCASTE DE FIESTA";
                txtOut.Text = res;
            }
            catch (Exception ex)
            {
                txtOut.Text = "Error: revisa los datos ingresados. (" + ex.Message + ")";
            }
        }
    }
}
