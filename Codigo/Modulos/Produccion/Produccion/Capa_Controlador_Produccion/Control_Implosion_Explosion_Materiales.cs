using Capa_Modelo_Produccion;
using System.Data;

namespace Capa_Controlador_Produccion
{
    public class Control_Implosion_Explosion_Materiales
    {
        private readonly Sentencia_Produccion sentencias;

        public Control_Implosion_Explosion_Materiales()
        {
            sentencias = new Sentencia_Produccion();
        }

        // Método para calcular y registrar la implosión de materiales
        public int Calcular_Implosion(int cantidad_productos, int material_por_producto)
        {
            int total_materiales_necesarios = cantidad_productos * material_por_producto;
            // Registrar en la base de datos
            sentencias.Registrar_Implosion(cantidad_productos, material_por_producto, total_materiales_necesarios);
            return total_materiales_necesarios;
        }

        // Método para calcular y registrar la explosión de materiales
        public int Calcular_Explosion(int stock_material, int material_por_producto)
        {
            int productos_disponibles = stock_material / material_por_producto;
            // Registrar en la base de datos
            sentencias.Registrar_Explosion(stock_material, material_por_producto, productos_disponibles);
            return productos_disponibles;
        }

        // Método para mostrar todos los cálculos
        public DataTable Mostrar_Calculos()
        {
            return sentencias.Mostrar_Calculos();
        }
    }
}
