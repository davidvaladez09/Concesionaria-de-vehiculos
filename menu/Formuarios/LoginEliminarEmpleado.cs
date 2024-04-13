using System;
using System.Windows.Forms;

namespace menu.Formuarios
{
    public partial class LoginEliminarEmpleado : Form
    {
        public LoginEliminarEmpleado()
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
                    /*OpcionMenu registrar_vehiculo = new OpcionMenu();
                    registrar_vehiculo.Visible = true;*/
                    Eliminar_Empleado eliminar_Empleado = new Eliminar_Empleado();
                    eliminar_Empleado.Visible = true;
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
