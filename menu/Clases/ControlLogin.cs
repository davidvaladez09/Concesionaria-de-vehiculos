using System;
using System.Security.Cryptography;
using System.Text;

namespace menu.Clases
{
    class ControlLogin
    {
        private string generarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString();
        }

        public string ctrLogin(string usuario, string password)
        {
            ModeloLogin modelo = new ModeloLogin();
            string respuesta = "";
            empleado_vendedor_usuario datosUsuario = null;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "DEBES LLENAR TODOS LOS CAMPOS";
            }
            else
            {
                datosUsuario = modelo.porUsuario(usuario);

                if (datosUsuario == null)
                {
                    respuesta = "SOLO EL GERENTE TIENE ACCESO A ESTE APARTADO. \nINTENTA DE NUEVO";
                }
                else
                {
                    if (datosUsuario.Password != generarSHA1(password))
                    {
                        respuesta = "CONTRASEÑA INCORRECTA;\nINTENTA DE NUEVO";
                    }
                }
            }
            return respuesta;
        }
    }
}
