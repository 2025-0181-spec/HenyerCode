namespace PROYECTO_FINAL
{
    partial class FormEditar
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            dgvPrestamos = new DataGridView();
            label6 = new Label();
            label2 = new Label();
            txtnombre = new TextBox();
            label5 = new Label();
            txtnum = new TextBox();
            label4 = new Label();
            txtmonto = new TextBox();
            label3 = new Label();
            dtfecha = new DateTimePicker();
            bguardar = new Button();
            bcancelar = new Button();
            bvolver = new Button();
            bestado = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(240, 20);
            label1.Name = "label1";
            label1.Size = new Size(389, 42);
            label1.TabIndex = 0;
            label1.Text = "EDITAR PRÉSTAMO";
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPrestamos.BackgroundColor = Color.FromArgb(28, 85, 146);
            dgvPrestamos.BorderStyle = BorderStyle.None;
            dgvPrestamos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 85, 146);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.AliceBlue;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.AliceBlue;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPrestamos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPrestamos.EnableHeadersVisualStyles = false;
            dgvPrestamos.GridColor = Color.AliceBlue;
            dgvPrestamos.Location = new Point(40, 80);
            dgvPrestamos.MultiSelect = false;
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.RowHeadersVisible = false;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(820, 250);
            dgvPrestamos.TabIndex = 1;
            dgvPrestamos.CellClick += dgvPrestamos_CellClick;
            dgvPrestamos.CellContentClick += dgvPrestamos_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(40, 345);
            label6.Name = "label6";
            label6.Size = new Size(493, 20);
            label6.TabIndex = 2;
            label6.Text = "Seleccione un préstamo en la tabla para modificar sus datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 385);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre del solicitante";
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnombre.Location = new Point(40, 410);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(350, 26);
            txtnombre.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(470, 385);
            label5.Name = "label5";
            label5.Size = new Size(149, 20);
            label5.TabIndex = 5;
            label5.Text = "Número de teléfono";
            // 
            // txtnum
            // 
            txtnum.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnum.Location = new Point(470, 410);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(350, 26);
            txtnum.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(40, 455);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 7;
            label4.Text = "Monto de la solicitud";
            // 
            // txtmonto
            // 
            txtmonto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtmonto.Location = new Point(40, 480);
            txtmonto.Name = "txtmonto";
            txtmonto.Size = new Size(350, 26);
            txtmonto.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(470, 455);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 9;
            label3.Text = "Fecha";
            // 
            // dtfecha
            // 
            dtfecha.CalendarFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtfecha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtfecha.Location = new Point(470, 480);
            dtfecha.Name = "dtfecha";
            dtfecha.Size = new Size(350, 26);
            dtfecha.TabIndex = 10;
            // 
            // bguardar
            // 
            bguardar.BackColor = Color.FromArgb(28, 85, 146);
            bguardar.FlatAppearance.BorderColor = Color.AliceBlue;
            bguardar.FlatStyle = FlatStyle.Flat;
            bguardar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bguardar.ForeColor = Color.AliceBlue;
            bguardar.Location = new Point(40, 545);
            bguardar.Name = "bguardar";
            bguardar.Size = new Size(380, 70);
            bguardar.TabIndex = 11;
            bguardar.Text = "GUARDAR CAMBIOS";
            bguardar.UseVisualStyleBackColor = false;
            bguardar.Click += bguardar_Click;
            // 
            // bcancelar
            // 
            bcancelar.BackColor = Color.FromArgb(28, 85, 146);
            bcancelar.FlatAppearance.BorderColor = Color.AliceBlue;
            bcancelar.FlatStyle = FlatStyle.Flat;
            bcancelar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bcancelar.ForeColor = Color.AliceBlue;
            bcancelar.Location = new Point(470, 545);
            bcancelar.Name = "bcancelar";
            bcancelar.Size = new Size(240, 70);
            bcancelar.TabIndex = 12;
            bcancelar.Text = "CANCELAR";
            bcancelar.UseVisualStyleBackColor = false;
            bcancelar.Click += bcancelar_Click;
            // 
            // bvolver
            // 
            bvolver.BackColor = Color.FromArgb(28, 85, 146);
            bvolver.FlatAppearance.BorderColor = Color.FromArgb(28, 85, 146);
            bvolver.FlatAppearance.BorderSize = 0;
            bvolver.FlatStyle = FlatStyle.Flat;
            bvolver.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bvolver.ForeColor = Color.AliceBlue;
            bvolver.Location = new Point(799, 770);
            bvolver.Name = "bvolver";
            bvolver.Size = new Size(105, 50);
            bvolver.TabIndex = 13;
            bvolver.Text = "Volver";
            bvolver.UseVisualStyleBackColor = false;
            bvolver.Click += bvolver_Click;
            // 
            // bestado
            // 
            bestado.BackColor = Color.FromArgb(28, 85, 146);
            bestado.FlatAppearance.BorderColor = Color.AliceBlue;
            bestado.FlatStyle = FlatStyle.Flat;
            bestado.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bestado.ForeColor = Color.AliceBlue;
            bestado.Location = new Point(40, 652);
            bestado.Name = "bestado";
            bestado.Size = new Size(380, 70);
            bestado.TabIndex = 14;
            bestado.Text = "CAMBIAR ESTADO\r\n";
            bestado.UseVisualStyleBackColor = false;
            bestado.Click += bestado_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(28, 85, 146);
            button1.FlatAppearance.BorderColor = Color.AliceBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.AliceBlue;
            button1.Location = new Point(470, 652);
            button1.Name = "button1";
            button1.Size = new Size(240, 70);
            button1.TabIndex = 15;
            button1.Text = "ELIMINAR PRÉSTAMO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 85, 146);
            ClientSize = new Size(900, 821);
            Controls.Add(button1);
            Controls.Add(bestado);
            Controls.Add(bvolver);
            Controls.Add(bcancelar);
            Controls.Add(bguardar);
            Controls.Add(dtfecha);
            Controls.Add(label3);
            Controls.Add(txtmonto);
            Controls.Add(label4);
            Controls.Add(txtnum);
            Controls.Add(label5);
            Controls.Add(txtnombre);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(dgvPrestamos);
            Controls.Add(label1);
            Name = "FormEditar";
            Text = "FormEditar";
            Load += FormEditar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvPrestamos;
        private Label label6;
        private Label label2;
        private TextBox txtnombre;
        private Label label5;
        private TextBox txtnum;
        private Label label4;
        private TextBox txtmonto;
        private Label label3;
        private DateTimePicker dtfecha;
        private Button bguardar;
        private Button bcancelar;
        private Button bvolver;
        private Button bestado;
        private Button button1;
    }
}
