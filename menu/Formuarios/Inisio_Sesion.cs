using System;
using System.Windows.Forms;

namespace menu.Formuarios
{
    public partial class Inisio_Sesion : Form
    {
        public Inisio_Sesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            try
            {
                Clases.Control ctrl = new Clases.Control();
                string respuesta = ctrl.ctrLogin(usuario,password);

                if(respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Form1 frm = new Form1();
                    frm.Visible = true;
                    this.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
