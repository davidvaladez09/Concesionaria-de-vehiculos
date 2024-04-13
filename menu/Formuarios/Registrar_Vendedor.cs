using System;
using System.Data;
using System.Windows.Forms;
using menu.Clases;
using MySql.Data.MySqlClient;

namespace menu.Formuarios
{
    public partial class Registrar_Vendedor : Form
    {
        public Registrar_Vendedor()
        {
            InitializeComponent();
        }

        private void btnRegistrarVendedor_Click(object sender, EventArgs e)
        {
            Clases.empleado_vendedor_usuario usuario = new Clases.empleado_vendedor_usuario();
            usuario.Usuario = txtUsuario.Text;
            usuario.Password = txtPassword.Text;
            usuario.ConfirmarPassword = txtConfirmarPassword.Text;
            usuario.Tipo_usuario = txtTipoUsuario.Text;
            usuario.Nombre = txtNombre.Text;
            usuario.Rfc = txtRfc.Text;
            usuario.Curp = txtCurp.Text;
            usuario.Nss = int.Parse(txtNss.Text);
            usuario.Telefono = int.Parse(txtTelefono.Text);
            usuario.Correo = txtCorreo.Text;



            try
            {
                Clases.Control control = new Clases.Control();
                string respuesta = control.ctrlRegistro(usuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "NO SE REGISTRO AL VENDEDOR, HAZ INGRESADO UN DATO NO VALIDO");
                }
                else
                {
                    MessageBox.Show(respuesta, "VENDEDOR REGISTRADO");
                    string sql = "SELECT * FROM empleado_vendedor_usuario";

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
                        MessageBox.Show("ERROR AL MOSTRAR LOS EMPLEADOS");
                        throw;
                    }
                    finally
                    {
                        conexionBD.Close();
                    }
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void limpiar()
        {
            txtPassword.Text = "";
            txtNombre.Text = "";
            txtRfc.Text = "";
            txtCurp.Text = "";
            txtNss.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtUsuario.Text = "";
            txtConfirmarPassword.Text = "";
            txtTipoUsuario.Text = "";
        }
    }
}
