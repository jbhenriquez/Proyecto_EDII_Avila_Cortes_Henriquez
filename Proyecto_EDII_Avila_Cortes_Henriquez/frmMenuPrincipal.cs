namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregarCalle_Click(object sender, EventArgs e)
        {
            frmAgregarCalle AgregarCalle = new frmAgregarCalle();
            AgregarCalle.ShowDialog();
        }

        private void btnTraficoMax_Click(object sender, EventArgs e)
        {
            frmTraficoMax TraficoMaximo = new frmTraficoMax();
            TraficoMaximo.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMostrarMapa_Click(object sender, EventArgs e)
        {
            frmMostrarMapa MostrarMapa = new frmMostrarMapa();
            MostrarMapa.ShowDialog();
        }

        private void btnRutaRapida_Click(object sender, EventArgs e)
        {
            frmRutaRapida RutaRapida = new frmRutaRapida();
            RutaRapida.ShowDialog();
        }

        private void btnActualizarTrafico_Click(object sender, EventArgs e)
        {
            frmActualizarTrafico ActualizarTrafico = new frmActualizarTrafico();
            ActualizarTrafico.ShowDialog();
        }

        private void btnRegistrarIncidente_Click(object sender, EventArgs e)
        {
            frmRegistrarIncidente RegistrarIncidente = new frmRegistrarIncidente();
            RegistrarIncidente.ShowDialog();
        }

        private void btnAtenderIncidente_Click(object sender, EventArgs e)
        {
            frmAtenderIncidente AtenderIncidente = new frmAtenderIncidente();
            AtenderIncidente.ShowDialog();
        }
    }
}
