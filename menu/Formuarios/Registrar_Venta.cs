using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace menu.Formuarios
{
    public partial class Registrar_Venta : Form
    {
        public Registrar_Venta()
        {
            InitializeComponent();
        }

        private void txtNoSerieMotor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {

        }

        DateTime hoy = DateTime.Now;
        private void btnAgregarFecha_Click(object sender, EventArgs e)
        {
            String noSerieMotor = txtNoSerieMotor.Text;
            //double precio = double.Parse(txtPrecio.Text);
            //int meses = int.Parse(comboBoxMeses.Text);

            //double cuotas = precio / meses;


            MySqlDataReader reader = null;

            String sql = "SELECT * FROM autos WHERE Numero_Serie_Motor LIKE '" + noSerieMotor + "' LIMIT 1";

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
                        txtMarca.Text = reader.GetString(1);
                        txtAnio.Text = reader.GetString(2);
                        txtTipo.Text = reader.GetString(3);
                        txtModelo.Text = reader.GetString(4);
                        txtColor.Text = reader.GetString(5);
                        txtKilometros.Text = reader.GetString(6);
                        txtPrecio.Text = reader.GetString(7);
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

            txtFecha.Text = hoy.ToString("yyyy/MM/dd");
            //cuotas = double.Parse(txtCuotas.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idCliente = int.Parse(txtIdCliente.Text);
            int idVendedor = int.Parse(txtIdVendedor.Text);
            String usuarioCliente = txtUsuarioCliente.Text;
            String usuarioVendedor = txtUsuarioVendedor.Text;
            String noSerieMotor = txtNoSerieMotor.Text;
            String fecha = txtFecha.Text;
            double precio = double.Parse(txtPrecioVenta.Text);
            String metodoPago = txtMetodoPago.Text;
            double mesesPago = double.Parse(txtMeses.Text);

            string sql = "INSERT INTO ventas (idCliente, idVendedor, Fecha, Usuario_Vendedor, Usuario_Cliente, Numero_Serie_Motor, Precio_Monto, Metodo_Pago) VALUES('" + idCliente + "', '" + idVendedor + "', '" + fecha + "', '" + usuarioVendedor + "', '" + usuarioCliente + "', '" + noSerieMotor + "', '" + precio + "', '" + metodoPago + "')";

            MySqlConnection conexionBD = Clases.Conexion.conexion();
            conexionBD.Open();


            if (txtFecha.Text == "" || txtIdVendedor.Text == "" || txtIdCliente.Text == "" || txtNoSerieMotor.Text == "" || txtPrecio.Text == "" || txtFecha.Text == "" || txtMetodoPago.Text == "" || txtMeses.Text == "")
            {
                MessageBox.Show("NO PUEDES DEJAR NINGUN CAMPO VACIO");
            }
            else
            {
                try
                {
                    /*VALIDACION EMPLEADO*/
                    String idEmpleado = txtIdVendedor.Text;
                    //String idEmpleado = txtUsuarioVendedor.Text;

                    string sqlEmpleado = "SELECT * FROM empleado_vendedor_usuario WHERE idVendedor='" + idEmpleado + "'";
                    MySqlConnection conexionBDEmpleado = Clases.Conexion.conexion();
                    conexionBDEmpleado.Open();

                    try
                    {
                        MySqlCommand comandoEmpleado = new MySqlCommand(sqlEmpleado, conexionBDEmpleado);
                        //MessageBox.Show("Usuario Registrado");
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("EMPLEADO NO REGISTRADO, HAZ INGRESADO UN DATO NO VALIDO");
                    }
                    finally
                    {
                        conexionBDEmpleado.Close();
                    }


                    /*-------------------------------------------------------------------*/
                    /*VALIDACION CLIENTE*/
                    String idClienteBusqueda = txtIdCliente.Text;

                    //String idClienteBusqueda = txtUsuarioCliente.Text;

                    string sqlCliente = "SELECT * FROM cliente WHERE idCliente='" + idClienteBusqueda + "'";
                    MySqlConnection conexionBDCliente = Clases.Conexion.conexion();
                    conexionBDCliente.Open();

                    try
                    {
                        MySqlCommand comandoCliente = new MySqlCommand(sqlCliente, conexionBDCliente);
                        //MessageBox.Show("Usuario Registrado");
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("CLIENTE NO REGISTRADO, HAZ INGRESADO UN DATO NO VALIDO");
                    }
                    finally
                    {
                        conexionBDCliente.Close();
                    }
                    /*-------------------------------------------------------------------*/

                    /*VALIDACION AUTO*/
                    String noMotor = txtNoSerieMotor.Text;

                    string sqlAuto = "SELECT * FROM autos WHERE Numero_Serie_Motor='" + noMotor + "'";
                    MySqlConnection conexionBDAuto = Clases.Conexion.conexion();
                    conexionBDAuto.Open();

                    try
                    {
                        MySqlCommand comandoAuto = new MySqlCommand(sqlAuto, conexionBDAuto);
                        //MessageBox.Show("Usuario Registrado");
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("AUTO NO REGISTRADO, HAZ INGRESADO UN DATO NO VALIDO");
                    }
                    finally
                    {
                        conexionBDAuto.Close();
                    }
                    /*-------------------------------------------------------------------*/


                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("VENTA REGISTRADA");
                    /*MOSTRAR LAS VENTAS REGISTRADAS AL REGISTRAR UNA NUEVA*/
                    string sqlVentas = "SELECT * FROM ventas";

                    MySqlConnection conexionBDVentas = Clases.Conexion.conexion();
                    try
                    {
                        conexionBDVentas.Open();

                        MySqlCommand comandoVentas = new MySqlCommand(sqlVentas, conexionBDVentas);
                        MySqlDataAdapter adaptar = new MySqlDataAdapter();
                        adaptar.SelectCommand = comandoVentas;
                        DataTable tabla = new DataTable();
                        adaptar.Fill(tabla);
                        dataGridView1.DataSource = tabla;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ERROR AL MOSTRAR LAS VENTAS");
                        throw;
                    }
                    finally
                    {
                        conexionBDVentas.Close();
                    }
                    /*--------------------------------------------------------------------*/
                    limpiar();

                }
                catch (Exception)
                {
                    MessageBox.Show("VENTA NO REGISTRADA, HAZ INGRESADO UN DATO NO VALIDO");
                }
                finally
                {
                    conexionBD.Close();
                }
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
            txtAnio.Text = "";
            txtMarca.Text = "";

            txtFecha.Text = "";
            txtPrecio.Text = "";
            txtMetodoPago.Text = "";
           // txtCuotas.Text = "";
            txtMeses.Text = "";
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

        private void button2_Click(object sender, EventArgs e)
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

        private void txtKilometros_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtTipoUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtIdVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuarioVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarVentas_Click(object sender, EventArgs e)
        {
            string sqlVentas = "SELECT * FROM ventas";

            MySqlConnection conexionBDVentas = Clases.Conexion.conexion();
            try
            {
                conexionBDVentas.Open();

                MySqlCommand comandoVentas = new MySqlCommand(sqlVentas, conexionBDVentas);
                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comandoVentas;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL MOSTRAR LAS VENTAS");
                throw;
            }
            finally
            {
                conexionBDVentas.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCuotas_Click(object sender, EventArgs e)
        {
            // int meses = int.Parse(comboBoxMeses.Text);
            //double precio = double.Parse(txtPrecio.Text);

            //double cuotas = precio / meses;

            //cuotas = double.Parse(txtCuotas.Text);

            //txtCuotas.Text = cuotas;

            /* double precio1 = double.Parse(txtPrecio.Text);

             double meses = double.Parse(txtMeses.Text);
             //double meses = double.Parse(comboBoxMeses.SelectedValue.ToString())

             //double cuotas = meses / precio;

             txtPrecioVenta.Text = precioVenta.ToString();

             double precio = double.Parse(txtPrecioVenta.Text);
             double cuotas;

             cuotas = precio / meses;

             txtCuotas.Text = cuotas.ToString();*/
            //txtFecha.Text = hoy.ToString("yyyy/MM/dd");
            //txtCuotas.Text = Convert.ToDouble();
        }

        private void txtRFC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void btnCompletarVehiculo1_Click(object sender, EventArgs e)
        {
            //String noSerieMotor = txtNoSerieMotor1.Text;
            //double precio = double.Parse(txtPrecio.Text);
            //int meses = int.Parse(comboBoxMeses.Text);

            //double cuotas = precio / meses;

            /*
            MySqlDataReader reader = null;

            if (txtNoSerieMotor1.Text == txtNoSerieMotor.Text || txtNoSerieMotor1.Text == txtNoSerieMotor3.Text || txtNoSerieMotor1.Text == txtNoSerieMotor4.Text || txtNoSerieMotor1.Text == txtNoSerieMotor5.Text)
            {
                MessageBox.Show("NO PUEDES INGRESAR ESTE VEHICULO, YA LO HAZ INGRESADO");
            }
            else
            {
                String sql = "SELECT * FROM autos WHERE Numero_Serie_Motor LIKE '" + noSerieMotor + "' LIMIT 1";

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
                            txtMarca1.Text = reader.GetString(1);
                            txtAnio1.Text = reader.GetString(2);
                            txtTipo1.Text = reader.GetString(3);
                            txtModelo1.Text = reader.GetString(4);
                            txtColor1.Text = reader.GetString(5);
                            txtKilometros1.Text = reader.GetString(6);
                            txtPrecio1.Text = reader.GetString(7);
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
            }*/
        }

        private void btnCompletarVehiculo3_Click(object sender, EventArgs e)
        {
            // String noSerieMotor = txtNoSerieMotor3.Text;
            //double precio = double.Parse(txtPrecio.Text);
            //int meses = int.Parse(comboBoxMeses.Text);

            //double cuotas = precio / meses;


            /*  MySqlDataReader reader = null;


              if (txtNoSerieMotor3.Text == txtNoSerieMotor.Text || txtNoSerieMotor3.Text == txtNoSerieMotor1.Text || txtNoSerieMotor3.Text == txtNoSerieMotor4.Text || txtNoSerieMotor3.Text == txtNoSerieMotor5.Text)
              {
                  MessageBox.Show("NO PUEDES INGRESAR ESTE VEHICULO, YA LO HAZ INGRESADO");
              }
              else
              {
                  String sql = "SELECT * FROM autos WHERE Numero_Serie_Motor LIKE '" + noSerieMotor + "' LIMIT 1";

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
                              txtMarca3.Text = reader.GetString(1);
                              txtAnio3.Text = reader.GetString(2);
                              txtTipo3.Text = reader.GetString(3);
                              txtModelo3.Text = reader.GetString(4);
                              txtColor3.Text = reader.GetString(5);
                              txtKilometros3.Text = reader.GetString(6);
                              txtPrecio3.Text = reader.GetString(7);
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
              }*/
        }

        private void btnCompletarVehiculo4_Click(object sender, EventArgs e)
        {
            // String noSerieMotor = txtNoSerieMotor4.Text;
            //double precio = double.Parse(txtPrecio.Text);
            //int meses = int.Parse(comboBoxMeses.Text);

            //double cuotas = precio / meses;


            /* MySqlDataReader reader = null;


             if (txtNoSerieMotor4.Text == txtNoSerieMotor.Text || txtNoSerieMotor4.Text == txtNoSerieMotor1.Text || txtNoSerieMotor4.Text == txtNoSerieMotor1.Text || txtNoSerieMotor4.Text == txtNoSerieMotor5.Text)
             {
                 MessageBox.Show("NO PUEDES INGRESAR ESTE VEHICULO, YA LO HAZ INGRESADO");
             }
             else
             {
                 String sql = "SELECT * FROM autos WHERE Numero_Serie_Motor LIKE '" + noSerieMotor + "' LIMIT 1";

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
                             txtMarca4.Text = reader.GetString(1);
                             txtAnio4.Text = reader.GetString(2);
                             txtTipo4.Text = reader.GetString(3);
                             txtModelo4.Text = reader.GetString(4);
                             txtColor4.Text = reader.GetString(5);
                             txtKilometros4.Text = reader.GetString(6);
                             txtPrecio4.Text = reader.GetString(7);
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
             }*/
        }

        private void btnCompletarVehiculo5_Click(object sender, EventArgs e)
        {
            //   String noSerieMotor = txtNoSerieMotor5.Text;
            //double precio = double.Parse(txtPrecio.Text);
            //int meses = int.Parse(comboBoxMeses.Text);

            //double cuotas = precio / meses;


            /*MySqlDataReader reader = null;

            String sql = "SELECT * FROM autos WHERE Numero_Serie_Motor LIKE '" + noSerieMotor + "' LIMIT 1";

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
                        txtMarca5.Text = reader.GetString(1);
                        txtAnio5.Text = reader.GetString(2);
                        txtTipo5.Text = reader.GetString(3);
                        txtModelo5.Text = reader.GetString(4);
                        txtColor5.Text = reader.GetString(5);
                        txtKilometros5.Text = reader.GetString(6);
                        txtPrecio5.Text = reader.GetString(7);
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
        }*/
        }
    }
}
