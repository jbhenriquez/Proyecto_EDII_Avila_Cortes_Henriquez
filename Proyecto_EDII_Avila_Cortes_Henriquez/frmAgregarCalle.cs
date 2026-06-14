using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    public partial class frmAgregarCalle : Form
    {
        public frmAgregarCalle()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string origen = tbxOrigen.Text;
                string destino = tbxDestino.Text;
                int tiempo = int.Parse(tbxTiempo.Text);
                Global.Ciudad.AgregarCalle(origen, destino, tiempo);
                MessageBox.Show("Calle agregada exitosamente.");
                LimpiarCampos();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido para el tiempo.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            tbxOrigen.Clear();
            tbxDestino.Clear();
            tbxTiempo.Clear();
        }
    }
}
