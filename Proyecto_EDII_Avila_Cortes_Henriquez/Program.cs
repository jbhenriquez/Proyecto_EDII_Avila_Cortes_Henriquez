namespace Proyecto_EDII_Avila_Cortes_Henriquez
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMenuPrincipal());

            Grafo ciudad = new Grafo();
            ciudad.AgregarCalle("Centro Historico", "soyapango", 15);
            ciudad.AgregarCalle("Centro Historico", "Santa Tecla", 12);
            ciudad.AgregarCalle("soyapango", "Ilopango", 10);
            ciudad.AgregarCalle("Santa Tecla", "Apopa", 20);
            ciudad.AgregarCalle("Apopa", "Ilopango", 8);

            int[] trafico = { 20, 80, 50, 90, 40 };
            
        }
    }
}