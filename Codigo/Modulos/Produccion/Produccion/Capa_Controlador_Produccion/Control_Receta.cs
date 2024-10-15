using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Produccion; // Espacio de nombres estandarizado con mayúscula por palabra
using System.Data;

namespace Capa_Controlador_Produccion // Espacio de nombres estandarizado con mayúscula por palabra
{
    public class Control_Receta // Clase con el nombre Control_Receta
    {
        private readonly Sentencia_Produccion sentencias; // Variable con nombre estandarizado

        public Control_Receta()
        {
            sentencias = new Sentencia_Produccion(); // Inicialización de la clase del modelo
        }

        // Método para agregar una nueva receta
        public void Agregar_Receta(string tipo_producto, string nombre_producto, string descripcion, string cantidad, int stock)
        {
            sentencias.Agregar_Receta(tipo_producto, nombre_producto, descripcion, cantidad, stock);
        }

        // Método para modificar una receta existente
        public void Modificar_Receta(int codigo, string tipo_producto, string nombre_producto, string descripcion, string cantidad, int stock)
        {
            sentencias.Modificar_Receta(codigo, tipo_producto, nombre_producto, descripcion, cantidad, stock);
        }

        // Método para eliminar una receta por su código
        public void Eliminar_Receta(int codigo)
        {
            sentencias.Eliminar_Receta(codigo);
        }

        // Método para obtener todas las recetas
        /*public DataTable Mostrar_Recetas()
        {
            //return sentencias.Mostrar_Recetas();
        }*/
    }
}
