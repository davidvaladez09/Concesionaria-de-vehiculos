using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace menu.Formuarios
{
    public partial class Buscar_Vehiculo : Form
    {
        public Buscar_Vehiculo()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String dato = txtDato.Text;

            string sql = "SELECT * FROM autos WHERE Marca='" + dato + "' OR Año='" + dato + "' OR Tipo='" + dato + "' OR Modelo='" + dato + "' OR Color='" + dato + "'";
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
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR AL BUSCAR " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
        private void limpiar()
        {
            txtDato.Text = "";
        }
    }
}
