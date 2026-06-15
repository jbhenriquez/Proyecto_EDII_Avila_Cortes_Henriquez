using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    public partial class frmAtenderIncidente : Form
    {
        public frmAtenderIncidente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {

            Incidente inc = Global.Incidentes.ExtraerMax();
            if (inc == null)
            {
                MessageBox.Show("No hay incidentes pendientes");
                return;
            }
            MessageBox.Show("Atendiendo el siguiente incidente: " + inc);
            tbxIncidente.Text = inc.ToString();
            //Opcional agregar cola o lista para mantener registro de incidentes.
        }
    }
}
