using Capa_Controlador_Produccion;
using System;
using System.Data;
using System.Windows.Forms;

namespace Capa_Vista_Produccion
{
    public partial class Frm_Implosion_Explosion_Materiales : Form
    {
        private readonly Control_Implosion_Explosion_Materiales control;

        public Frm_Implosion_Explosion_Materiales()
        {
            InitializeComponent();
            control = new Control_Implosion_Explosion_Materiales();
            MostrarCalculos();
        }

        // Lógica para la implosión de materiales
        private void Btn_implosion_material_Click_1(object sender, EventArgs e)
        {
            try
            {
                int cantidad_productos = int.Parse(Txt_cantidad_material.Text);
                int material_por_producto = int.Parse(Txt_cantidad_material_por_producto.Text);

                // Calcular y registrar implosión
                int total_materiales_necesarios = control.Calcular_Implosion(cantidad_productos, material_por_producto);

                // Mostrar el resultado
                MessageBox.Show($"Materiales necesarios: {total_materiales_necesarios}");
                MostrarCalculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el cálculo: " + ex.Message);
            }
        }

        // Lógica para la explosión de materiales
        private void Btn_explosion_material_Click_1(object sender, EventArgs e)
        {
            try
            {
                int stock_material = int.Parse(Txt_stock_material.Text);
                int material_por_producto = int.Parse(Txt_cantidad_material_por_producto.Text);

                // Calcular y registrar explosión
                int productos_disponibles = control.Calcular_Explosion(stock_material, material_por_producto);

                // Mostrar el resultado
                MessageBox.Show($"Productos que se pueden producir: {productos_disponibles}");
                MostrarCalculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el cálculo: " + ex.Message);
            }
        }

        // Método para visualizar los cálculos en el DataGridView
        private void MostrarCalculos()
        {
            DataTable tabla = control.Mostrar_Calculos();
            Dgv_Calculos.DataSource = tabla; // Asignar la tabla al DataGridView
        }
    }
}
