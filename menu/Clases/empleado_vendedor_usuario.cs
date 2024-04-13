using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu.Clases
{
    class empleado_vendedor_usuario
    {
        int id;
        String usuario, password, tipo_usuario,confirmar_password, nombre, rfc, curp;
        int nss, telefono;
        String correo;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public string ConfirmarPassword { get => confirmar_password; set => confirmar_password = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Id { get => id; set => id = value; }
        public string Tipo_usuario { get => tipo_usuario; set => tipo_usuario = value; }
        public string Rfc { get => rfc; set => rfc = value; }
        public string Curp { get => curp; set => curp = value; }
        public int Nss { get => nss; set => nss = value; }
        public int Telefono { get => telefono; set => telefono = value; }

    }
}
