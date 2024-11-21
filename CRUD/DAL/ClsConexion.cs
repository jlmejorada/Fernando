using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClsConexion
    {
        /// <summary>
        /// Devuelve la cadena de conexion de nuestra base de datos
        /// </summary>
        /// <returns>String cadena</returns>
        public static String CadenaDeConexion()
        {
            String cadena = "server=jlmejorada.database.windows.net;" +
                    "database=jlmejoradaBD;uid=usuario;" +
                    "pwd=LaCampana123;trustServerCertificate=true;";

            return cadena;
        }

    }
}
