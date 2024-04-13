using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace menu.Formuarios
{
    public partial class Buscar_Empleado : Form
    {
        public Buscar_Empleado()
        {
            InitializeComponent();
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            String idEmpleado = txtUsuarioEmpleado.Text;

            string sql = "SELECT * FROM empleado_vendedor_usuario WHERE idEmpleado_Vendedor_Usuario='" + idEmpleado + "'";
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
                MessageBox.Show("EMPLEADO NO SE PUDIERON MOSTRAR LOS DATOS");
            }
            finally
            {
                conexionBD.Close();
            }
        }
        private void limpiar()
        {
            txtUsuarioEmpleado.Text = "";
        }
    }
}
