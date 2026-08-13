namespace PROYECTO_FINAL
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            imageList1 = new ImageList(components);
            bregistrar = new Button();
            bver = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans MT", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(28, 85, 146);
            label1.Location = new Point(133, 9);
            label1.Name = "label1";
            label1.Size = new Size(921, 87);
            label1.TabIndex = 0;
            label1.Text = "CONTROL DE PRÉSTAMOS";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1357, 105);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // bregistrar
            // 
            bregistrar.AutoSize = true;
            bregistrar.BackColor = Color.FromArgb(28, 85, 146);
            bregistrar.FlatAppearance.BorderColor = Color.FromArgb(28, 85, 146);
            bregistrar.FlatAppearance.BorderSize = 0;
            bregistrar.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bregistrar.ForeColor = Color.AliceBlue;
            bregistrar.Location = new Point(44, 160);
            bregistrar.Name = "bregistrar";
            bregistrar.Size = new Size(484, 83);
            bregistrar.TabIndex = 2;
            bregistrar.Text = "REGISTRAR UN PRÉSTAMO";
            bregistrar.UseVisualStyleBackColor = false;
            bregistrar.Click += bregistrar_Click;
            // 
            // bver
            // 
            bver.AutoSize = true;
            bver.BackColor = Color.FromArgb(28, 85, 146);
            bver.FlatAppearance.BorderColor = Color.FromArgb(28, 85, 146);
            bver.FlatAppearance.BorderSize = 0;
            bver.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bver.ForeColor = Color.AliceBlue;
            bver.Location = new Point(44, 300);
            bver.Name = "bver";
            bver.Size = new Size(484, 83);
            bver.TabIndex = 3;
            bver.Text = "VER PRÉSTAMOS";
            bver.UseVisualStyleBackColor = false;
            bver.Click += bver_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.FromArgb(28, 85, 146);
            button3.FlatAppearance.BorderColor = Color.FromArgb(28, 85, 146);
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.AliceBlue;
            button3.Location = new Point(44, 445);
            button3.Name = "button3";
            button3.Size = new Size(484, 83);
            button3.TabIndex = 4;
            button3.Text = "BUSCAR PRÉSTAMO";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.FromArgb(28, 85, 146);
            button4.FlatAppearance.BorderColor = Color.FromArgb(28, 85, 146);
            button4.FlatAppearance.BorderSize = 0;
            button4.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.AliceBlue;
            button4.Location = new Point(44, 583);
            button4.Name = "button4";
            button4.Size = new Size(484, 83);
            button4.TabIndex = 5;
            button4.Text = "EDITAR PRÉSTAMO";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(679, 501);
            label2.Name = "label2";
            label2.Size = new Size(416, 146);
            label2.TabIndex = 6;
            label2.Text = "¡Tu Dinero,\r\nBajo Control!\r\n";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(692, 169);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(403, 340);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 85, 146);
            ClientSize = new Size(1243, 775);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(bver);
            Controls.Add(bregistrar);
            Controls.Add(panel1);
            ForeColor = Color.AliceBlue;
            Name = "FormMenu";
            Text = "RFGGERG";
            Load += FormMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Button bregistrar;
        private Button bver;
        private Button button3;
        private Button button4;
        private Label label2;
        private PictureBox pictureBox2;
    }
}
