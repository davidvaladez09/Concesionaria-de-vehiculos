using System;
using System.Windows.Forms;

namespace menu.Formuarios
{
    public partial class LoginRegistrarVendedor : Form
    {
        public LoginRegistrarVendedor()
        {
            InitializeComponent();
        }

        private void txtIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioGerente.Text;
            string password = txtPasswordGerente.Text;

            try
            {
                Clases.ControlLogin ctrl = new Clases.ControlLogin();
                string respuesta = ctrl.ctrLogin(usuario, password);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    /*Mostrar_Empleados mostrar_Empleados = new Mostrar_Empleados();
                    mostrar_Empleados.Visible = true;
                    this.Visible = false;*/
                    Registrar_Vendedor registrar_Vendedor = new Registrar_Vendedor();
                    registrar_Vendedor.Visible = true;
                    this.Visible = false;
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
            txtUsuarioGerente.Text = "";
            txtPasswordGerente.Text = "";
        }
    }
}
