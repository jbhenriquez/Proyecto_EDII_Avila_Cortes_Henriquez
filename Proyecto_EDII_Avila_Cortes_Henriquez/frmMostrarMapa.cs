using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    public partial class frmMostrarMapa : Form
    {
        public frmMostrarMapa()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmMostrarMapa_Load(object sender, EventArgs e)
        {
            dgvMapa.Rows.Clear();

            foreach (var origen in Global.Ciudad.ObtenerGrafo())
            {
                foreach (var arista in origen.Value)
                {
                    dgvMapa.Rows.Add(
                        origen.Key,
                        arista.Destino,
                        arista.Peso
                    );
                }
            }
        }
    }

}
