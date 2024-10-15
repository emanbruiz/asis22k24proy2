using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_Produccion;

namespace Ejecucion_Produccion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Capa_Vista_Produccion.Frm_Receta receta = new Capa_Vista_Produccion.Frm_Receta(); // Creación de una nueva instancia del formulario
            receta.Show(); // Llamada al método Show() en la instancia creada
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Capa_Vista_Produccion.Frm_Mantenimiento_Produccion manteimiento = new Capa_Vista_Produccion.Frm_Mantenimiento_Produccion();
            manteimiento.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Capa_Vista_Produccion.Frm_Implosion_Explosion_Materiales ie = new Capa_Vista_Produccion.Frm_Implosion_Explosion_Materiales();
            ie.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Capa_Vista_Produccion.Frm_Sistema_Produccion sp = new Capa_Vista_Produccion.Frm_Sistema_Produccion();
            sp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Capa_Vista_Produccion.Frm_Ordenes_De_Produccion op = new Capa_Vista_Produccion.Frm_Ordenes_De_Produccion();
            op.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Capa_Vista_Produccion.Frm_Enlace_RRHH rrhh = new Capa_Vista_Produccion.Frm_Enlace_RRHH();
            rrhh.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Capa_Vista_Produccion.Frm_Enlace_Contabilidad_Cierre ec = new Capa_Vista_Produccion.Frm_Enlace_Contabilidad_Cierre();
            ec.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Capa_Vista_Produccion.Frm_Cierre cierre = new Capa_Vista_Produccion.Frm_Cierre();
            cierre.Show();
        }
    }
}
