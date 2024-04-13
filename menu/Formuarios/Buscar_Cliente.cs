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
    public partial class Buscar_Cliente : Form
    {
        public Buscar_Cliente()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string idCliente = txtUsuarioCliente.Text;

            string sql = "SELECT * FROM cliente WHERE idCliente='" + idCliente + "'";
            MySqlConnection conexionBD = Clases.Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                dataGridView1.DataSource = tabla;
                limpiar();
            }
            catch (MySqlException)
            {
                MessageBox.Show("ERROR AL BUSCAR ");
            }
            finally
            {
                conexionBD.Close();
            }
        }
        private void limpiar()
        {
            txtUsuarioCliente.Text = "";
        }
    }
}
