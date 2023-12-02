using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace LoginEjempli.Clases
{
    public class usuario
    {
        private static int Id;
        private static string Correo;
        private static string Clave;
        private static string Nombre;

        public usuario(string id,string correo,string clave,string nombre)
        {
       
            Correo = correo;
            Clave = clave;
            Nombre = nombre;

        }

        public usuario()
        { 

        }
        public usuario( string correo, string clave)
        {

            Correo = correo;
            Clave = clave;

        }
        // Getter funcion me devuelve un valor
        // Setter asignar un valor

        public static int GetId()
        {
            return Id;
        }

        public static string GetCorreo()
        {
            return Correo;
        }
        public static string GetNombre()
        {
            return Nombre;
        }
        public void SetID(int id)
        {
            Id = id;
        }
        public void SetNombre(string nombre)
        {
            Nombre= nombre;
        }
        public void SetClave(string clave)
        {
           Clave = clave;
        }

        public void SetCorreo(string correo)
        {
            Correo = correo;
        }

        public static int ValidarLogin()
        {
            int retorno = 0;
            int tipo = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("validarusuario", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@Correo", Correo));
                    cmd.Parameters.Add(new SqlParameter("@Clave", Clave));

                    retorno = cmd.ExecuteNonQuery();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            retorno = 1;
                        
                        }
                        else
                        {
                            retorno = -1;
                        }

                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }

            return retorno;
        }
    }

}