namespace PROYECTO_FINAL
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void bregistrar_Click(object sender, EventArgs e)
        {
            FormRegistrar frm = new FormRegistrar();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void bver_Click(object sender, EventArgs e)
        {
            FormVer frm = new FormVer();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        // BUSCAR PRÉSTAMO
        private void button3_Click(object sender, EventArgs e)
        {
            FormBuscar frm = new FormBuscar();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        // EDITAR PRÉSTAMO
        private void button4_Click(object sender, EventArgs e)
        {
            FormEditar frm = new FormEditar();

            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
