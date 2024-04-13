using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace menu.Formuarios
{
    public partial class Cancelar_Venta : Form
    {
        public Cancelar_Venta()
        {
            InitializeComponent();
        }

        MySqlConnection conexionBD = new MySqlConnection("server=localhost; database=concesionaria; Uid=root; pwd=Astro090");
        private void btnEliminarVenta_Click(object sender, EventArgs e)
        {
            string idCliente = txtIdCliente.Text;
            string idVendedor = txtIdVendedor.Text;
            string noSerieMotor = txtNoSerieMotor.Text;
            string idVenta = txtIdVenta.Text;

            string sql = "DELETE FROM ventas WHERE idCliente='" + idCliente + "' AND idEmpleado_Vendedor_Usuario='" + idVendedor + "' AND Numero_Serie_Motor='" + noSerieMotor + "' AND idVenta='" + idVenta + "'";

            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("VENTA CANCELADA");
                limpiar();
            }
            catch (MySqlException)
            {
                MessageBox.Show("NO SE PUEDE CANCELAR LA VENTA");
            }
            finally
            {
                conexionBD.Close();
            }
        }
        private void limpiar()
        {
            txtIdCliente.Text = "";
            txtUsuarioCliente.Text = "";
            txtNombreCliente.Text = "";
            txtCorreoCliente.Text = "";
            txtRFC.Text = "";
            txtRegimenFiscal.Text = "";
            txtCodigoPostal.Text = "";

            txtIdVendedor.Text = "";
            txtUsuarioVendedor.Text = "";
            txtTipoUsuario.Text = "";
            txtNombreVendedor.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";

            txtNoSerieMotor.Text = "";
            txtTipo.Text = "";
            txtModelo.Text = "";
            txtColor.Text = "";
            txtKilometros.Text = "";
            txtPrecio.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String idCliente = txtIdCliente.Text;

            MySqlDataReader reader = null;

            String sql = "SELECT * FROM cliente WHERE idCliente LIKE '" + idCliente + "' LIMIT 1";

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
                        txtUsuarioCliente.Text = reader.GetString(1);
                        txtNombreCliente.Text = reader.GetString(2);
                        txtCorreoCliente.Text = reader.GetString(3);
                        txtRFC.Text = reader.GetString(4);
                        txtRegimenFiscal.Text = reader.GetString(5);
                        txtCodigoPostal.Text = reader.GetString(6);
                    }
                }
                else
                {
                    MessageBox.Show("NO SE ENCONTRARON LOS DATOS DEL CLIENTE");
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

        private void btnAgregarFecha_Click(object sender, EventArgs e)
        {
            String noSerieMotor = txtNoSerieMotor.Text;

            MySqlDataReader reader = null;

            String sql = "SELECT Numero_Serie_Motor,Tipo,Modelo,Color,Kilometros,Precio FROM autos WHERE Numero_Serie_Motor LIKE '" + noSerieMotor + "' LIMIT 1";

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
                        txtTipo.Text = reader.GetString(1);
                        txtModelo.Text = reader.GetString(2);
                        txtColor.Text = reader.GetString(3);
                        txtKilometros.Text = reader.GetString(4);
                        txtPrecio.Text = reader.GetString(5);
                    }
                }
                else
                {
                    MessageBox.Show("NO SE ENCONTRO EL VALOR DEL VEHICULO");
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show("ERROR AL AGREGAR EL PRECIO ");
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String idVenta = txtIdVenta.Text;

            MySqlDataReader reader = null;

            String sql = "SELECT * FROM ventas WHERE idVenta LIKE '" + idVenta + "' LIMIT 1";

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
                        txtIdVenta.Text = reader.GetString(0);
                        txtIdCliente.Text = reader.GetString(1);
                        txtIdVendedor.Text = reader.GetString(2);
                        txtFecha.Text = reader.GetString(3);
                        txtUsuarioVendedor.Text = reader.GetString(4);
                        txtUsuarioCliente.Text = reader.GetString(5);
                        txtNoSerieMotor.Text = reader.GetString(6);
                        txtPrecio.Text = reader.GetString(7);
                        txtMetodoPago.Text = reader.GetString(8);
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
