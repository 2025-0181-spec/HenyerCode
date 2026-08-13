namespace PROYECTO_FINAL
{
    partial class FormRegistrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtnombre = new TextBox();
            txtnum = new TextBox();
            label3 = new Label();
            txtmonto = new TextBox();
            label4 = new Label();
            label5 = new Label();
            bregistrar = new Button();
            dtfecha = new DateTimePicker();
            bvolver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 34);
            label1.Name = "label1";
            label1.Size = new Size(381, 31);
            label1.TabIndex = 1;
            label1.Text = "REGISTRO DE PRÉSTAMO\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 133);
            label2.Name = "label2";
            label2.Size = new Size(225, 25);
            label2.TabIndex = 2;
            label2.Text = "Nombre del solicitante\r\n";
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnombre.Location = new Point(23, 172);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(284, 26);
            txtnombre.TabIndex = 3;
            // 
            // txtnum
            // 
            txtnum.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnum.Location = new Point(23, 270);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(284, 26);
            txtnum.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 435);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 4;
            label3.Text = "Fecha\r\n";
            // 
            // txtmonto
            // 
            txtmonto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtmonto.Location = new Point(23, 374);
            txtmonto.Name = "txtmonto";
            txtmonto.Size = new Size(284, 26);
            txtmonto.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(23, 335);
            label4.Name = "label4";
            label4.Size = new Size(210, 25);
            label4.TabIndex = 6;
            label4.Text = "Monto de la solicitud";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(23, 227);
            label5.Name = "label5";
            label5.Size = new Size(200, 25);
            label5.TabIndex = 8;
            label5.Text = "Número de teléfono";
            // 
            // bregistrar
            // 
            bregistrar.BackColor = Color.FromArgb(28, 85, 146);
            bregistrar.FlatAppearance.BorderColor = Color.FromArgb(28, 85, 146);
            bregistrar.FlatAppearance.BorderSize = 0;
            bregistrar.FlatStyle = FlatStyle.Flat;
            bregistrar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bregistrar.ForeColor = Color.AliceBlue;
            bregistrar.Location = new Point(-28, 549);
            bregistrar.Name = "bregistrar";
            bregistrar.Size = new Size(484, 83);
            bregistrar.TabIndex = 10;
            bregistrar.Text = "REGISTRAR\r\n";
            bregistrar.UseVisualStyleBackColor = false;
            bregistrar.Click += bregistrar_Click;
            // 
            // dtfecha
            // 
            dtfecha.CalendarFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtfecha.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtfecha.Location = new Point(23, 495);
            dtfecha.Name = "dtfecha";
            dtfecha.Size = new Size(284, 22);
            dtfecha.TabIndex = 11;
            // 
            // bvolver
            // 
            bvolver.BackColor = Color.FromArgb(28, 85, 146);
            bvolver.FlatAppearance.BorderColor = Color.FromArgb(28, 85, 146);
            bvolver.FlatAppearance.BorderSize = 0;
            bvolver.FlatStyle = FlatStyle.Flat;
            bvolver.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bvolver.ForeColor = Color.AliceBlue;
            bvolver.Location = new Point(325, 657);
            bvolver.Name = "bvolver";
            bvolver.Size = new Size(105, 46);
            bvolver.TabIndex = 12;
            bvolver.Text = "Volver";
            bvolver.UseVisualStyleBackColor = false;
            bvolver.Click += bvolver_Click;
            // 
            // FormRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 85, 146);
            ClientSize = new Size(430, 703);
            Controls.Add(bvolver);
            Controls.Add(dtfecha);
            Controls.Add(bregistrar);
            Controls.Add(label5);
            Controls.Add(txtmonto);
            Controls.Add(label4);
            Controls.Add(txtnum);
            Controls.Add(label3);
            Controls.Add(txtnombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRegistrar";
            Text = "FormRegistrar";
            Load += FormRegistrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtnombre;
        private TextBox txtnum;
        private Label label3;
        private TextBox txtmonto;
        private Label label4;
        private Label label5;
        private Button bregistrar;
        private DateTimePicker dtfecha;
        private Button bvolver;
    }
}