using _3LArchitecture.Repository;
using _3LArchitecture.Service;

namespace _3LArchitectureInterface
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
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BookService bookService = new(new BookRepository());
            SportsEquipmentService sportsEquipmentService = new(new SportsEquipmentRepository());
            ToyService toyService = new(new ToyRepository());
            

            Application.Run(new Form1(bookService, sportsEquipmentService, toyService));
        }
    }
}