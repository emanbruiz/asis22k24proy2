using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Explo_Implo
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public class Sentencias_Explo_Implo
    {
        private Conexion_Explo_Implo conexion = new Conexion_Explo_Implo();

        public int ObtenerUltimo()
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT MAX(Pk_id_explosion) FROM tbl_explosion";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToInt32(result) + 1 : 1;
                }
            } // La conexión se cierra automáticamente aquí
        }

        public void GuardarExplosion(int fkIdOrden, int fkIdProducto, int cantidad, int costoTotal, int duracionHoras, int fkIdProceso, DateTime fechaExplosion)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "INSERT INTO tbl_explosion (fk_id_orden, fk_id_Producto, cantidad, costo_total, duracion_horas, fk_id_proceso, fecha_explosion) " +
                               "VALUES (?, ?, ?, ?, ?, ?, ?)";
                using (OdbcCommand command = new OdbcCommand(query, conn))
                {
                    command.Parameters.AddWithValue("?", fkIdOrden);
                    command.Parameters.AddWithValue("?", fkIdProducto);
                    command.Parameters.AddWithValue("?", cantidad);
                    command.Parameters.AddWithValue("?", costoTotal);
                    command.Parameters.AddWithValue("?", duracionHoras);
                    command.Parameters.AddWithValue("?", fkIdProceso);
                    command.Parameters.AddWithValue("?", fechaExplosion);

                    command.ExecuteNonQuery();
                }
            } // La conexión se cierra automáticamente aquí
        }

        public void ModificarExplosion(int idExplosion, int fkIdOrden, int fkIdProducto, int cantidad, int costoTotal, int duracionHoras, int fkIdProceso, DateTime fechaExplosion)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = @"UPDATE tbl_explosion 
                             SET fk_id_orden = ?, fk_id_producto = ?, cantidad = ?, costo_total = ?, duracion_horas = ?, fk_id_proceso = ?, fecha_explosion =?
                             WHERE pk_id_explosion = ? ";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", fkIdOrden);
                    cmd.Parameters.AddWithValue("?", fkIdProducto);
                    cmd.Parameters.AddWithValue("?", cantidad);
                    cmd.Parameters.AddWithValue("?", costoTotal);
                    cmd.Parameters.AddWithValue("?", duracionHoras);
                    cmd.Parameters.AddWithValue("?", fkIdProceso);
                    cmd.Parameters.AddWithValue("?", fechaExplosion);
                    cmd.Parameters.AddWithValue("?", idExplosion);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se pudo Modificar el registro, puede que el estado esté en 0 o el ID no sea válido.");
                    }
                }
            }
        }

        public List<int> ObtenerIdsOrdenes()
        {
            List<int> ordenes = new List<int>();
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT Pk_id_orden FROM tbl_ordenes_produccion";
                using (OdbcCommand command = new OdbcCommand(query, conn))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ordenes.Add(reader.GetInt32(0));
                        }
                    }
                }
            } // La conexión se cierra automáticamente aquí
            return ordenes;
        }

        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT pk_id_producto, nombreProducto FROM Tbl_Productos";
                using (OdbcCommand command = new OdbcCommand(query, conn))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productos.Add(new Producto
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1)
                            });
                        }
                    }
                }
            } // La conexión se cierra automáticamente aquí
            return productos;
        }

        public List<int> ObtenerIdsProcesos()
        {
            List<int> procesos = new List<int>();
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT Pk_id_proceso FROM tbl_proceso_produccion_encabezado";
                using (OdbcCommand command = new OdbcCommand(query, conn))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            procesos.Add(reader.GetInt32(0));
                        }
                    }
                }
            } // La conexión se cierra automáticamente aquí
            return procesos;
        }

        public DataTable ObtenerTodosExplosion()
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT * FROM tbl_explosion";
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            } // La conexión se cierra automáticamente aquí
        }



        //----------------------------------------------AQUI EMPIEZA LA IMPLOSION-----------------------------------------------------//

        public int ObtenerUltimoImplo()
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT MAX(Pk_id_implosion) FROM tbl_implosion";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToInt32(result) + 1 : 1;
                }
            } // La conexión se cierra automáticamente aquí
        }



        public List<int> ObtenerIdsOrdenesImplo()
        {
            List<int> ordenes = new List<int>();
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT Pk_id_orden FROM tbl_ordenes_produccion";
                using (OdbcCommand command = new OdbcCommand(query, conn))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ordenes.Add(reader.GetInt32(0));
                        }
                    }
                }
            } // La conexión se cierra automáticamente aquí
            return ordenes;
        }


        public List<Producto> ObtenerProductosImplo()
        {
            List<Producto> productos = new List<Producto>();
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT pk_id_producto, nombreProducto FROM Tbl_Productos";
                using (OdbcCommand command = new OdbcCommand(query, conn))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productos.Add(new Producto
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1)
                            });
                        }
                    }
                }
            } // La conexión se cierra automáticamente aquí
            return productos;
        }

        public List<int> ObtenerIdsProcesosImplo()
        {
            List<int> procesos = new List<int>();
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT Pk_id_proceso FROM tbl_proceso_produccion_encabezado";
                using (OdbcCommand command = new OdbcCommand(query, conn))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            procesos.Add(reader.GetInt32(0));
                        }
                    }
                }
            } // La conexión se cierra automáticamente aquí
            return procesos;
        }

        public DataTable ObtenerTodosImplosion()
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT * FROM tbl_implosion";
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            } // La conexión se cierra automáticamente aquí
        }


        public void GuardarImplosion(int fkOrden, int fkProducto, string componente, int cantidadcom, int costocom, int duracion, int fkProceso, DateTime fechaImplosion)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "INSERT INTO tbl_implosion (fk_id_orden, fk_id_Producto_final, id_componente, cantidad_componente, costo_componente, duracion_horas, fk_id_proceso, fecha_implosion) " +
                               "VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
                using (OdbcCommand command = new OdbcCommand(query, conn))
                {
                    command.Parameters.AddWithValue("?", fkOrden);
                    command.Parameters.AddWithValue("?", fkProducto);
                    command.Parameters.AddWithValue("?", componente);
                    command.Parameters.AddWithValue("?", cantidadcom);
                    command.Parameters.AddWithValue("?", costocom);
                    command.Parameters.AddWithValue("?", duracion);
                    command.Parameters.AddWithValue("?", fkProceso);
                    command.Parameters.AddWithValue("?", fechaImplosion);

                    command.ExecuteNonQuery();
                }
            } // La conexión se cierra automáticamente aquí
        }

        public void ModificarImplosion(int IdImplosion, int fkOrden, int fkProducto, string componente, int cantidadcom, int costocom, int duracion, int fkProceso, DateTime fechaImplosion)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = @"UPDATE tbl_implosion 
                             SET fk_id_orden = ?, fk_id_Producto_final = ?, id_componente = ?, cantidad_componente = ?, costo_componente = ?, duracion_horas = ?, fk_id_proceso = ?, fecha_implosion =?
                             WHERE pk_id_implosion = ? ";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", fkOrden);
                    cmd.Parameters.AddWithValue("?", fkProducto);
                    cmd.Parameters.AddWithValue("?", componente);
                    cmd.Parameters.AddWithValue("?", cantidadcom);
                    cmd.Parameters.AddWithValue("?", costocom);
                    cmd.Parameters.AddWithValue("?", duracion);
                    cmd.Parameters.AddWithValue("?", fkProceso);
                    cmd.Parameters.AddWithValue("?", fechaImplosion);
                    cmd.Parameters.AddWithValue("?", IdImplosion);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se pudo Modificar el registro, puede que el estado esté en 0 o el ID no sea válido.");
                    }
                }
            }
        }

    }


}
