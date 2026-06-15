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
            this.Load += frmRutaRapida_Load;
            btnConsultar.Click += btnConsultar_Click;
        }
        private void frmRutaRapida_Load(object sender, EventArgs e)
        {
            cbxOrigen.Items.Clear();
            cbxDestino.Items.Clear();

            foreach (var nodo in Global.Ciudad.ObtenerGrafo().Keys)
            {
                cbxOrigen.Items.Add(nodo);
                cbxDestino.Items.Add(nodo);
            }
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lbxRuta.Items.Clear();
            if (cbxOrigen.SelectedItem == null ||
                cbxDestino.SelectedItem == null)
            {
                MessageBox.Show("Seleccione origen y destino");
                return;
            }

            string origen = cbxOrigen.SelectedItem.ToString();
            string destino = cbxDestino.SelectedItem.ToString();

            int minutos = Global.Ciudad.Dijkstra(origen, destino);
            var lugaresVisitados = Global.Ciudad.ObtenerConexiones(origen);
            if (minutos == int.MaxValue)
            {
                lblMinutos.Text = "INF";
                MessageBox.Show("No hay ruta disponible entre " + origen + " y " + destino);
                return;
            }

            lblMinutos.Text = minutos.ToString();

            //Se debe identificar los lugares visitados
            //SE PODRIA UTILIZAR 2 CBX PARA DEFINIR RUTA
            lbxRuta.Items.Clear();
            foreach (var lugar in lugaresVisitados)
            {
                lbxRuta.Items.Add(lugar);
            }
        }
    }
}
