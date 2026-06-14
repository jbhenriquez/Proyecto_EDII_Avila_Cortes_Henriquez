using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    public partial class frmActualizarTrafico : Form
    {
        public frmActualizarTrafico()
        {
            InitializeComponent();
            this.Load += frmActualizarTrafico_Load; // Agrega el evento Load para cargar los nodos en los ComboBox al abrir el formulario
        }

        public void frmActualizarTrafico_Load(object sender, EventArgs e)
        {
            if (Global.GrafoCargado)
            {
                cbxOrigen.Items.Clear();
                cbxDestino.Items.Clear();
                foreach (var nodo in Global.Ciudad.ObtenerGrafo().Keys)
                {
                    cbxOrigen.Items.Add(nodo);
                    cbxDestino.Items.Add(nodo);
                }
            }
            else
            {
                MessageBox.Show("Por favor, cargue el grafo antes de intentar actualizar el tráfico.");
                this.Close();
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
            tbxUltimo.Text = "";
            tbxActual.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxOrigen.SelectedIndex != -1 && cbxDestino.SelectedIndex != -1)
                {
                    string origen = cbxOrigen.SelectedItem.ToString();
                    string destino = cbxDestino.SelectedItem.ToString();
                    //int ultimoTrafico = tbxUltimo.Text == "" ? 0 : int.Parse(tbxUltimo.Text);
                    int nuevoTrafico = tbxActual.Text == "" ? 0 : int.Parse(tbxActual.Text);
                    if (origen == destino)
                    {
                        MessageBox.Show("El origen y el destino no pueden ser el mismo.");
                        return;
                    }
                    if (nuevoTrafico <= 0)
                    {
                        MessageBox.Show("El tiempo de tráfico debe ser un número positivo.");
                        return;
                    }

                    Global.Ciudad.ModificarCalle(origen, destino, nuevoTrafico);
                    MessageBox.Show("Tráfico actualizado exitosamente entre " + origen + " y " + destino + ".");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un origen y un destino.");
                    return;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido para el tiempo de tráfico.");
                return;
            }
            // Si todo es válido, se actualiza el tráfico en el grafo         

        }

        private void cbxOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Asigna peso de arista a tbxUltimo al seleccionar un destino

            if (cbxOrigen.SelectedIndex != -1) // Verifica que se haya seleccionado un origen
                tbxUltimo.Text = 
                    Global.Ciudad.MostrarPesoCalle(cbxOrigen.SelectedItem.ToString(), cbxDestino.SelectedItem.ToString(), out int peso).ToString();
                    
        }
    }
}
