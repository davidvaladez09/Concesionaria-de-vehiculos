using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace menu.Clases
{
    class Modelo
    {
        public int Registro(empleado_vendedor_usuario usuario)
        {
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();

            string sql = "INSERT INTO empleado_vendedor_usuario(Usuario, Password, Tipo_Usuario, Nombre, RFC, CURP, NSS, Telefono, Correo) VALUES(@usuario,@password,@tipo_usuario,@nombre,@rfc,@curp,@nss,@telefono,@correo)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@password", usuario.Password);
            comando.Parameters.AddWithValue("@tipo_usuario", usuario.Tipo_usuario);
            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@rfc", usuario.Rfc);
            comando.Parameters.AddWithValue("@curp", usuario.Curp);
            comando.Parameters.AddWithValue("@nss", usuario.Nss);
            comando.Parameters.AddWithValue("@telefono", usuario.Telefono);
            comando.Parameters.AddWithValue("@correo", usuario.Correo);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }
        public bool existeUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();

            string sql = "SELECT Tipo_Usuario FROM empleado_vendedor_usuario WHERE Usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public empleado_vendedor_usuario porUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.conexion();
            conexion.Open();

            string sql = "SELECT idEmpleado_Vendedor_Usuario, Nombre, Password, Tipo_Usuario FROM empleado_vendedor_usuario WHERE Usuario LIKE @usuario";
           // string sql = "SELECT idEmpleado_Vendedor_Usuario, Nombre, Password, Tipo_Usuario FROM empleado_vendedor_usuario WHERE Usuario='david_valadez'";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            empleado_vendedor_usuario usr = null;

            while (reader.Read())
            {
                usr = new empleado_vendedor_usuario();
                usr.Id = int.Parse(reader["idEmpleado_Vendedor_Usuario"].ToString());
                usr.Password = reader["Password"].ToString();
                usr.Nombre = reader["Nombre"].ToString();
                usr.Tipo_usuario = reader["Tipo_Usuario"].ToString();
            }
            return usr;

        }
    }
}
