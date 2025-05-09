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
                    string query = "SELECT idCliente, nombre FROM clientes";
                    MySqlDataAdapter comando = new MySqlDataAdapter(query, conector);
                    DataTable clientes = new DataTable();
                    comando.Fill(clientes);
                    comboCliente.DataSource = clientes;
                    comboCliente.DisplayMember = "nombre";
                    comboCliente.ValueMember = "idCliente";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al cargar los datos del cliente: " + e.Message);
            }
        }

        private void nuevoVehiculo()
        {
            try
            {
                using (MySqlConnection conector = new MySqlConnection(conexion))
                {
                    conector.Open();
                    string query = "INSERT INTO vehiculos (fkCliente, marca, modelo, placas, year) VALUES (@fk, @ma, @mo, @pl, @ye); ";
                    using (MySqlCommand comando = new MySqlCommand(query, conector))
                    {
                        comando.Parameters.AddWithValue("@fk", comboCliente.SelectedValue);
                        comando.Parameters.AddWithValue("@ma", txtMarca.Text);
                        comando.Parameters.AddWithValue("@mo", txtModelo.Text);
                        comando.Parameters.AddWithValue("@pl", txtPlacas.Text);
                        comando.Parameters.AddWithValue("@ye", txtYear.Text);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Vehiculo agregado!");
                        mostrarVehiculos();
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Error al guardar el vehiculo: " + e.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nuevoVehiculo();
        }
    }
}
