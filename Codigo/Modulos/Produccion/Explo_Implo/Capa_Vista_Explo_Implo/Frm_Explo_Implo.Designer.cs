
namespace Capa_Vista_Explo_Implo
{
    partial class Frm_Explo_Implo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Explo_Implo));
            this.Lbl_ID_Explosión = new System.Windows.Forms.Label();
            this.Lbl_Orden_exp = new System.Windows.Forms.Label();
            this.Lbl_Producto = new System.Windows.Forms.Label();
            this.Lbl_Cantidad = new System.Windows.Forms.Label();
            this.Lbl_Costo_Total = new System.Windows.Forms.Label();
            this.Lbl_Duración_Horas = new System.Windows.Forms.Label();
            this.Lbl_Proceso = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.dgv_explosion = new System.Windows.Forms.DataGridView();
            this.txt_id_explosion = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_costo_total = new System.Windows.Forms.TextBox();
            this.txt_duracion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cbo_orden = new System.Windows.Forms.ComboBox();
            this.cbo_producto = new System.Windows.Forms.ComboBox();
            this.cbo_proceso = new System.Windows.Forms.ComboBox();
            this.Lbl_ID_Implosión = new System.Windows.Forms.Label();
            this.Lbl_Orden_Imp = new System.Windows.Forms.Label();
            this.Lbl_Producto_Final = new System.Windows.Forms.Label();
            this.Lbl_Componente = new System.Windows.Forms.Label();
            this.Lbl_Compoonentes = new System.Windows.Forms.Label();
            this.Lbl_Costo_Componentes = new System.Windows.Forms.Label();
            this.Lbl_Duración_Horas_Implo = new System.Windows.Forms.Label();
            this.Lbl_Fecha_Implosión = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_id_implosion = new System.Windows.Forms.TextBox();
            this.cbo_orden_implosion = new System.Windows.Forms.ComboBox();
            this.cbo_producto_final = new System.Windows.Forms.ComboBox();
            this.txt_cantidad_com = new System.Windows.Forms.TextBox();
            this.txt_costo_com = new System.Windows.Forms.TextBox();
            this.txt_duracion_implo = new System.Windows.Forms.TextBox();
            this.dtp_fecha_implo = new System.Windows.Forms.DateTimePicker();
            this.dgv_implosion = new System.Windows.Forms.DataGridView();
            this.Lbl_Fecha_Explosión = new System.Windows.Forms.Label();
            this.Lbl_Proceso_imp = new System.Windows.Forms.Label();
            this.cbo_proceso_implo = new System.Windows.Forms.ComboBox();
            this.txt_componente = new System.Windows.Forms.TextBox();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Ayuda = new System.Windows.Forms.Button();
            this.Btn_modificar_implo = new System.Windows.Forms.Button();
            this.Btn_consultar_implo = new System.Windows.Forms.Button();
            this.Btn_ingresar_implo = new System.Windows.Forms.Button();
            this.Btn_guardar_implo = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_ingresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_implosion)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_ID_Explosión
            // 
            this.Lbl_ID_Explosión.AutoSize = true;
            this.Lbl_ID_Explosión.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ID_Explosión.Location = new System.Drawing.Point(33, 180);
            this.Lbl_ID_Explosión.Name = "Lbl_ID_Explosión";
            this.Lbl_ID_Explosión.Size = new System.Drawing.Size(84, 17);
            this.Lbl_ID_Explosión.TabIndex = 5;
            this.Lbl_ID_Explosión.Text = "ID Explosion";
            this.Lbl_ID_Explosión.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_Orden_exp
            // 
            this.Lbl_Orden_exp.AutoSize = true;
            this.Lbl_Orden_exp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Orden_exp.Location = new System.Drawing.Point(72, 221);
            this.Lbl_Orden_exp.Name = "Lbl_Orden_exp";
            this.Lbl_Orden_exp.Size = new System.Drawing.Size(45, 17);
            this.Lbl_Orden_exp.TabIndex = 6;
            this.Lbl_Orden_exp.Text = "Orden";
            this.Lbl_Orden_exp.Click += new System.EventHandler(this.label2_Click);
            // 
            // Lbl_Producto
            // 
            this.Lbl_Producto.AutoSize = true;
            this.Lbl_Producto.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Producto.Location = new System.Drawing.Point(52, 274);
            this.Lbl_Producto.Name = "Lbl_Producto";
            this.Lbl_Producto.Size = new System.Drawing.Size(65, 17);
            this.Lbl_Producto.TabIndex = 7;
            this.Lbl_Producto.Text = "Producto ";
            this.Lbl_Producto.Click += new System.EventHandler(this.label3_Click);
            // 
            // Lbl_Cantidad
            // 
            this.Lbl_Cantidad.AutoSize = true;
            this.Lbl_Cantidad.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cantidad.Location = new System.Drawing.Point(57, 322);
            this.Lbl_Cantidad.Name = "Lbl_Cantidad";
            this.Lbl_Cantidad.Size = new System.Drawing.Size(60, 17);
            this.Lbl_Cantidad.TabIndex = 8;
            this.Lbl_Cantidad.Text = "Cantidad";
            // 
            // Lbl_Costo_Total
            // 
            this.Lbl_Costo_Total.AutoSize = true;
            this.Lbl_Costo_Total.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Costo_Total.Location = new System.Drawing.Point(335, 178);
            this.Lbl_Costo_Total.Name = "Lbl_Costo_Total";
            this.Lbl_Costo_Total.Size = new System.Drawing.Size(75, 17);
            this.Lbl_Costo_Total.TabIndex = 9;
            this.Lbl_Costo_Total.Text = "Costo Total";
            // 
            // Lbl_Duración_Horas
            // 
            this.Lbl_Duración_Horas.AutoSize = true;
            this.Lbl_Duración_Horas.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Duración_Horas.Location = new System.Drawing.Point(308, 218);
            this.Lbl_Duración_Horas.Name = "Lbl_Duración_Horas";
            this.Lbl_Duración_Horas.Size = new System.Drawing.Size(102, 17);
            this.Lbl_Duración_Horas.TabIndex = 10;
            this.Lbl_Duración_Horas.Text = "Duración Horas";
            // 
            // Lbl_Proceso
            // 
            this.Lbl_Proceso.AutoSize = true;
            this.Lbl_Proceso.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Proceso.Location = new System.Drawing.Point(354, 267);
            this.Lbl_Proceso.Name = "Lbl_Proceso";
            this.Lbl_Proceso.Size = new System.Drawing.Size(56, 17);
            this.Lbl_Proceso.TabIndex = 11;
            this.Lbl_Proceso.Text = "Proceso";
            this.Lbl_Proceso.Click += new System.EventHandler(this.Lbl_Proceso_Click);
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.CustomFormat = "yyyy-MM-dd";
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha.Location = new System.Drawing.Point(447, 322);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(127, 20);
            this.dtp_fecha.TabIndex = 12;
            // 
            // dgv_explosion
            // 
            this.dgv_explosion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_explosion.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_explosion.Location = new System.Drawing.Point(32, 370);
            this.dgv_explosion.Name = "dgv_explosion";
            this.dgv_explosion.RowHeadersWidth = 51;
            this.dgv_explosion.Size = new System.Drawing.Size(538, 226);
            this.dgv_explosion.TabIndex = 13;
            this.dgv_explosion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_explosion_CellContentClick);
            // 
            // txt_id_explosion
            // 
            this.txt_id_explosion.Location = new System.Drawing.Point(139, 180);
            this.txt_id_explosion.Name = "txt_id_explosion";
            this.txt_id_explosion.Size = new System.Drawing.Size(134, 20);
            this.txt_id_explosion.TabIndex = 14;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_cantidad.Location = new System.Drawing.Point(139, 322);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(134, 20);
            this.txt_cantidad.TabIndex = 17;
            // 
            // txt_costo_total
            // 
            this.txt_costo_total.Location = new System.Drawing.Point(447, 175);
            this.txt_costo_total.Name = "txt_costo_total";
            this.txt_costo_total.Size = new System.Drawing.Size(127, 20);
            this.txt_costo_total.TabIndex = 18;
            // 
            // txt_duracion
            // 
            this.txt_duracion.Location = new System.Drawing.Point(447, 220);
            this.txt_duracion.Name = "txt_duracion";
            this.txt_duracion.Size = new System.Drawing.Size(127, 20);
            this.txt_duracion.TabIndex = 19;
            this.txt_duracion.TextChanged += new System.EventHandler(this.txt_duracion_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(243, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Explosión";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cbo_orden
            // 
            this.cbo_orden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_orden.FormattingEnabled = true;
            this.cbo_orden.Location = new System.Drawing.Point(139, 221);
            this.cbo_orden.Name = "cbo_orden";
            this.cbo_orden.Size = new System.Drawing.Size(134, 21);
            this.cbo_orden.TabIndex = 22;
            // 
            // cbo_producto
            // 
            this.cbo_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_producto.FormattingEnabled = true;
            this.cbo_producto.Location = new System.Drawing.Point(139, 274);
            this.cbo_producto.Name = "cbo_producto";
            this.cbo_producto.Size = new System.Drawing.Size(134, 21);
            this.cbo_producto.TabIndex = 23;
            // 
            // cbo_proceso
            // 
            this.cbo_proceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_proceso.FormattingEnabled = true;
            this.cbo_proceso.Location = new System.Drawing.Point(447, 274);
            this.cbo_proceso.Name = "cbo_proceso";
            this.cbo_proceso.Size = new System.Drawing.Size(127, 21);
            this.cbo_proceso.TabIndex = 24;
            // 
            // Lbl_ID_Implosión
            // 
            this.Lbl_ID_Implosión.AutoSize = true;
            this.Lbl_ID_Implosión.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ID_Implosión.Location = new System.Drawing.Point(670, 180);
            this.Lbl_ID_Implosión.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ID_Implosión.Name = "Lbl_ID_Implosión";
            this.Lbl_ID_Implosión.Size = new System.Drawing.Size(84, 17);
            this.Lbl_ID_Implosión.TabIndex = 29;
            this.Lbl_ID_Implosión.Text = "ID Implosión";
            // 
            // Lbl_Orden_Imp
            // 
            this.Lbl_Orden_Imp.AutoSize = true;
            this.Lbl_Orden_Imp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Orden_Imp.Location = new System.Drawing.Point(709, 218);
            this.Lbl_Orden_Imp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Orden_Imp.Name = "Lbl_Orden_Imp";
            this.Lbl_Orden_Imp.Size = new System.Drawing.Size(45, 17);
            this.Lbl_Orden_Imp.TabIndex = 30;
            this.Lbl_Orden_Imp.Text = "Orden";
            // 
            // Lbl_Producto_Final
            // 
            this.Lbl_Producto_Final.AutoSize = true;
            this.Lbl_Producto_Final.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Producto_Final.Location = new System.Drawing.Point(661, 249);
            this.Lbl_Producto_Final.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Producto_Final.Name = "Lbl_Producto_Final";
            this.Lbl_Producto_Final.Size = new System.Drawing.Size(93, 17);
            this.Lbl_Producto_Final.TabIndex = 31;
            this.Lbl_Producto_Final.Text = "Producto Final";
            this.Lbl_Producto_Final.Click += new System.EventHandler(this.Lbl_Producto_Final_Click);
            // 
            // Lbl_Componente
            // 
            this.Lbl_Componente.AutoSize = true;
            this.Lbl_Componente.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Componente.Location = new System.Drawing.Point(672, 291);
            this.Lbl_Componente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Componente.Name = "Lbl_Componente";
            this.Lbl_Componente.Size = new System.Drawing.Size(82, 17);
            this.Lbl_Componente.TabIndex = 32;
            this.Lbl_Componente.Text = "Componente";
            this.Lbl_Componente.Click += new System.EventHandler(this.Lbl_Componente_Click);
            // 
            // Lbl_Compoonentes
            // 
            this.Lbl_Compoonentes.AutoSize = true;
            this.Lbl_Compoonentes.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Compoonentes.Location = new System.Drawing.Point(936, 183);
            this.Lbl_Compoonentes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Compoonentes.Name = "Lbl_Compoonentes";
            this.Lbl_Compoonentes.Size = new System.Drawing.Size(144, 17);
            this.Lbl_Compoonentes.TabIndex = 33;
            this.Lbl_Compoonentes.Text = "Cantidad Componentes";
            this.Lbl_Compoonentes.Click += new System.EventHandler(this.Lbl_Compoonentes_Click);
            // 
            // Lbl_Costo_Componentes
            // 
            this.Lbl_Costo_Componentes.AutoSize = true;
            this.Lbl_Costo_Componentes.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Costo_Componentes.Location = new System.Drawing.Point(954, 225);
            this.Lbl_Costo_Componentes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Costo_Componentes.Name = "Lbl_Costo_Componentes";
            this.Lbl_Costo_Componentes.Size = new System.Drawing.Size(126, 17);
            this.Lbl_Costo_Componentes.TabIndex = 34;
            this.Lbl_Costo_Componentes.Text = "Costo Componentes";
            this.Lbl_Costo_Componentes.Click += new System.EventHandler(this.Lbl_Costo_Componentes_Click);
            // 
            // Lbl_Duración_Horas_Implo
            // 
            this.Lbl_Duración_Horas_Implo.AutoSize = true;
            this.Lbl_Duración_Horas_Implo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Duración_Horas_Implo.Location = new System.Drawing.Point(978, 267);
            this.Lbl_Duración_Horas_Implo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Duración_Horas_Implo.Name = "Lbl_Duración_Horas_Implo";
            this.Lbl_Duración_Horas_Implo.Size = new System.Drawing.Size(102, 17);
            this.Lbl_Duración_Horas_Implo.TabIndex = 35;
            this.Lbl_Duración_Horas_Implo.Text = "Duracion Horas";
            this.Lbl_Duración_Horas_Implo.Click += new System.EventHandler(this.Lbl_Duración_Horas_Implo_Click);
            // 
            // Lbl_Fecha_Implosión
            // 
            this.Lbl_Fecha_Implosión.AutoSize = true;
            this.Lbl_Fecha_Implosión.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Implosión.Location = new System.Drawing.Point(976, 320);
            this.Lbl_Fecha_Implosión.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Fecha_Implosión.Name = "Lbl_Fecha_Implosión";
            this.Lbl_Fecha_Implosión.Size = new System.Drawing.Size(104, 17);
            this.Lbl_Fecha_Implosión.TabIndex = 36;
            this.Lbl_Fecha_Implosión.Text = "Fecha Implosion";
            this.Lbl_Fecha_Implosión.Click += new System.EventHandler(this.Lbl_Fecha_Implosión_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(920, 20);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 21);
            this.label17.TabIndex = 37;
            this.label17.Text = "Implosión";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // txt_id_implosion
            // 
            this.txt_id_implosion.Location = new System.Drawing.Point(781, 180);
            this.txt_id_implosion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_id_implosion.Name = "txt_id_implosion";
            this.txt_id_implosion.Size = new System.Drawing.Size(133, 20);
            this.txt_id_implosion.TabIndex = 38;
            this.txt_id_implosion.TextChanged += new System.EventHandler(this.txt_id_implosion_TextChanged);
            // 
            // cbo_orden_implosion
            // 
            this.cbo_orden_implosion.FormattingEnabled = true;
            this.cbo_orden_implosion.Location = new System.Drawing.Point(781, 214);
            this.cbo_orden_implosion.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_orden_implosion.Name = "cbo_orden_implosion";
            this.cbo_orden_implosion.Size = new System.Drawing.Size(133, 21);
            this.cbo_orden_implosion.TabIndex = 39;
            this.cbo_orden_implosion.SelectedIndexChanged += new System.EventHandler(this.cbo_orden_implosion_SelectedIndexChanged);
            // 
            // cbo_producto_final
            // 
            this.cbo_producto_final.FormattingEnabled = true;
            this.cbo_producto_final.Location = new System.Drawing.Point(781, 245);
            this.cbo_producto_final.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_producto_final.Name = "cbo_producto_final";
            this.cbo_producto_final.Size = new System.Drawing.Size(133, 21);
            this.cbo_producto_final.TabIndex = 40;
            this.cbo_producto_final.SelectedIndexChanged += new System.EventHandler(this.cbo_producto_final_SelectedIndexChanged);
            // 
            // txt_cantidad_com
            // 
            this.txt_cantidad_com.Location = new System.Drawing.Point(1100, 177);
            this.txt_cantidad_com.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cantidad_com.Name = "txt_cantidad_com";
            this.txt_cantidad_com.Size = new System.Drawing.Size(131, 20);
            this.txt_cantidad_com.TabIndex = 42;
            this.txt_cantidad_com.TextChanged += new System.EventHandler(this.txt_cantidad_com_TextChanged);
            // 
            // txt_costo_com
            // 
            this.txt_costo_com.Location = new System.Drawing.Point(1100, 225);
            this.txt_costo_com.Margin = new System.Windows.Forms.Padding(2);
            this.txt_costo_com.Name = "txt_costo_com";
            this.txt_costo_com.Size = new System.Drawing.Size(131, 20);
            this.txt_costo_com.TabIndex = 43;
            this.txt_costo_com.TextChanged += new System.EventHandler(this.txt_costo_com_TextChanged);
            // 
            // txt_duracion_implo
            // 
            this.txt_duracion_implo.Location = new System.Drawing.Point(1100, 266);
            this.txt_duracion_implo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_duracion_implo.Name = "txt_duracion_implo";
            this.txt_duracion_implo.Size = new System.Drawing.Size(131, 20);
            this.txt_duracion_implo.TabIndex = 44;
            this.txt_duracion_implo.TextChanged += new System.EventHandler(this.txt_duracion_implo_TextChanged);
            // 
            // dtp_fecha_implo
            // 
            this.dtp_fecha_implo.CustomFormat = "yyyy-MM-dd";
            this.dtp_fecha_implo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_implo.Location = new System.Drawing.Point(1100, 316);
            this.dtp_fecha_implo.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_fecha_implo.Name = "dtp_fecha_implo";
            this.dtp_fecha_implo.Size = new System.Drawing.Size(131, 20);
            this.dtp_fecha_implo.TabIndex = 45;
            this.dtp_fecha_implo.ValueChanged += new System.EventHandler(this.dtp_fecha_implo_ValueChanged);
            // 
            // dgv_implosion
            // 
            this.dgv_implosion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_implosion.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_implosion.Location = new System.Drawing.Point(660, 370);
            this.dgv_implosion.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_implosion.Name = "dgv_implosion";
            this.dgv_implosion.RowHeadersWidth = 51;
            this.dgv_implosion.RowTemplate.Height = 24;
            this.dgv_implosion.Size = new System.Drawing.Size(571, 233);
            this.dgv_implosion.TabIndex = 46;
            this.dgv_implosion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_implosion_CellContentClick);
            // 
            // Lbl_Fecha_Explosión
            // 
            this.Lbl_Fecha_Explosión.AutoSize = true;
            this.Lbl_Fecha_Explosión.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha_Explosión.Location = new System.Drawing.Point(306, 320);
            this.Lbl_Fecha_Explosión.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Fecha_Explosión.Name = "Lbl_Fecha_Explosión";
            this.Lbl_Fecha_Explosión.Size = new System.Drawing.Size(104, 17);
            this.Lbl_Fecha_Explosión.TabIndex = 47;
            this.Lbl_Fecha_Explosión.Text = "Fecha Explosión";
            // 
            // Lbl_Proceso_imp
            // 
            this.Lbl_Proceso_imp.AutoSize = true;
            this.Lbl_Proceso_imp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Proceso_imp.Location = new System.Drawing.Point(698, 326);
            this.Lbl_Proceso_imp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Proceso_imp.Name = "Lbl_Proceso_imp";
            this.Lbl_Proceso_imp.Size = new System.Drawing.Size(56, 17);
            this.Lbl_Proceso_imp.TabIndex = 48;
            this.Lbl_Proceso_imp.Text = "Proceso";
            this.Lbl_Proceso_imp.Click += new System.EventHandler(this.Lbl_Proceso_imp_Click);
            // 
            // cbo_proceso_implo
            // 
            this.cbo_proceso_implo.FormattingEnabled = true;
            this.cbo_proceso_implo.Location = new System.Drawing.Point(781, 322);
            this.cbo_proceso_implo.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_proceso_implo.Name = "cbo_proceso_implo";
            this.cbo_proceso_implo.Size = new System.Drawing.Size(133, 21);
            this.cbo_proceso_implo.TabIndex = 49;
            this.cbo_proceso_implo.SelectedIndexChanged += new System.EventHandler(this.cbo_proceso_implo_SelectedIndexChanged);
            // 
            // txt_componente
            // 
            this.txt_componente.Location = new System.Drawing.Point(781, 288);
            this.txt_componente.Margin = new System.Windows.Forms.Padding(2);
            this.txt_componente.Name = "txt_componente";
            this.txt_componente.Size = new System.Drawing.Size(133, 20);
            this.txt_componente.TabIndex = 50;
            this.txt_componente.TextChanged += new System.EventHandler(this.txt_componente_TextChanged);
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackgroundImage = global::Capa_Vista_Explo_Implo.Properties.Resources.cerca;
            this.Btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_salir.Location = new System.Drawing.Point(1171, 628);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(60, 60);
            this.Btn_salir.TabIndex = 53;
            this.Btn_salir.UseVisualStyleBackColor = true;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.BackgroundImage = global::Capa_Vista_Explo_Implo.Properties.Resources.concepto;
            this.Btn_Reporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Reporte.Location = new System.Drawing.Point(944, 626);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(64, 62);
            this.Btn_Reporte.TabIndex = 52;
            this.Btn_Reporte.UseVisualStyleBackColor = true;
            this.Btn_Reporte.Click += new System.EventHandler(this.Btn_Reporte_Click);
            // 
            // Btn_Ayuda
            // 
            this.Btn_Ayuda.BackgroundImage = global::Capa_Vista_Explo_Implo.Properties.Resources.pregunta__3_;
            this.Btn_Ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Ayuda.Location = new System.Drawing.Point(1167, 12);
            this.Btn_Ayuda.Name = "Btn_Ayuda";
            this.Btn_Ayuda.Size = new System.Drawing.Size(64, 62);
            this.Btn_Ayuda.TabIndex = 51;
            this.Btn_Ayuda.UseVisualStyleBackColor = true;
            this.Btn_Ayuda.Click += new System.EventHandler(this.Btn_Ayuda_Click);
            // 
            // Btn_modificar_implo
            // 
            this.Btn_modificar_implo.BackgroundImage = global::Capa_Vista_Explo_Implo.Properties.Resources.convenio_2;
            this.Btn_modificar_implo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_modificar_implo.Location = new System.Drawing.Point(1062, 73);
            this.Btn_modificar_implo.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_modificar_implo.Name = "Btn_modificar_implo";
            this.Btn_modificar_implo.Size = new System.Drawing.Size(56, 66);
            this.Btn_modificar_implo.TabIndex = 28;
            this.Btn_modificar_implo.UseVisualStyleBackColor = true;
            this.Btn_modificar_implo.Click += new System.EventHandler(this.Btn_modificar_implo_Click);
            // 
            // Btn_consultar_implo
            // 
            this.Btn_consultar_implo.BackgroundImage = global::Capa_Vista_Explo_Implo.Properties.Resources.buscar_2;
            this.Btn_consultar_implo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_consultar_implo.Location = new System.Drawing.Point(977, 72);
            this.Btn_consultar_implo.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_consultar_implo.Name = "Btn_consultar_implo";
            this.Btn_consultar_implo.Size = new System.Drawing.Size(61, 67);
            this.Btn_consultar_implo.TabIndex = 27;
            this.Btn_consultar_implo.UseVisualStyleBackColor = true;
            this.Btn_consultar_implo.Click += new System.EventHandler(this.Btn_consultar_implo_Click);
            // 
            // Btn_ingresar_implo
            // 
            this.Btn_ingresar_implo.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ingresar_implo.BackgroundImage = global::Capa_Vista_Explo_Implo.Properties.Resources.portapapeles__1_;
            this.Btn_ingresar_implo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_ingresar_implo.FlatAppearance.BorderColor = System.Drawing.SystemColors.InfoText;
            this.Btn_ingresar_implo.FlatAppearance.BorderSize = 0;
            this.Btn_ingresar_implo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ingresar_implo.Location = new System.Drawing.Point(799, 73);
            this.Btn_ingresar_implo.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ingresar_implo.Name = "Btn_ingresar_implo";
            this.Btn_ingresar_implo.Size = new System.Drawing.Size(73, 68);
            this.Btn_ingresar_implo.TabIndex = 26;
            this.Btn_ingresar_implo.UseVisualStyleBackColor = false;
            this.Btn_ingresar_implo.Click += new System.EventHandler(this.Btn_ingresar_implo_Click);
            // 
            // Btn_guardar_implo
            // 
            this.Btn_guardar_implo.BackgroundImage = global::Capa_Vista_Explo_Implo.Properties.Resources.ahorrar;
            this.Btn_guardar_implo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_guardar_implo.Location = new System.Drawing.Point(887, 72);
            this.Btn_guardar_implo.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_guardar_implo.Name = "Btn_guardar_implo";
            this.Btn_guardar_implo.Size = new System.Drawing.Size(62, 68);
            this.Btn_guardar_implo.TabIndex = 25;
            this.Btn_guardar_implo.UseVisualStyleBackColor = true;
            this.Btn_guardar_implo.Click += new System.EventHandler(this.Btn_guardar_implo_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackgroundImage = global::Capa_Vista_Explo_Implo.Properties.Resources.buscar_2;
            this.btn_consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_consultar.Location = new System.Drawing.Point(305, 71);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(64, 66);
            this.btn_consultar.TabIndex = 3;
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackgroundImage = global::Capa_Vista_Explo_Implo.Properties.Resources.convenio_2;
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_modificar.Location = new System.Drawing.Point(393, 72);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(58, 66);
            this.btn_modificar.TabIndex = 2;
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::Capa_Vista_Explo_Implo.Properties.Resources.ahorrar;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_guardar.Location = new System.Drawing.Point(217, 71);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(68, 66);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackgroundImage = global::Capa_Vista_Explo_Implo.Properties.Resources.portapapeles__1_;
            this.btn_ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ingresar.Location = new System.Drawing.Point(135, 71);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(60, 66);
            this.btn_ingresar.TabIndex = 0;
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // Frm_Explo_Implo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1272, 700);
            this.Controls.Add(this.dgv_implosion);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Ayuda);
            this.Controls.Add(this.txt_componente);
            this.Controls.Add(this.cbo_proceso_implo);
            this.Controls.Add(this.Lbl_Proceso_imp);
            this.Controls.Add(this.Lbl_Fecha_Explosión);
            this.Controls.Add(this.dtp_fecha_implo);
            this.Controls.Add(this.txt_duracion_implo);
            this.Controls.Add(this.txt_costo_com);
            this.Controls.Add(this.txt_cantidad_com);
            this.Controls.Add(this.cbo_producto_final);
            this.Controls.Add(this.cbo_orden_implosion);
            this.Controls.Add(this.txt_id_implosion);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Lbl_Fecha_Implosión);
            this.Controls.Add(this.Lbl_Duración_Horas_Implo);
            this.Controls.Add(this.Lbl_Costo_Componentes);
            this.Controls.Add(this.Lbl_Compoonentes);
            this.Controls.Add(this.Lbl_Componente);
            this.Controls.Add(this.Lbl_Producto_Final);
            this.Controls.Add(this.Lbl_Orden_Imp);
            this.Controls.Add(this.Lbl_ID_Implosión);
            this.Controls.Add(this.Btn_modificar_implo);
            this.Controls.Add(this.Btn_consultar_implo);
            this.Controls.Add(this.Btn_ingresar_implo);
            this.Controls.Add(this.Btn_guardar_implo);
            this.Controls.Add(this.cbo_proceso);
            this.Controls.Add(this.cbo_producto);
            this.Controls.Add(this.cbo_orden);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_duracion);
            this.Controls.Add(this.txt_costo_total);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_id_explosion);
            this.Controls.Add(this.dgv_explosion);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.Lbl_Proceso);
            this.Controls.Add(this.Lbl_Duración_Horas);
            this.Controls.Add(this.Lbl_Costo_Total);
            this.Controls.Add(this.Lbl_Cantidad);
            this.Controls.Add(this.Lbl_Producto);
            this.Controls.Add(this.Lbl_Orden_exp);
            this.Controls.Add(this.Lbl_ID_Explosión);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_ingresar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Explo_Implo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explosión y Implosión de Materiales";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Frm_Explo_Implo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_implosion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Label Lbl_ID_Explosión;
        private System.Windows.Forms.Label Lbl_Orden_exp;
        private System.Windows.Forms.Label Lbl_Producto;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.Label Lbl_Costo_Total;
        private System.Windows.Forms.Label Lbl_Duración_Horas;
        private System.Windows.Forms.Label Lbl_Proceso;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.DataGridView dgv_explosion;
        private System.Windows.Forms.TextBox txt_id_explosion;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_costo_total;
        private System.Windows.Forms.TextBox txt_duracion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cbo_orden;
        private System.Windows.Forms.ComboBox cbo_producto;
        private System.Windows.Forms.ComboBox cbo_proceso;
        private System.Windows.Forms.Button Btn_guardar_implo;
        private System.Windows.Forms.Button Btn_ingresar_implo;
        private System.Windows.Forms.Button Btn_consultar_implo;
        private System.Windows.Forms.Button Btn_modificar_implo;
        private System.Windows.Forms.Label Lbl_ID_Implosión;
        private System.Windows.Forms.Label Lbl_Orden_Imp;
        private System.Windows.Forms.Label Lbl_Producto_Final;
        private System.Windows.Forms.Label Lbl_Componente;
        private System.Windows.Forms.Label Lbl_Compoonentes;
        private System.Windows.Forms.Label Lbl_Costo_Componentes;
        private System.Windows.Forms.Label Lbl_Duración_Horas_Implo;
        private System.Windows.Forms.Label Lbl_Fecha_Implosión;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_id_implosion;
        private System.Windows.Forms.ComboBox cbo_orden_implosion;
        private System.Windows.Forms.ComboBox cbo_producto_final;
        private System.Windows.Forms.TextBox txt_cantidad_com;
        private System.Windows.Forms.TextBox txt_costo_com;
        private System.Windows.Forms.TextBox txt_duracion_implo;
        private System.Windows.Forms.DateTimePicker dtp_fecha_implo;
        private System.Windows.Forms.DataGridView dgv_implosion;
        private System.Windows.Forms.Label Lbl_Fecha_Explosión;
        private System.Windows.Forms.Label Lbl_Proceso_imp;
        private System.Windows.Forms.ComboBox cbo_proceso_implo;
        private System.Windows.Forms.TextBox txt_componente;
        private System.Windows.Forms.Button Btn_Ayuda;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Button Btn_salir;
    }
}