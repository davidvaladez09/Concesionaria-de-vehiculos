using System;
using System.Windows.Forms;

namespace menu.Formuarios
{
    public partial class LoginBuscarEmpleado : Form
    {
        public LoginBuscarEmpleado()
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
                    Buscar_Empleado buscar_Empleado = new Buscar_Empleado();
                    buscar_Empleado.Visible = true;
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
