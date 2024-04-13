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
    public partial class Registrar_Cliente : Form
    {
        public Registrar_Cliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String nombre = txtNombre.Text;
            String correo = txtCorreo.Text;
            String rfc = txtRfc.Text;
            String regimen_fiscal = txtRegimenFiscal.Text;
            int codigo_postal = int.Parse(txtCodigoPostal.Text);

            string sql = "INSERT INTO cliente (Usuario, Nombre, Correo, RFC, Regimen_Fiscal, Codigo_Postal) VALUES('" + usuario + "','" + nombre + "','" + correo + "', '" + rfc + "', '" + regimen_fiscal + "', '" + codigo_postal + "')";

            MySqlConnection conexionBD = Clases.Conexion.conexion();
            conexionBD.Open();


            if (txtRegimenFiscal.Text == "" || txtUsuario.Text == "" || txtRfc.Text == "" || txtCodigoPostal.Text == "" || txtNombre.Text == "" || txtCorreo.Text == "")
            {
                MessageBox.Show("NO PUEDES DEJAR NINGUN CAMPO VACIO");
            }
            else
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("REGISTRO GUARDADO.");
                    limpiar();
                    /*MOSTRAR LOS CLIENTES REGISTRADOS AL REGISTRAR UNO NUEVO*/
                    string sqlVentas = "SELECT * FROM cliente";

                    MySqlConnection conexionBDClientes = Clases.Conexion.conexion();
                    try
                    {
                        conexionBDClientes.Open();

                        MySqlCommand comandoClientes = new MySqlCommand(sqlVentas, conexionBDClientes);
                        MySqlDataAdapter adaptar = new MySqlDataAdapter();
                        adaptar.SelectCommand = comandoClientes;
                        DataTable tabla = new DataTable();
                        adaptar.Fill(tabla);
                        dataGridView1.DataSource = tabla;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ERROR AL MOSTRAR LOS CLIENTES REGSITRADOS");
                        //throw;
                    }
                    finally
                    {
                        conexionBDClientes.Close();
                    }
                    /*--------------------------------------------------------------------*/

                }
                catch (Exception)
                {
                    MessageBox.Show("CLIENTE NO REGISTRADO HAZ INGRESADO DATOS NO VALIDOS");
                }
                finally
                {
                    conexionBD.Close();
                }
            }
        }
        private void limpiar()
        {
            txtUsuario.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtRfc.Text = "";
            txtRegimenFiscal.Text = "";
            txtCodigoPostal.Text = "";
        }
    }
}
