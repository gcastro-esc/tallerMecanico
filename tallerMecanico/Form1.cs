namespace tallerMecanico
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmClientes objeto = new frmClientes();
            objeto.Show();
        }
    }
}
