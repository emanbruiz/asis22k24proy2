using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Capa_Controlador_Explo_Implo;
using System.IO;

namespace Capa_Vista_Explo_Implo
{
    public partial class Frm_Explo_Implo : Form
    {
        private Controlador_Explo_Implo controlador = new Controlador_Explo_Implo();

        public Frm_Explo_Implo()
        {
            InitializeComponent();
            CargarComboBoxes();
            //CargarSiguienteIdExplosion();
            CargarExplosiones();
            CargarImplosion();
            CargarComboBoxesImplo();

            cbo_orden.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_proceso.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_producto.DropDownStyle = ComboBoxStyle.DropDownList;

            cbo_orden_implosion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_proceso_implo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_producto_final.DropDownStyle = ComboBoxStyle.DropDownList;

            btn_guardar.Enabled = false;
            Btn_guardar_implo.Enabled = false;
            txt_id_explosion.Enabled = false;
            txt_id_implosion.Enabled = false;

            txt_cantidad.KeyPress += txt_Numeros_KeyPress;
            txt_costo_total.KeyPress += txt_Numeros_KeyPress;
            txt_duracion.KeyPress += txt_Numeros_KeyPress;

            txt_cantidad_com.KeyPress += txt_Numeros_KeyPress;
            txt_costo_com.KeyPress += txt_Numeros_KeyPress;
            txt_duracion_implo.KeyPress += txt_Numeros_KeyPress;
        }

        private void InicializarFormulario()
        {
            txt_id_explosion.Text = controlador.ObtenerUltimoID().ToString();
            txt_id_explosion.Enabled = false;
            //DeshabilitarCampos();
            //CargarEmpleados();
            //CargarDias();
            txt_id_explosion.Text = controlador.ObtenerUltimoID().ToString();

           
        }

        private void CargarExplosiones()
        {
            dgv_explosion.DataSource = controlador.ObtenerTodosLosRegistros();
        }

        private void txt_Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CargarComboBoxes()
        {
            // Llenar cbo_orden
            cbo_orden.DataSource = controlador.ObtenerOrdenesProduccion();
            cbo_orden.DisplayMember = "Pk_id_orden";
            //cbo_orden.ValueMember = "Pk_id_orden";

            // Llenar cbo_producto con el Dictionary<int, string>
            var productosDict = controlador.ObtenerProductos();
            cbo_producto.DataSource = new BindingSource(productosDict, null);
            cbo_producto.DisplayMember = "Value"; // El nombre del producto
            cbo_producto.ValueMember = "Key";     // El ID del producto

            // Llenar cbo_proceso
            cbo_proceso.DataSource = controlador.ObtenerProcesosProduccion();
            cbo_proceso.DisplayMember = "Pk_id_proceso";
            //cbo_proceso.ValueMember = "Pk_id_proceso";
        }


