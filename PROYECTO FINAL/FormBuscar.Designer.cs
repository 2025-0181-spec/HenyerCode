namespace PROYECTO_FINAL
{
    partial class FormBuscar
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
            label2 = new Label();
            txtbuscar = new TextBox();
            bbuscar = new Button();
            dgvResultados = new DataGridView();
            lblresultado = new Label();
            bvolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(180, 25);
            label1.Name = "label1";
            label1.Size = new Size(409, 42);
            label1.TabIndex = 0;
            label1.Text = "BUSCAR PRÉSTAMO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(78, 90);
            label2.Name = "label2";
            label2.Size = new Size(220, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre o número de teléfono";
            // 
            // txtbuscar
            // 
            txtbuscar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbuscar.Location = new Point(78, 115);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(430, 26);
            txtbuscar.TabIndex = 2;
            txtbuscar.KeyDown += txtbuscar_KeyDown;
            // 
            // bbuscar
            // 
            bbuscar.BackColor = Color.FromArgb(28, 85, 146);
            bbuscar.FlatAppearance.BorderColor = Color.AliceBlue;
            bbuscar.FlatStyle = FlatStyle.Flat;
            bbuscar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bbuscar.ForeColor = Color.AliceBlue;
            bbuscar.Location = new Point(529, 112);
            bbuscar.Name = "bbuscar";
            bbuscar.Size = new Size(205, 33);
            bbuscar.TabIndex = 3;
            bbuscar.Text = "BUSCAR";
            bbuscar.UseVisualStyleBackColor = false;
            bbuscar.Click += bbuscar_Click;
            // 
            // dgvResultados
            // 
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvResultados.BackgroundColor = Color.FromArgb(28, 85, 146);
            dgvResultados.BorderStyle = BorderStyle.None;
            dgvResultados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(28, 85, 146);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.AliceBlue;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.AliceBlue;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvResultados.DefaultCellStyle = dataGridViewCellStyle2;
            dgvResultados.EnableHeadersVisualStyles = false;
            dgvResultados.GridColor = Color.AliceBlue;
            dgvResultados.Location = new Point(78, 175);
            dgvResultados.MultiSelect = false;
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.RowHeadersVisible = false;
            dgvResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResultados.Size = new Size(656, 300);
            dgvResultados.TabIndex = 4;
            dgvResultados.CellContentClick += dgvResultados_CellContentClick;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblresultado.ForeColor = Color.White;
            lblresultado.Location = new Point(78, 495);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(0, 20);
            lblresultado.TabIndex = 5;
            // 
            // bvolver
            // 
            bvolver.BackColor = Color.FromArgb(28, 85, 146);
            bvolver.FlatAppearance.BorderColor = Color.FromArgb(28, 85, 146);
            bvolver.FlatAppearance.BorderSize = 0;
            bvolver.FlatStyle = FlatStyle.Flat;
            bvolver.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bvolver.ForeColor = Color.AliceBlue;
            bvolver.Location = new Point(697, 525);
            bvolver.Name = "bvolver";
            bvolver.Size = new Size(105, 55);
            bvolver.TabIndex = 6;
            bvolver.Text = "Volver";
            bvolver.UseVisualStyleBackColor = false;
            bvolver.Click += bvolver_Click;
            // 
            // FormBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 85, 146);
            ClientSize = new Size(801, 580);
            Controls.Add(bvolver);
            Controls.Add(lblresultado);
            Controls.Add(dgvResultados);
            Controls.Add(bbuscar);
            Controls.Add(txtbuscar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormBuscar";
            Text = "FormBuscar";
            Load += FormBuscar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtbuscar;
        private Button bbuscar;
        private DataGridView dgvResultados;
        private Label lblresultado;
        private Button bvolver;
    }
}
