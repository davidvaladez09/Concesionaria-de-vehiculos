using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace menu.Formuarios
{
    public partial class Eliminar_Vehiculo : Form
    {
        public Eliminar_Vehiculo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        MySqlConnection conexionBD = new MySqlConnection("server=localhost; database=concesionaria; Uid=root; pwd=Astro090");
        private void btnEliminarVehiculo_Click(object sender, EventArgs e)
        {
            string noSerieMotor = txtNoSerieMotor.Text;

            string sql = "DELETE FROM Autos WHERE Numero_Serie_Motor='" + noSerieMotor + "'";

            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("REGISTRO ELIMINADO");
                limpiar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR DATO NO ELIMINADO" + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNoSerieMotor.Text = "";
        }

        private void limpiar()
        {
            txtNoSerieMotor.Text = "";
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
    }
}
