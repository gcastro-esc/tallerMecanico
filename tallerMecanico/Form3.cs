using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tallerMecanico
{
    public partial class frmVehiculos : Form
    {
        public frmVehiculos()
        {
            InitializeComponent();
        }

        private string conexion = "server=localhost;database=taller;uid=root;pwd='';";

        private void mostrarVehiculos()
        {
            try
            {
                using (MySqlConnection conector = new MySqlConnection(conexion))
                {
                    conector.Open();
                    string query = "SELECT * FROM vehiculos;";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conector);
                    DataTable vehiculos = new DataTable();
                    adaptador.Fill(vehiculos);
                    gridVehiculos.DataSource = vehiculos;
                    //Ajusta el ancho de las columnas al contenido
                    gridVehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    //Centra el contenido de todas las columnas
                    int anchoTotal = 0;
                    foreach (DataGridViewColumn columna in gridVehiculos.Columns)
                    {
                        columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        anchoTotal += columna.Width;
                    }
                    gridVehiculos.Width = anchoTotal + gridVehiculos.RowHeadersWidth + 2;
                    gridVehiculos.DefaultCellStyle.ForeColor = Color.Chocolate;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se ha podido cargar el listado de vehiculos" +
                    ": " + e.Message);
            }
        }

        private void frmVehiculos_Load(object sender, EventArgs e)
        {
            mostrarVehiculos();
            gridVehiculos.Left = (this.ClientSize.Width - gridVehiculos.Width) / 2;
            comboClientes();
        }

        private void comboClientes()
        {
            try
            {
                using (MySqlConnection conector = new MySqlConnection(conexion))
                {
                    conector.Open();
                    string query = "SELECT * FROM clientes";
                    MySqlCommand comando = new MySqlCommand(query, conector);
                    MySqlDataReader leer = comando.ExecuteReader();
                    comboCliente.Items.Clear();
                    while (leer.Read())
                    {
                        comboCliente.Items.Add(leer["nombre"].ToString());
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

    }
}
