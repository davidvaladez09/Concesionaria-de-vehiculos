using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace menu.Formuarios
{
    public partial class Mostrar_Catalogo_Vehiculos : Form
    {
        public Mostrar_Catalogo_Vehiculos()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM autos";

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
                MessageBox.Show("ERROR AL MOSTRAR EL CATALOGO DE VEHÍCULOS" + ex.Message + ex.StackTrace);
                throw;
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
