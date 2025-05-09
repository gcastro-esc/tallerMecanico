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

        private void button2_Click(object sender, EventArgs e)
        {
            frmVehiculos objeto = new frmVehiculos();
            objeto.Show();
        }
    }
}