        private void LimpiarCampos()
        {
            txt_cantidad.Clear();
            txt_costo_total.Clear();
            txt_duracion.Clear();
            btn_guardar.Enabled = true;
            
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            InicializarFormulario();
            LimpiarCampos();
            btn_guardar.Enabled = true;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar y convertir los valores de los campos
                if (!int.TryParse(cbo_orden.SelectedValue?.ToString(), out int fkIdOrden))
                {
                    MessageBox.Show("Por favor, ingresa valores a los campos.");
                    return;
                }
                if (!int.TryParse(cbo_producto.SelectedValue?.ToString(), out int fkIdProducto))
                {
                    MessageBox.Show("Por favor, ingresa valores a los campos.");
                    return;
                }
                if (!int.TryParse(txt_costo_total.Text, out int costoTotal))
                {
                    MessageBox.Show("Por favor, ingresa valores a los campos.");
                    return;
                }
                if (!int.TryParse(txt_cantidad.Text, out int cantidad))
                {
                    MessageBox.Show("Por favor, ingresa valores a los campos.");
                    return;
                }
                if (!int.TryParse(txt_duracion.Text, out int duracionHoras))
                {
                    MessageBox.Show("Por favor, ingresa valores a los campos.");
                    return;
                }
                if (!int.TryParse(cbo_proceso.SelectedValue?.ToString(), out int fkIdProceso))
                {
                    MessageBox.Show("Por favor, ingresa valores a los campos.");
                    return;
                }

                DateTime fechaExplosion = dtp_fecha.Value; // Obtener la fecha seleccionada

                // Llamar al método para guardar la receta
                controlador.GuardarExplosion(fkIdOrden, fkIdProducto, cantidad, costoTotal, duracionHoras, fkIdProceso, fechaExplosion);

                // Mensaje de éxito
                MessageBox.Show("La Explosion se guardó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresca el DataGridView y limpia los campos
                CargarExplosiones();
                LimpiarCampos();

                btn_guardar.Enabled = false;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, asegúrate de que todos los campos numéricos estén correctamente ingresados: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar la Explosion: " + ex.Message);
            }

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que se haya seleccionado un registro en el DataGridView
                if (dgv_explosion.CurrentRow != null)
                {
                    // Obtiene el ID del registro seleccionado
                    int idExplosion = Convert.ToInt32(dgv_explosion.CurrentRow.Cells["pk_id_explosion"].Value);

                    if (!int.TryParse(cbo_orden.SelectedValue?.ToString(), out int fkIdOrden))
                    {
                        MessageBox.Show("Por favor, seleccione los campos a modificar.");
                        return;
                    }
                    if (!int.TryParse(cbo_producto.SelectedValue?.ToString(), out int fkIdProducto))
                    {
                        MessageBox.Show("Por favor, seleccione los campos a modificar.");
                        return;
                    }
                    if (!int.TryParse(txt_costo_total.Text, out int costoTotal))
                    {
                        MessageBox.Show("Por favor, seleccione los campos a modificar.");
                        return;
                    }
                    if (!int.TryParse(txt_cantidad.Text, out int cantidad))
                    {
                        MessageBox.Show("Por favor, seleccione los campos a modificar.");
                        return;
                    }
                    if (!int.TryParse(txt_duracion.Text, out int duracionHoras))
                    {
                        MessageBox.Show("Por favor, seleccione los campos a modificar.");
                        return;
                    }
                    if (!int.TryParse(cbo_proceso.SelectedValue?.ToString(), out int fkIdProceso))
                    {
                        MessageBox.Show("Por favor, seleccione los campos a modificar.");
                        return;
                    }

                    DateTime fechaExplosion = dtp_fecha.Value; // Obtener la fecha seleccionada

                    // Llamar al método para guardar la receta
                    controlador.ModificarExplosion(idExplosion, fkIdOrden, fkIdProducto, cantidad, costoTotal, duracionHoras, fkIdProceso, fechaExplosion);

                    CargarExplosiones();
                    LimpiarCampos();
                    // Muestra un mensaje indicando que la actualización fue exitosa
                    MessageBox.Show("La Explosion se Modifico y se Actulizo correctamente.");
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún registro.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en el formato de los datos ingresados. Verifique e intente nuevamente.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Algunos campos necesarios no están seleccionados o están vacíos.", "Error de Referencia Nula", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar actualizar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que un registro esté seleccionado en el DataGridView
                if (dgv_explosion.SelectedRows.Count > 0)
                {
                    var row = dgv_explosion.SelectedRows[0];

                    txt_id_explosion.Text = row.Cells["Pk_id_explosion"].Value.ToString();
                    txt_cantidad.Text = row.Cells["cantidad"].Value.ToString();
                    txt_costo_total.Text = row.Cells["costo_total"].Value.ToString();
                    txt_duracion.Text = row.Cells["duracion_horas"].Value.ToString();

                    if (!string.IsNullOrEmpty(cbo_orden.ValueMember) && row.Cells["fk_id_orden"].Value != null)
                        cbo_orden.SelectedValue = row.Cells["fk_id_orden"].Value;

                    if (!string.IsNullOrEmpty(cbo_producto.ValueMember) && row.Cells["fk_id_producto"].Value != null)
                        cbo_producto.SelectedValue = row.Cells["fk_id_producto"].Value;

                    if (!string.IsNullOrEmpty(cbo_proceso.ValueMember) && row.Cells["fk_id_proceso"].Value != null)
                        cbo_proceso.SelectedValue = row.Cells["fk_id_proceso"].Value;

                    if (row.Cells["fecha_explosion"].Value != null)
                        dtp_fecha.Value = Convert.ToDateTime(row.Cells["fecha_explosion"].Value);
                    //btn_Actualizar.Enabled = true;
                    btn_guardar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un registro para consultar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Consultar: " + ex.Message);
            }
        }

        //----------------------------------AQUI COMIENZA LA IMPLOSION-------------------------------//

        private void Btn_ingresar_implo_Click(object sender, EventArgs e)
        {
            txt_id_implosion.Text = controlador.ObtenerUltimoIDImplo().ToString();
            txt_id_implosion.Enabled = false;
            txt_id_implosion.Text = controlador.ObtenerUltimoIDImplo().ToString();
            LimpiarCamposImplo();
            Btn_guardar_implo.Enabled = true;
        }

        private void CargarImplosion()
        {
            dgv_implosion.DataSource = controlador.ObtenerTodosLosRegistrosImplo();
        }

        private void CargarComboBoxesImplo()
        {
            // Llenar cbo_orden
            cbo_orden_implosion.DataSource = controlador.ObtenerOrdenesProduccionImplo();
            cbo_orden_implosion.DisplayMember = "Pk_id_orden";
            //cbo_orden.ValueMember = "Pk_id_orden";

            // Llenar cbo_producto con el Dictionary<int, string>
            var productosDict = controlador.ObtenerProductosImplo();
            cbo_producto_final.DataSource = new BindingSource(productosDict, null);
            cbo_producto_final.DisplayMember = "Value"; // El nombre del producto
            cbo_producto_final.ValueMember = "Key";     // El ID del producto

            // Llenar cbo_proceso
            cbo_proceso_implo.DataSource = controlador.ObtenerProcesosProduccionImplo();
            cbo_proceso_implo.DisplayMember = "Pk_id_proceso";
            //cbo_proceso.ValueMember = "Pk_id_proceso";
        }

        private void LimpiarCamposImplo()
        {
            txt_componente.Clear();
            txt_cantidad_com.Clear();
            txt_costo_com.Clear();
            txt_duracion_implo.Clear();
            txt_componente.Clear();
            Btn_guardar_implo.Enabled = true;

        }

        private void Btn_guardar_implo_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar y convertir los valores de los campos
                if (!int.TryParse(cbo_orden_implosion.SelectedValue?.ToString(), out int fkOrden))
                {
                    MessageBox.Show("Por favor, ingresa valores a los campos.");
                    return;
                }
                if (!int.TryParse(cbo_producto_final.SelectedValue?.ToString(), out int fkProducto))
                {
                    MessageBox.Show("Por favor, ingresa valores a los campos.");
                    return;
                }
            
                if (!int.TryParse(txt_cantidad_com.Text, out int cantidadcom))
                {
                    MessageBox.Show("Por favor, ingresa valores a los campos.");
                    return;
                }

                if (!int.TryParse(txt_costo_com.Text, out int costocom))
                {
                    MessageBox.Show("Por favor, ingresa valores a los campos.");
                    return;
                }

                if (!int.TryParse(txt_duracion_implo.Text, out int duracion))
                {
                    MessageBox.Show("Por favor, ingresa valores a los campos.");
                    return;
                }
                if (!int.TryParse(cbo_proceso_implo.SelectedValue?.ToString(), out int fkProceso))
                {
                    MessageBox.Show("Por favor, ingresa valores a los campos.");
                    return;
                }

                string componente = txt_componente.Text;
                DateTime fechaImplosion = dtp_fecha_implo.Value; // Obtener la fecha seleccionada

                // Llamar al método para guardar la receta
                controlador.GuardarImplosion(fkOrden, fkProducto, componente, cantidadcom, costocom, duracion, fkProceso, fechaImplosion);
                // Mensaje de éxito
                MessageBox.Show("La Implosion se guardó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresca el DataGridView y limpia los campos
                CargarImplosion();
                LimpiarCamposImplo();

                Btn_guardar_implo.Enabled = false;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, asegúrate de que todos los campos numéricos estén correctamente ingresados: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar la Implosion: " + ex.Message);
            }
        }

