using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace menu.Formuarios
{
    public partial class Eliminar_Cliente : Form
    {
        public Eliminar_Cliente()
        {
            InitializeComponent();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            string usuarioCliente = txtUsuarioCliente.Text;

            string sql = "DELETE FROM cliente WHERE Usuario='" + usuarioCliente + "'";

            MySqlConnection conexionBD = Clases.Conexion.conexion();
            conexionBD.Open();

            if (txtIdCliente.Text == "")
            {
                MessageBox.Show("DEBES INGRESAR UN USUARIO DE CLIENTE");
            }
            else
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("CLIENTE ELIMINADO");
                    limpiar();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("NO PUEDES ELIMINAR A UN CLIENTE CON COMPRAS REGISTRADAS");
                }
                finally
                {
                    conexionBD.Close();
                }
            }
        }
        private void limpiar()
        {
            txtUsuarioCliente.Text = "";
            txtIdCliente.Text = "";
            txtNombreCliente.Text = "";
            txtRFC.Text = "";
            txtRegimenFiscal.Text = "";
            txtCorreoCliente.Text = "";
            txtCodigoPostal.Text = "";
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
