using C_GUI.QLForm;
using C_GUI.Views;

namespace C_GUI
{
    internal static class Program
    {
        public static Login Login = new();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormKhachHang());

        }
    }
}