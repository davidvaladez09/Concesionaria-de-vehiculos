using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu.Formuarios
{
    public partial class LoginBuscarVentaEmpleado : Form
    {
        public LoginBuscarVentaEmpleado()
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
                    BuscarVentaEmpleado buscarVentaEmpleado = new BuscarVentaEmpleado();
                    buscarVentaEmpleado.Visible = true;
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
