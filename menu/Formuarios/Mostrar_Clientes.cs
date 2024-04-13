using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace menu.Formuarios
{
    public partial class Mostrar_Clientes : Form
    {
        public Mostrar_Clientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM cliente";

            MySqlConnection conexionBD = Clases.Conexion.conexion();
            try
            {
                conexionBD.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL MOSTRAR LOS EMPLEADOS" + ex.Message + ex.StackTrace);
                throw;
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
