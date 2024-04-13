using System;
using System.Windows.Forms;

namespace menu.Formuarios
{
    public partial class LoginMostrarVentas : Form
    {
        public LoginMostrarVentas()
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
                    Mostrar_Ventas mostrar_Ventas = new Mostrar_Ventas();
                    mostrar_Ventas.Visible = true;
                    this.Visible = false;
                    /*Mostrar_Ventas mostrar_Ventas = new Mostrar_Ventas();
                    mostrar_Ventas.Visible = true;
                    this.Visible = false;*/
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
