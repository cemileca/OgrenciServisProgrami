using Microsoft.Extensions.Hosting;
using OgrenciServis.Persistence;
using OgrenciServis.WinForm.Forms;

namespace OgrenciServis.WinForm
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
            var hosbuilder =  Host.CreateDefaultBuilder();
            hosbuilder.ConfigureServices(services => services.AddPersistenceService());
            hosbuilder.Build().RunAsync();

            Application.Run(new AdresKayitFrm());
        }
    }
}