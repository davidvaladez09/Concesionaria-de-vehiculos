using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace menu.Formuarios
{
    public partial class Eliminar_Empleado : Form
    {
        public Eliminar_Empleado()
        {
            InitializeComponent();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            string idVendedor = txtIdVendedor.Text;

            string sql = "DELETE FROM empleado_vendedor_usuario WHERE idEmpleado_Vendedor_Usuario='" + idVendedor + "'";

            MySqlConnection conexionBD = Clases.Conexion.conexion();
            conexionBD.Open();

            if (txtIdVendedor.Text == "" || txtUsuarioVendedor.Text == "" || txtNombreVendedor.Text == "" || txtTipoUsuario.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("NO PUEDES DEJAR CAMPOS VACIOS");
            }
            else
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("EMPLEADO ELIMINADO");
                    limpiar();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("ERROR EMPLEADO NO ELIMINADO");
                }
                finally
                {
                    conexionBD.Close();
                }
            }
        }
        private void limpiar()
        {
            txtIdVendedor.Text = "";
            txtUsuarioVendedor.Text = "";
            txtNombreVendedor.Text = "";
            txtTipoUsuario.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCompletarVendedor_Click(object sender, EventArgs e)
        {
            String idVendedor = txtIdVendedor.Text;

            MySqlDataReader reader = null;

            String sql = "SELECT * FROM empleado_vendedor_usuario WHERE idEmpleado_Vendedor_Usuario LIKE '" + idVendedor + "' LIMIT 1";

            MySqlConnection conexionBD = Clases.Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtUsuarioVendedor.Text = reader.GetString(1);
                        txtTipoUsuario.Text = reader.GetString(3);
                        txtNombreVendedor.Text = reader.GetString(4);
                        txtTelefono.Text = reader.GetString(8);
                        txtCorreo.Text = reader.GetString(9);
                    }
                }
                else
                {
                    MessageBox.Show("NO SE ENCONTRARON LOS DATOS DEL VENDEDOR");
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("ERROR AL AGREGAR DATOS");
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
