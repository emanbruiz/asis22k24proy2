using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Produccion // Espacio de nombres estandarizado
{
    public class Sentencia_Produccion // Clase estandarizada con sufijo de Producción
    {
        private Conexion_Produccion conexion = new Conexion_Produccion(); // Instancia de la clase Conexion_Produccion

        // Agregar receta
        public void Agregar_Receta(string tipo_colchon, string producto, string descripcion, string cantidad, int stock) // Método estandarizado
        {
            string query = "INSERT INTO receta (tipo_colchon, producto, descripcion, cantidad, stock) VALUES (?, ?, ?, ?, ?)";
            using (OdbcConnection conn = conexion.Probar_Conexion()) // Método de conexión estandarizado
            {
                if (conn.State == ConnectionState.Open)
                {
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("tipo_colchon", tipo_colchon);
                        cmd.Parameters.AddWithValue("producto", producto);
                        cmd.Parameters.AddWithValue("descripcion", descripcion);
                        cmd.Parameters.AddWithValue("cantidad", cantidad);
                        cmd.Parameters.AddWithValue("stock", stock);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        // Modificar receta
        public void Modificar_Receta(int codigo, string tipo_colchon, string producto, string descripcion, string cantidad, int stock) // Método estandarizado
        {
            string query = "UPDATE receta SET tipo_colchon=?, producto=?, descripcion=?, cantidad=?, stock=? WHERE Codigo=?";
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State == ConnectionState.Open)
                {
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("tipo_colchon", tipo_colchon);
                        cmd.Parameters.AddWithValue("producto", producto);
                        cmd.Parameters.AddWithValue("descripcion", descripcion);
                        cmd.Parameters.AddWithValue("cantidad", cantidad);
                        cmd.Parameters.AddWithValue("stock", stock);
                        cmd.Parameters.AddWithValue("Codigo", codigo);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        // Eliminar receta
        public void Eliminar_Receta(int codigo) // Método estandarizado
        {
            string query = "DELETE FROM receta WHERE Codigo=?";
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State == ConnectionState.Open)
                {
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("Codigo", codigo);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        // Mostrar recetas
        public DataTable Mostrar_Recetas() // Método estandarizado
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM receta";
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State == ConnectionState.Open)
                {
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                        {
                            da.Fill(tabla);
                        }
                    }
                }
            }

            return tabla;
        }

        // Registrar cálculo de implosión en la base de datos
        public void Registrar_Implosion(int cantidad_productos, int material_por_producto, int total_materiales_necesarios)
        {
            string query = "INSERT INTO Tbl_Materiales_Calculo (tipo_calculo, cantidad_materiales, cantidad_productos, resultado, fecha_calculo) " +
                           "VALUES ('implosion', ?, ?, ?, CURDATE())";

            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State == ConnectionState.Open)
                {
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("cantidad_materiales", material_por_producto);
                        cmd.Parameters.AddWithValue("cantidad_productos", cantidad_productos);
                        cmd.Parameters.AddWithValue("resultado", total_materiales_necesarios);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        // Registrar cálculo de explosión en la base de datos
        public void Registrar_Explosion(int stock_material, int material_por_producto, int productos_disponibles)
        {
            string query = "INSERT INTO Tbl_Materiales_Calculo (tipo_calculo, cantidad_materiales, cantidad_productos, resultado, fecha_calculo) " +
                           "VALUES ('explosion', ?, ?, ?, CURDATE())";

            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State == ConnectionState.Open)
                {
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("cantidad_materiales", material_por_producto);
                        cmd.Parameters.AddWithValue("cantidad_productos", stock_material);
                        cmd.Parameters.AddWithValue("resultado", productos_disponibles);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        // Mostrar todos los cálculos registrados en la base de datos
        public DataTable Mostrar_Calculos()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM Tbl_Materiales_Calculo";
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State == ConnectionState.Open)
                {
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                        {
                            da.Fill(tabla);
                        }
                    }
                }
            }
            return tabla;
        }
    }
}
