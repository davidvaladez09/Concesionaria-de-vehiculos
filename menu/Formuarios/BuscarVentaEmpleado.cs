using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace menu.Formuarios
{
    public partial class BuscarVentaEmpleado : Form
    {
        public BuscarVentaEmpleado()
        {
            InitializeComponent();
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            String usuarioVendedor = txtUsuarioVendedor.Text;

           // string sql = "SELECT * FROM ventas WHERE Fecha='" + fecha + "' AND Usuario_Vendedor='" + usuarioVendedor + "'";
            string sql = "SELECT * FROM ventas WHERE idVendedor='" + usuarioVendedor + "'";

            MySqlConnection conexionBD = Clases.Conexion.conexion();
            conexionBD.Open();

            if (txtUsuarioVendedor.Text == "")
            {
                MessageBox.Show("NO PUEDES DEJAR ALGUN CAMPO VACIO");
            }
            else
            {
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
                    MessageBox.Show("VENTA NO ENCONTRADA" + ex.Message);
                }
                finally
                {
                    conexionBD.Close();
                }
            }
        }
        private void limpiar()
        {
            txtUsuarioVendedor.Text = "";
        }

        private void txtUsuarioVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