        private void Btn_consultar_implo_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que un registro esté seleccionado en el DataGridView
                if (dgv_implosion.SelectedRows.Count > 0)
                {
                    var row = dgv_implosion.SelectedRows[0];

                    txt_id_implosion.Text = row.Cells["Pk_id_implosion"].Value.ToString();
                    txt_componente.Text = row.Cells["id_componente"].Value.ToString();
                    txt_cantidad_com.Text = row.Cells["cantidad_componente"].Value.ToString();
                    txt_costo_com.Text = row.Cells["costo_componente"].Value.ToString();
                    txt_duracion_implo.Text = row.Cells["duracion_horas"].Value.ToString();

                    if (!string.IsNullOrEmpty(cbo_orden.ValueMember) && row.Cells["fk_id_orden"].Value != null)
                        cbo_orden.SelectedValue = row.Cells["fk_id_orden"].Value;

                    if (!string.IsNullOrEmpty(cbo_producto.ValueMember) && row.Cells["fk_id_producto_final"].Value != null)
                        cbo_producto.SelectedValue = row.Cells["fk_id_producto_final"].Value;

                    if (!string.IsNullOrEmpty(cbo_proceso.ValueMember) && row.Cells["fk_id_proceso_final"].Value != null)
                        cbo_proceso.SelectedValue = row.Cells["fk_id_proceso"].Value;

                    if (row.Cells["fecha_implosion"].Value != null)
                        dtp_fecha.Value = Convert.ToDateTime(row.Cells["fecha_implosion"].Value);
                    //btn_Actualizar.Enabled = true;
                    Btn_guardar_implo.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un registro para consultar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Consultar: " + ex.Message);
            }
        }

