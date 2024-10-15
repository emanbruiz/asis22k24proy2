using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Produccion // Espacio de nombres estandarizado con mayúsculas
{
    class Conexion_Produccion // Clase con nombre estandarizado
    {
        // Método que prueba la conexión a la base de datos utilizando una DSN específica.
        public OdbcConnection Probar_Conexion() // Método estandarizado
        {
            // Crear una nueva conexión utilizando la DSN especificada.
            OdbcConnection conn = new OdbcConnection("dsn=colchoneria");
            try
            {
                // Intentar abrir la conexión.
                conn.Open();
            }
            catch (OdbcException)
            {
                // Capturar cualquier excepción relacionada con ODBC y mostrar un mensaje en la consola.
                Console.WriteLine("No conectó");
            }
            // Retornar el objeto de conexión (abierto si la conexión fue exitosa, o cerrado si ocurrió un error).
            return conn;
        }
    }
}
