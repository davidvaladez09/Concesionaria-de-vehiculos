using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace menu.Formuarios
{
    public partial class Buscar_Venta : Form
    {
        public Buscar_Venta()
        {
            InitializeComponent();
        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            //txtFecha.Text = "Año/Mes/dia";
            //txtFecha.ForeColor = Color.Gray;
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            String fecha = txtFecha.Text;
            String usuarioVendedor = txtUsuarioVendedor.Text;

            string sql = "SELECT * FROM ventas WHERE Fecha='" + fecha + "' AND Usuario_Vendedor='" + usuarioVendedor + "'";
            //string sql = "SELECT * FROM ventas WHERE Fecha=Usuario_Vendedor='" + usuarioVendedor + "'";

            MySqlConnection conexionBD = Clases.Conexion.conexion();
            conexionBD.Open();

            if (txtFecha.Text == "" || txtUsuarioVendedor.Text == "")
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
            txtFecha.Text = "";
            txtUsuarioVendedor.Text = "";
        }

        private void txtUsuarioVendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
