using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    public partial class frmTraficoMax : Form
    {
        public frmTraficoMax()
        {
            InitializeComponent();
            dgvTrafMax.Rows.Clear();

            int cantidadAMostrar = 6; // Número de calles con mayor tráfico a mostrar

            //CAMBIAR PARA USAR CON SEGMENT TREE

            /******* IMPLEMENTACION TEMPORAL PARA PRUEBAS ****/

            // Obtener todas las aristas del grafo, ordenarlas por peso (tráfico) y tomar las top 
            var aristasPesadas = Global.Ciudad.ObtenerGrafo()
                .SelectMany(origen => origen.Value.Select(arista => new { Origen = origen.Key, Destino = arista.Destino, Peso = arista.Peso }))
                .OrderByDescending(a => a.Peso)
                .Take(cantidadAMostrar);

            // Cargar trafico en el datagridview
            foreach (var arista in aristasPesadas)
            {
                dgvTrafMax.Rows.Add(
                    arista.Origen,
                    arista.Destino,
                    arista.Peso
                );
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
