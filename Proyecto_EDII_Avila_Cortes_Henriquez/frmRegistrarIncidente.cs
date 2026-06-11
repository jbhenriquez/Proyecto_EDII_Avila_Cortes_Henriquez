using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    public partial class frmRegistrarIncidente : Form
    {
        public frmRegistrarIncidente()
        {
            InitializeComponent();
            btnGuardar.Click += btnGuardar_Click;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxDescripcion.Text))
            {
                MessageBox.Show("Ingrese una descripcion");
                return;
            }

            int prioridad = 1;
            if (rbtMedio.Checked)
                prioridad = 2;
            if (rbtAlto.Checked)
                prioridad = 3;

            Incidente incidente = new Incidente(
                tbxDescripcion.Text,
                DateTime.Now,
                "No especificada",
                prioridad
            );

            Global.Incidentes.Insertar(incidente);

            MessageBox.Show("Incidente registrado");

            LimpiarCampos();
        }

        public void LimpiarCampos()
        {
            tbxDescripcion.Clear();
            rbtBajo.Checked = false;
            rbtMedio.Checked = false;
            rbtAlto.Checked = false;
        }
    }
}
