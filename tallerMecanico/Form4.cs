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
    public partial class frmOrdenes : Form
    {
        public frmOrdenes()
        {
            InitializeComponent();
        }

        private string conexion = "server=localhost;database=taller;uid=root;pwd='';";

        private void mostrarOrdenes()
        {
            try
            {
                using (MySqlConnection conector = new MySqlConnection(conexion))
                {
                    conector.Open();
                    string query = "SELECT idOrden, fechaEntrada, problemaReportado, estado, v.placas FROM ordenes JOIN vehiculos v ON fkVehiculo = v.idVehiculo;";
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, conector);
                    DataTable ordenes = new DataTable();
                    adaptador.Fill(ordenes);
                    gridOrdenes.DataSource = ordenes;
                    //Ajusta el ancho de las columnas al contenido
                    gridOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    //Centra el contenido de todas las columnas
                    int anchoTotal = 0;
                    foreach (DataGridViewColumn columna in gridOrdenes.Columns)
                    {
                        columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        columna.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        anchoTotal += columna.Width;
                    }
                    gridOrdenes.Width = anchoTotal + gridOrdenes.RowHeadersWidth + 2;
                    gridOrdenes.DefaultCellStyle.ForeColor = Color.Chocolate;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se ha podido cargar el listado de ordenes: " + e.Message);
            }
        }

        private void comboVehiculos()
        {
            try
            {
                using (MySqlConnection conector = new MySqlConnection(conexion))
                {
                    conector.Open();
                    string query = "SELECT idVehiculo, placas FROM vehiculos";
                    MySqlDataAdapter comando = new MySqlDataAdapter(query, conector);
                    DataTable vehiculos = new DataTable();
                    comando.Fill(vehiculos);
                    comboVehiculo.DataSource = vehiculos;
                    comboVehiculo.DisplayMember = "placas";
                    comboVehiculo.ValueMember = "idVehiculo";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al cargar los datos de los vehiculos: " + e.Message);
            }
        }

        private void frmOrdenes_Load(object sender, EventArgs e)
        {
            mostrarOrdenes();
            gridOrdenes.Left = (this.ClientSize.Width - gridOrdenes.Width) / 2;
            comboVehiculos();
        }

        private void nuevaOrden()
        {
            try
            {
                using (MySqlConnection conector = new MySqlConnection(conexion))
                {
                    conector.Open();
                    string query = "INSERT INTO ordenes (fkVehiculo, fechaEntrada, problemaReportado, estado) VALUES (@fk, @fe, @pr, @e); ";
                    using (MySqlCommand comando = new MySqlCommand(query, conector))
                    {
                        comando.Parameters.AddWithValue("@fk", comboVehiculo.SelectedValue);
                        comando.Parameters.AddWithValue("@fe", dateFecha.Value);
                        comando.Parameters.AddWithValue("@pr", txtPlacas.Text);
                        comando.Parameters.AddWithValue("@e", comboEstado.SelectedItem);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Orden agregada!");
                        mostrarOrdenes();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al generar la orden: " + e.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nuevaOrden();
        }

        //ELIMINAR VEHICULO (debe verificarse que no tenga ordenes asignadas)
        private bool ordenDiagnostico(int idVehiculo)
        {
            using (MySqlConnection conector = new MySqlConnection(conexion))
            {
                conector.Open();
                string query = "SELECT COUNT(*) FROM diagnosticos WHERE fkOrden = @id;";
                using (MySqlCommand comando = new MySqlCommand(query, conector))
                {
                    comando.Parameters.AddWithValue("@id", idVehiculo);
                    int cantidad = Convert.ToInt32(comando.ExecuteScalar());
                    return cantidad > 0;
                }
            }
        }

        //ELIMINAR ORDEN (debe verificarse que no tenga DIAGNOSTICOS asignados)
        private void eliminarOrden()
        {
            try
            {
                if (gridOrdenes.SelectedRows.Count > 0)
                {
                    //Obtiene el id a eliminar:
                    int id = Convert.ToInt32(gridOrdenes.SelectedRows[0].Cells["idOrden"].Value);
                    DialogResult c = MessageBox.Show("¿Estas seguro?", "Eliminar orden", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (c == DialogResult.Yes)
                    {
                        //Validar si el cliente no contiene vehiculos a su nombre
                        if (ordenDiagnostico(id))
                        {
                            MessageBox.Show("No se puede eliminar esta orden porque tiene diagnosticos asignados.", "Operacion Inválida");
                            return;
                        }
                        else
                        {
                            using (MySqlConnection conector = new MySqlConnection(conexion))
                            {
                                conector.Open();
                                string query = "DELETE FROM ordenes WHERE idOrden = @id";
                                using (MySqlCommand comando = new MySqlCommand(query, conector))
                                {
                                    comando.Parameters.AddWithValue("@id", id);
                                    comando.ExecuteNonQuery();
                                }
                                MessageBox.Show("Vehiculo eliminado");
                                mostrarOrdenes();
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Selecciona la orden para eliminar", "Atención");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se ha podido eliminar: " + e.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarOrden();
        }
    }
}
