namespace PROYECTO_FINAL
{
    partial class FormVer
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
            bactu = new Button();
            bvolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(166, 31);
            label1.Name = "label1";
            label1.Size = new Size(446, 42);
            label1.TabIndex = 2;
            label1.Text = "LISTA DE PRÉSTAMOS\r\n";
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
            dgvPrestamos.Location = new Point(78, 120);
            dgvPrestamos.MultiSelect = false;
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.RowHeadersVisible = false;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(656, 315);
            dgvPrestamos.TabIndex = 3;
            dgvPrestamos.CellContentClick += dgvPrestamos_CellContentClick;
            // 
            // bactu
            // 
            bactu.BackColor = Color.FromArgb(28, 85, 146);
            bactu.FlatAppearance.BorderColor = Color.FromArgb(28, 85, 146);
            bactu.FlatAppearance.BorderSize = 0;
            bactu.FlatStyle = FlatStyle.Flat;
            bactu.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bactu.ForeColor = Color.AliceBlue;
            bactu.Location = new Point(166, 455);
            bactu.Name = "bactu";
            bactu.Size = new Size(484, 83);
            bactu.TabIndex = 11;
            bactu.Text = "ACTUALIZAR";
            bactu.UseVisualStyleBackColor = false;
            bactu.Click += bactu_Click;
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
            bvolver.TabIndex = 13;
            bvolver.Text = "Volver";
            bvolver.UseVisualStyleBackColor = false;
            bvolver.Click += bvolver_Click;
            // 
            // FormVer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 85, 146);
            ClientSize = new Size(801, 580);
            Controls.Add(bvolver);
            Controls.Add(bactu);
            Controls.Add(dgvPrestamos);
            Controls.Add(label1);
            Name = "FormVer";
            Text = "FormVer";
            Load += FormVer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvPrestamos;
        private Button bactu;
        private Button bvolver;
    }
}