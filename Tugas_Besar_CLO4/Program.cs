using System.Globalization;

namespace Tugas_Besar_CLO4
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
//<<<<<<< HEAD
            Application.Run(new Form1());
//=======
            Application.Run(
                new Forms.Customer.FilterJadwalForms()
            );
//>>>>>>> origin
        }
    }
}