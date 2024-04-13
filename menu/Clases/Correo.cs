using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace menu.Clases
{
    class Correo
    {
        MailMessage correos = new MailMessage();
        SmtpClient envios = new SmtpClient();

        public void enviarCorreo()
        {

        }
    }
}
