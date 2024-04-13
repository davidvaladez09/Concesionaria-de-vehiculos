using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace menu.Clases
{
    class Control
    {
        public string ctrlRegistro(empleado_vendedor_usuario usuario)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.Password) || string.IsNullOrEmpty(usuario.ConfirmarPassword) || string.IsNullOrEmpty(usuario.Nombre))
            {
                respuesta = "NO PUEDES DEJAR UN CAMPO VACIO";
            }
            else
            {
                if (usuario.Password == usuario.ConfirmarPassword)
                {
                    if (modelo.existeUsuario(usuario.Usuario))
                    {
                        respuesta = "EL USUARIO YA EXISTE";
                    }
                    else
                    {
                        usuario.Password = generarSHA1(usuario.Password);
                        modelo.Registro(usuario);
                    }
                }
                else
                {
                    respuesta = "LAS CONTRASEÑAS NO COINCIDEN";
                }
            }
            return respuesta;
        }
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
            Modelo modelo = new Modelo();
            string respuesta = "";
            empleado_vendedor_usuario datosUsuario = null;

            if(string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "DEBES LLENAR TODOS LOS CAMPOS";
            }
            else
            {
                datosUsuario = modelo.porUsuario(usuario);

                if(datosUsuario == null)
                {
                    respuesta = "USUARIO NO REGISTRADO";
                }
                else
                {
                    if(datosUsuario.Password != generarSHA1(password)){
                        respuesta = "USUARIO O CONTRASEÑA INCORRECTOS";
                    }
                }
            }
            return respuesta;
        }
    }
}
