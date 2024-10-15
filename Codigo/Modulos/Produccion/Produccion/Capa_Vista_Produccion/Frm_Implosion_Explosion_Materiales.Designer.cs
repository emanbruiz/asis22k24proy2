
namespace Capa_Vista_Produccion
{
    partial class Frm_Implosion_Explosion_Materiales
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
            this.Btn_agregar_material = new System.Windows.Forms.Button();
            this.Btn_modificar_material = new System.Windows.Forms.Button();
            this.Btn_eliminar_material = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_implosion_material = new System.Windows.Forms.Button();
            this.Btn_explosion_material = new System.Windows.Forms.Button();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.Txt_id_material = new System.Windows.Forms.TextBox();
            this.Txt_nombre_material = new System.Windows.Forms.TextBox();
            this.Txt_cantidad_material = new System.Windows.Forms.TextBox();
            this.Txt_costo_material = new System.Windows.Forms.TextBox();
            this.Lbl_id_material = new System.Windows.Forms.Label();
            this.Lbl_nombre_material = new System.Windows.Forms.Label();
            this.Lbl_cantidad_material = new System.Windows.Forms.Label();
            this.Lbl_descripcion_material = new System.Windows.Forms.Label();
            this.Lbl_costo_material = new System.Windows.Forms.Label();
            this.Txt_descripcion_material = new System.Windows.Forms.RichTextBox();
            this.Dgv_Calculos = new System.Windows.Forms.DataGridView();
            this.Dgv_implosion = new System.Windows.Forms.DataGridView();
            this.Dgv_explosion = new System.Windows.Forms.DataGridView();
            this.Dtp_fecha_implosion = new System.Windows.Forms.DateTimePicker();
            this.Lbl_fecha_implosion = new System.Windows.Forms.Label();
            this.Lbl_fecha_explosion = new System.Windows.Forms.Label();
            this.Dtp_fecha_explosion = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Cbo_tipo_material = new System.Windows.Forms.Label();
            this.Txt_cantidad_material_por_producto = new System.Windows.Forms.TextBox();
            this.Txt_stock_material = new System.Windows.Forms.TextBox();
            this.Lbl_cantidad_material_por_producto = new System.Windows.Forms.Label();
            this.Lbl_stock_material = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Calculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_implosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_explosion)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_agregar_material
            // 
            this.Btn_agregar_material.Location = new System.Drawing.Point(15, 94);
            this.Btn_agregar_material.Name = "Btn_agregar_material";
            this.Btn_agregar_material.Size = new System.Drawing.Size(94, 45);
            this.Btn_agregar_material.TabIndex = 0;
            this.Btn_agregar_material.Text = "Agregar Material";
            this.Btn_agregar_material.UseVisualStyleBackColor = true;
            // 
            // Btn_modificar_material
            // 
            this.Btn_modificar_material.Location = new System.Drawing.Point(148, 94);
            this.Btn_modificar_material.Name = "Btn_modificar_material";
            this.Btn_modificar_material.Size = new System.Drawing.Size(94, 45);
            this.Btn_modificar_material.TabIndex = 1;
            this.Btn_modificar_material.Text = "Modificar Material";
            this.Btn_modificar_material.UseVisualStyleBackColor = true;
            // 
            // Btn_eliminar_material
            // 
            this.Btn_eliminar_material.Location = new System.Drawing.Point(297, 94);
            this.Btn_eliminar_material.Name = "Btn_eliminar_material";
            this.Btn_eliminar_material.Size = new System.Drawing.Size(94, 45);
            this.Btn_eliminar_material.TabIndex = 2;
            this.Btn_eliminar_material.Text = "Eliminar Material";
            this.Btn_eliminar_material.UseVisualStyleBackColor = true;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(711, 94);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(94, 45);
            this.Btn_guardar.TabIndex = 3;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            // 
            // Btn_implosion_material
            // 
            this.Btn_implosion_material.Location = new System.Drawing.Point(427, 94);
            this.Btn_implosion_material.Name = "Btn_implosion_material";
            this.Btn_implosion_material.Size = new System.Drawing.Size(94, 45);
            this.Btn_implosion_material.TabIndex = 3;
            this.Btn_implosion_material.Text = "Implosión de Material";
            this.Btn_implosion_material.UseVisualStyleBackColor = true;
            this.Btn_implosion_material.Click += new System.EventHandler(this.Btn_implosion_material_Click_1);
            // 
            // Btn_explosion_material
            // 
            this.Btn_explosion_material.Location = new System.Drawing.Point(562, 94);
            this.Btn_explosion_material.Name = "Btn_explosion_material";
            this.Btn_explosion_material.Size = new System.Drawing.Size(94, 45);
            this.Btn_explosion_material.TabIndex = 4;
            this.Btn_explosion_material.Text = "Explosión de Material";
            this.Btn_explosion_material.UseVisualStyleBackColor = true;
            this.Btn_explosion_material.Click += new System.EventHandler(this.Btn_explosion_material_Click_1);
            // 
            // Btn_salir
            // 
            this.Btn_salir.Location = new System.Drawing.Point(844, 94);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(94, 45);
            this.Btn_salir.TabIndex = 5;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(367, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(289, 21);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Implosión y Explosión de Materiales";
            // 
            // Txt_id_material
            // 
            this.Txt_id_material.Location = new System.Drawing.Point(197, 192);
            this.Txt_id_material.Name = "Txt_id_material";
            this.Txt_id_material.Size = new System.Drawing.Size(122, 22);
            this.Txt_id_material.TabIndex = 7;
            // 
            // Txt_nombre_material
            // 
            this.Txt_nombre_material.Location = new System.Drawing.Point(197, 220);
            this.Txt_nombre_material.Name = "Txt_nombre_material";
            this.Txt_nombre_material.Size = new System.Drawing.Size(122, 22);
            this.Txt_nombre_material.TabIndex = 8;
            // 
            // Txt_cantidad_material
            // 
            this.Txt_cantidad_material.Location = new System.Drawing.Point(197, 248);
            this.Txt_cantidad_material.Name = "Txt_cantidad_material";
            this.Txt_cantidad_material.Size = new System.Drawing.Size(122, 22);
            this.Txt_cantidad_material.TabIndex = 9;
            // 
            // Txt_costo_material
            // 
            this.Txt_costo_material.Location = new System.Drawing.Point(197, 380);
            this.Txt_costo_material.Name = "Txt_costo_material";
            this.Txt_costo_material.Size = new System.Drawing.Size(122, 22);
            this.Txt_costo_material.TabIndex = 11;
            // 
            // Lbl_id_material
            // 
            this.Lbl_id_material.AutoSize = true;
            this.Lbl_id_material.Location = new System.Drawing.Point(12, 192);
            this.Lbl_id_material.Name = "Lbl_id_material";
            this.Lbl_id_material.Size = new System.Drawing.Size(26, 21);
            this.Lbl_id_material.TabIndex = 12;
            this.Lbl_id_material.Text = "ID";
            // 
            // Lbl_nombre_material
            // 
            this.Lbl_nombre_material.AutoSize = true;
            this.Lbl_nombre_material.Location = new System.Drawing.Point(12, 220);
            this.Lbl_nombre_material.Name = "Lbl_nombre_material";
            this.Lbl_nombre_material.Size = new System.Drawing.Size(165, 21);
            this.Lbl_nombre_material.TabIndex = 13;
            this.Lbl_nombre_material.Text = "Nombre de Material";
            // 
            // Lbl_cantidad_material
            // 
            this.Lbl_cantidad_material.AutoSize = true;
            this.Lbl_cantidad_material.Location = new System.Drawing.Point(12, 248);
            this.Lbl_cantidad_material.Name = "Lbl_cantidad_material";
            this.Lbl_cantidad_material.Size = new System.Drawing.Size(80, 21);
            this.Lbl_cantidad_material.TabIndex = 14;
            this.Lbl_cantidad_material.Text = "Cantidad";
            // 
            // Lbl_descripcion_material
            // 
            this.Lbl_descripcion_material.AutoSize = true;
            this.Lbl_descripcion_material.Location = new System.Drawing.Point(12, 276);
            this.Lbl_descripcion_material.Name = "Lbl_descripcion_material";
            this.Lbl_descripcion_material.Size = new System.Drawing.Size(82, 17);
            this.Lbl_descripcion_material.TabIndex = 15;
            this.Lbl_descripcion_material.Text = "Descripcion";
            // 
            // Lbl_costo_material
            // 
            this.Lbl_costo_material.AutoSize = true;
            this.Lbl_costo_material.Location = new System.Drawing.Point(12, 385);
            this.Lbl_costo_material.Name = "Lbl_costo_material";
            this.Lbl_costo_material.Size = new System.Drawing.Size(148, 21);
            this.Lbl_costo_material.TabIndex = 16;
            this.Lbl_costo_material.Text = "Costo de Material";
            // 
            // Txt_descripcion_material
            // 
            this.Txt_descripcion_material.Location = new System.Drawing.Point(197, 276);
            this.Txt_descripcion_material.Name = "Txt_descripcion_material";
            this.Txt_descripcion_material.Size = new System.Drawing.Size(122, 96);
            this.Txt_descripcion_material.TabIndex = 17;
            this.Txt_descripcion_material.Text = "";
            // 
            // Dgv_Calculos
            // 
            this.Dgv_Calculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Calculos.Location = new System.Drawing.Point(15, 409);
            this.Dgv_Calculos.Name = "Dgv_Calculos";
            this.Dgv_Calculos.RowHeadersWidth = 51;
            this.Dgv_Calculos.RowTemplate.Height = 24;
            this.Dgv_Calculos.Size = new System.Drawing.Size(304, 150);
            this.Dgv_Calculos.TabIndex = 18;
            // 
            // Dgv_implosion
            // 
            this.Dgv_implosion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_implosion.Location = new System.Drawing.Point(325, 409);
            this.Dgv_implosion.Name = "Dgv_implosion";
            this.Dgv_implosion.RowHeadersWidth = 51;
            this.Dgv_implosion.RowTemplate.Height = 24;
            this.Dgv_implosion.Size = new System.Drawing.Size(304, 150);
            this.Dgv_implosion.TabIndex = 19;
            // 
            // Dgv_explosion
            // 
            this.Dgv_explosion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_explosion.Location = new System.Drawing.Point(635, 409);
            this.Dgv_explosion.Name = "Dgv_explosion";
            this.Dgv_explosion.RowHeadersWidth = 51;
            this.Dgv_explosion.RowTemplate.Height = 24;
            this.Dgv_explosion.Size = new System.Drawing.Size(304, 150);
            this.Dgv_explosion.TabIndex = 20;
            // 
            // Dtp_fecha_implosion
            // 
            this.Dtp_fecha_implosion.Location = new System.Drawing.Point(639, 220);
            this.Dtp_fecha_implosion.Name = "Dtp_fecha_implosion";
            this.Dtp_fecha_implosion.Size = new System.Drawing.Size(200, 22);
            this.Dtp_fecha_implosion.TabIndex = 21;
            // 
            // Lbl_fecha_implosion
            // 
            this.Lbl_fecha_implosion.AutoSize = true;
            this.Lbl_fecha_implosion.Location = new System.Drawing.Point(353, 220);
            this.Lbl_fecha_implosion.Name = "Lbl_fecha_implosion";
            this.Lbl_fecha_implosion.Size = new System.Drawing.Size(130, 17);
            this.Lbl_fecha_implosion.TabIndex = 22;
            this.Lbl_fecha_implosion.Text = "Fecha de Implosión";
            // 
            // Lbl_fecha_explosion
            // 
            this.Lbl_fecha_explosion.AutoSize = true;
            this.Lbl_fecha_explosion.Location = new System.Drawing.Point(353, 251);
            this.Lbl_fecha_explosion.Name = "Lbl_fecha_explosion";
            this.Lbl_fecha_explosion.Size = new System.Drawing.Size(131, 17);
            this.Lbl_fecha_explosion.TabIndex = 23;
            this.Lbl_fecha_explosion.Text = "Fecha de Explosión";
            // 
            // Dtp_fecha_explosion
            // 
            this.Dtp_fecha_explosion.Location = new System.Drawing.Point(639, 251);
            this.Dtp_fecha_explosion.Name = "Dtp_fecha_explosion";
            this.Dtp_fecha_explosion.Size = new System.Drawing.Size(200, 22);
            this.Dtp_fecha_explosion.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(639, 192);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 24);
            this.comboBox1.TabIndex = 25;
            // 
            // Cbo_tipo_material
            // 
            this.Cbo_tipo_material.AutoSize = true;
            this.Cbo_tipo_material.Location = new System.Drawing.Point(353, 192);
            this.Cbo_tipo_material.Name = "Cbo_tipo_material";
            this.Cbo_tipo_material.Size = new System.Drawing.Size(138, 21);
            this.Cbo_tipo_material.TabIndex = 26;
            this.Cbo_tipo_material.Text = "Tipo de material";
            // 
            // Txt_cantidad_material_por_producto
            // 
            this.Txt_cantidad_material_por_producto.Location = new System.Drawing.Point(639, 279);
            this.Txt_cantidad_material_por_producto.Name = "Txt_cantidad_material_por_producto";
            this.Txt_cantidad_material_por_producto.Size = new System.Drawing.Size(200, 22);
            this.Txt_cantidad_material_por_producto.TabIndex = 27;
            // 
            // Txt_stock_material
            // 
            this.Txt_stock_material.Location = new System.Drawing.Point(639, 307);
            this.Txt_stock_material.Name = "Txt_stock_material";
            this.Txt_stock_material.Size = new System.Drawing.Size(200, 22);
            this.Txt_stock_material.TabIndex = 28;
            // 
            // Lbl_cantidad_material_por_producto
            // 
            this.Lbl_cantidad_material_por_producto.AutoSize = true;
            this.Lbl_cantidad_material_por_producto.Location = new System.Drawing.Point(353, 279);
            this.Lbl_cantidad_material_por_producto.Name = "Lbl_cantidad_material_por_producto";
            this.Lbl_cantidad_material_por_producto.Size = new System.Drawing.Size(279, 21);
            this.Lbl_cantidad_material_por_producto.TabIndex = 29;
            this.Lbl_cantidad_material_por_producto.Text = "Cantidad de material por producto";
            // 
            // Lbl_stock_material
            // 
            this.Lbl_stock_material.AutoSize = true;
            this.Lbl_stock_material.Location = new System.Drawing.Point(353, 307);
            this.Lbl_stock_material.Name = "Lbl_stock_material";
            this.Lbl_stock_material.Size = new System.Drawing.Size(54, 21);
            this.Lbl_stock_material.TabIndex = 30;
            this.Lbl_stock_material.Text = "Stock";
            // 
            // Frm_Implosion_Explosion_Materiales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 566);
            this.Controls.Add(this.Lbl_stock_material);
            this.Controls.Add(this.Lbl_cantidad_material_por_producto);
            this.Controls.Add(this.Txt_stock_material);
            this.Controls.Add(this.Txt_cantidad_material_por_producto);
            this.Controls.Add(this.Cbo_tipo_material);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Dtp_fecha_explosion);
            this.Controls.Add(this.Lbl_fecha_explosion);
            this.Controls.Add(this.Lbl_fecha_implosion);
            this.Controls.Add(this.Dtp_fecha_implosion);
            this.Controls.Add(this.Dgv_explosion);
            this.Controls.Add(this.Dgv_implosion);
            this.Controls.Add(this.Dgv_Calculos);
            this.Controls.Add(this.Txt_descripcion_material);
            this.Controls.Add(this.Lbl_costo_material);
            this.Controls.Add(this.Lbl_descripcion_material);
            this.Controls.Add(this.Lbl_cantidad_material);
            this.Controls.Add(this.Lbl_nombre_material);
            this.Controls.Add(this.Lbl_id_material);
            this.Controls.Add(this.Txt_costo_material);
            this.Controls.Add(this.Txt_cantidad_material);
            this.Controls.Add(this.Txt_nombre_material);
            this.Controls.Add(this.Txt_id_material);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_explosion_material);
            this.Controls.Add(this.Btn_implosion_material);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_eliminar_material);
            this.Controls.Add(this.Btn_modificar_material);
            this.Controls.Add(this.Btn_agregar_material);
            this.Name = "Frm_Implosion_Explosion_Materiales";
            this.Text = "Frm_Implosion_Explosion_Materiales";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Calculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_implosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_explosion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_agregar_material;
        private System.Windows.Forms.Button Btn_modificar_material;
        private System.Windows.Forms.Button Btn_eliminar_material;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_implosion_material;
        private System.Windows.Forms.Button Btn_explosion_material;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox Txt_id_material;
        private System.Windows.Forms.TextBox Txt_nombre_material;
        private System.Windows.Forms.TextBox Txt_cantidad_material;
        private System.Windows.Forms.TextBox Txt_costo_material;
        private System.Windows.Forms.Label Lbl_id_material;
        private System.Windows.Forms.Label Lbl_nombre_material;
        private System.Windows.Forms.Label Lbl_cantidad_material;
        private System.Windows.Forms.Label Lbl_descripcion_material;
        private System.Windows.Forms.Label Lbl_costo_material;
        private System.Windows.Forms.RichTextBox Txt_descripcion_material;
        private System.Windows.Forms.DataGridView Dgv_Calculos;
        private System.Windows.Forms.DataGridView Dgv_implosion;
        private System.Windows.Forms.DataGridView Dgv_explosion;
        private System.Windows.Forms.DateTimePicker Dtp_fecha_implosion;
        private System.Windows.Forms.Label Lbl_fecha_implosion;
        private System.Windows.Forms.Label Lbl_fecha_explosion;
        private System.Windows.Forms.DateTimePicker Dtp_fecha_explosion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Cbo_tipo_material;
        private System.Windows.Forms.TextBox Txt_cantidad_material_por_producto;
        private System.Windows.Forms.TextBox Txt_stock_material;
        private System.Windows.Forms.Label Lbl_cantidad_material_por_producto;
        private System.Windows.Forms.Label Lbl_stock_material;
    }
}