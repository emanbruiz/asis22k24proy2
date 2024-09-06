﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Consulta;
using System.Data.Odbc;
using System.Data;

namespace Capa_Vista_Consulta
{
    public partial class ConsultaInteligente : Form
    {
        consultaControlador csControlador = new consultaControlador();
        string tablabusqueda;
        public ConsultaInteligente()
        {
            InitializeComponent();
            string BD = "colchoneria";

            // DESCOMENTAR CUANDO CAPA CONTROLADOR Y MÓDULO SE HAYAN TERMINADO

            //csControlador.CargarTablas(cboTabla, BD);
            //csControlador.CargarTablas(cboEditarTabla, BD);
            gbCondiciones.Enabled = false;
            gbOrdenar.Enabled = false;
            gbListadoConsultas.Enabled = false;
            gbEditarLogica.Enabled = false;
            gbEditarOrden.Enabled = false;
        }
        string consulta = "";
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //boton agregar, consulta simple
            string[] datos = { txtNombreConsulta.Text, chbTodosCampos.Text, txtQueryFinal.Text };
            string[] tipos = { "nombre_consulta", "tipo_consulta", "consulta_SQLE", "consulta_estatus" };
            csControlador.ingresar(tipos, datos, "tbl_consultaInteligente");
          
            txtQuery.Text = (txtNombreConsulta.Text + "+" + chbTodosCampos.Text + "+" + txtQueryFinal.Text + "+" + "1" + "+");
            string columnasbd = cboCampos.Text;
        }

        private void ConsultaInteligente_Load(object sender, EventArgs e)
        {

        }

        private void creciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void chbEditarDescendente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEditarLogico_Click(object sender, EventArgs e)
        {

        }
    }
}
