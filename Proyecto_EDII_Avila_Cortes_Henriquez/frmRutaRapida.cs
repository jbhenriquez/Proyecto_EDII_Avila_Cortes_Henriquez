using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    public partial class frmRutaRapida : Form
    {
        public frmRutaRapida()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            cbxOrigen.SelectedIndex = -1;
            cbxDestino.SelectedIndex = -1;
            lblMinutos.Text = "***";
            lbxRuta.Items.Clear();
        }
    }
}