        private void Btn_modificar_implo_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que se haya seleccionado un registro en el DataGridView
                if (dgv_implosion.CurrentRow != null)
                {
                    // Obtiene el ID del registro seleccionado
                    int IdImplosion = Convert.ToInt32(dgv_implosion.CurrentRow.Cells["pk_id_implosion"].Value);

                    if (!int.TryParse(cbo_orden_implosion.SelectedValue?.ToString(), out int fkOrden))
                    {
                        MessageBox.Show("Por favor, seleccione los campos a modificar.");
                        return;
                    }
                    if (!int.TryParse(cbo_producto_final.SelectedValue?.ToString(), out int fkProducto))
                    {
                        MessageBox.Show("Por favor, seleccione los campos a modificar.");
                        return;
                    }

                    if (!int.TryParse(txt_cantidad_com.Text, out int cantidadcom))
                    {
                        MessageBox.Show("Por favor, seleccione los campos a modificar.");
                        return;
                    }

                    if (!int.TryParse(txt_costo_com.Text, out int costocom))
                    {
                        MessageBox.Show("Por favor, seleccione los campos a modificar.");
                        return;
                    }

                    if (!int.TryParse(txt_duracion_implo.Text, out int duracion))
                    {
                        MessageBox.Show("Por favor, seleccione los campos a modificar.");
                        return;
                    }
                    if (!int.TryParse(cbo_proceso_implo.SelectedValue?.ToString(), out int fkProceso))
                    {
                        MessageBox.Show("Por favor, seleccione los campos a modificar.");
                        return;
                    }

                    string componente = txt_componente.Text;
                    DateTime fechaImplosion = dtp_fecha_implo.Value; // Obtener la fecha seleccionada

                    // Llamar al método para guardar la receta
                    controlador.ModificarImplosion(IdImplosion, fkOrden, fkProducto, componente, cantidadcom, costocom, duracion, fkProceso, fechaImplosion);

                    CargarImplosion();
                    LimpiarCamposImplo();
                    // Muestra un mensaje indicando que la actualización fue exitosa
                    MessageBox.Show("La Implosion se Modifico y se Actulizo correctamente.");
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún registro.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en el formato de los datos ingresados. Verifique e intente nuevamente.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Algunos campos necesarios no están seleccionados o están vacíos.", "Error de Referencia Nula", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar actualizar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string sRutaProyectoAyuda { get; private set; } = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\"));
        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                //Ruta para que se ejecute desde la ejecucion de Interfac3
                string sAyudaPath = Path.Combine(sRutaProyectoAyuda, "Ayuda", "Modulos", "Produccion", "Ayuda Explo Implo", "AyudaExploImplo.chm");
                //string sIndiceAyuda = Path.Combine(sRutaProyecto, "EstadosFinancieros", "ReportesEstados", "Htmlayuda.hmtl");
                //MessageBox.Show("Ruta del reporte: " + sAyudaPath, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Help.ShowHelp(this, sAyudaPath, "AyudaExploImplo.html");


            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de una excepción
                MessageBox.Show("Ocurrió un error al abrir la ayuda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error al abrir la ayuda: " + ex.ToString());
            }
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {
            Reporte exploimplo = new Reporte();
            exploimplo.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgv_explosion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_Explo_Implo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Proceso_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Producto_Final_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Componente_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Proceso_imp_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Fecha_Implosión_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Compoonentes_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Costo_Componentes_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Duración_Horas_Implo_Click(object sender, EventArgs e)
        {

        }

        private void txt_cantidad_com_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_costo_com_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_duracion_implo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtp_fecha_implo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgv_implosion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_id_implosion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_componente_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbo_proceso_implo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_producto_final_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_orden_implosion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_duracion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
