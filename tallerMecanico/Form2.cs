using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tallerMecanico
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private string conexion = "server=localhost;database=taller;uid=root;pwd='';";

        private void mostrarClientes()
        {
            try
            {
                using (MySqlConnection conector = new MySqlConnection(conexion))
                {
                    conector.Open();
                    string query = "SELECT * FROM clientes;";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conector);
                    DataTable clientes = new DataTable();
                    adaptador.Fill(clientes);
                    gridClientes.DataSource = clientes;
                    //Ajusta el ancho de las columnas al contenido
                    gridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    //Centra el contenido de todas las columnas
                    int anchoTotal = 0;
                    foreach (DataGridViewColumn columna in gridClientes.Columns)
                    {
                        columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        anchoTotal += columna.Width;
                    }
                    gridClientes.Width = anchoTotal + gridClientes.RowHeadersWidth + 2;
                    gridClientes.DefaultCellStyle.ForeColor = Color.Chocolate;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se ha podido cargar el listado de clientes: " + e.Message);
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            mostrarClientes();
        }

        //AGREGAR CLIENTE
        private void agregarCliente()
        {
            try
            {
                using (MySqlConnection conector = new MySqlConnection(conexion))
                {
                    conector.Open();
                    string query = "INSERT INTO clientes (nombre, telefono, correo, direccion) VALUES (@n, @t, @c, @d); ";
                    using (MySqlCommand comando = new MySqlCommand(query, conector))
                    {
                        comando.Parameters.AddWithValue("@n", txtNombre.Text);
                        comando.Parameters.AddWithValue("@t", txtTelefono.Text);
                        comando.Parameters.AddWithValue("@c", txtCorreo.Text);
                        comando.Parameters.AddWithValue("@d", txtDireccion.Text);
                        int paciente = comando.ExecuteNonQuery();
                        if (paciente > 0)
                        {
                            MessageBox.Show("Cliente: " + txtNombre.Text + " agregado! ");
                            mostrarClientes();
                            txtNombre.Clear();
                            txtTelefono.Clear();
                            txtCorreo.Clear();
                            txtDireccion.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No fue posible agregar los datos del cliente");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No fue posible agregar al nuevo cliente: " + e.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarCliente();
        }


        //ELIMINAR CLIENTE

        private bool clienteVehiculo(int idCliente)
        {
            using (MySqlConnection conector = new MySqlConnection(conexion))
            {
                conector.Open();
                string query = "SELECT COUNT(*) FROM vehiculos WHERE fkCliente = @id;";
                using (MySqlCommand comando = new MySqlCommand(query, conector))
                {
                    comando.Parameters.AddWithValue("@id", idCliente);
                    int cantidad = Convert.ToInt32(comando.ExecuteScalar());
                    return cantidad > 0;
                }
            }
        }



        private void eliminarCliente()
        {
            try
            {
                if (gridClientes.SelectedRows.Count > 0)
                {
                    //Obtiene el id a eliminar:
                    int id = Convert.ToInt32(gridClientes.SelectedRows[0].Cells["idCliente"].Value);
                    DialogResult c = MessageBox.Show("¿Estas seguro?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (c == DialogResult.Yes)
                    {
                        //Validar si el cliente no contiene vehiculos a su nombre
                        if(clienteVehiculo(id))
                        {
                            MessageBox.Show("No se puede eliminar este cliente porque tiene vehículos registrados.", "Operacion Inválida");
                            return;
                        }
                        else
                        { 
                            using (MySqlConnection conector = new MySqlConnection(conexion))
                            {
                                conector.Open();
                                string query = "DELETE FROM clientes WHERE idCliente = @id";
                                using (MySqlCommand comando = new MySqlCommand(query, conector))
                                {
                                    comando.Parameters.AddWithValue("@id", id);
                                    comando.ExecuteNonQuery();
                                }
                                MessageBox.Show("Cliente eliminado");
                                mostrarClientes();
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Selecciona el cliente a eliminar","Atención");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se ha podido eliminar: " + e.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarCliente();
        }

        //ACTUALIZAR CLIENTE
        private int clienteSeleccionado = -1;
        private void gridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = gridClientes.Rows[e.RowIndex];
                clienteSeleccionado = Convert.ToInt32(fila.Cells["idCliente"].Value);
                txtNombre.Text = fila.Cells["nombre"].Value.ToString();
                txtTelefono.Text = fila.Cells["telefono"].Value.ToString();
                txtCorreo.Text = fila.Cells["correo"].Value.ToString();
                txtDireccion.Text = fila.Cells["direccion"].Value.ToString();
            }
        }

        private void actualizarCliente()
        {
            try
            {
                if (clienteSeleccionado != -1)
                {
                    //Obtiene el id a eliminar:
                    int id = Convert.ToInt32(gridClientes.SelectedRows[0].Cells["idCliente"].Value);
                    using (MySqlConnection conector = new MySqlConnection(conexion))
                    {
                        conector.Open();
                        string query = "UPDATE clientes SET nombre = @n, telefono = @t, correo = @c, direccion = @d WHERE idCliente = @id; ";
                        using (MySqlCommand comando = new MySqlCommand(query,conector))
                        {
                            comando.Parameters.AddWithValue("@n", txtNombre.Text);
                            comando.Parameters.AddWithValue("@t", txtTelefono.Text);
                            comando.Parameters.AddWithValue("@c", txtCorreo.Text);
                            comando.Parameters.AddWithValue("@d", txtDireccion.Text);
                            comando.Parameters.AddWithValue("@id", clienteSeleccionado);
                            int actualizacion = comando.ExecuteNonQuery();
                            if (actualizacion > 0)
                            {
                                MessageBox.Show("Datos del cliente actualizados! ");
                                mostrarClientes();
                                txtNombre.Clear();
                                txtTelefono.Clear();
                                txtCorreo.Clear();
                                txtDireccion.Clear();
                                clienteSeleccionado = -1;
                            }
                            else
                            {
                                MessageBox.Show("No fue posible actualizar los datos... ");
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al actualizar cliente: " + e.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            actualizarCliente();
        }
    }
}
