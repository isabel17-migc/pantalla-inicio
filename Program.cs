namespace pantalla_inicio
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

            
            var conexion = new conexion();
            conexion.CrearBaseSiNoExiste();
            Application.Run(new Inicio());











            Application.Run(new Inicio());



        }
    }

}