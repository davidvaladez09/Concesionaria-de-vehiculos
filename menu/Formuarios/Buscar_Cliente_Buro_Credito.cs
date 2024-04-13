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
    public partial class Buscar_Cliente_Buro_Credito : Form
    {
        public Buscar_Cliente_Buro_Credito()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;

            string sql = "SELECT * FROM buro_de_credito WHERE Nombre='" + nombre + "'";
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
            txtNombre.Text = "";
        }
    }
}
