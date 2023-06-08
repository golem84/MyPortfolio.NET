using static System.IO.Directory;
using static System.IO.Path;
using static System.Console;

namespace ConsoleApp
{
    internal class Program
    {
        
        
        static void Main()
        {
            // Проверяем наличие файла БД в каталоге с приложением
            var currentpath = GetCurrentDirectory();
            var dbfilename = Combine(currentpath, "CarOwnership.db");

            if (!File.Exists(dbfilename))
            {
                WriteLine("Database file doesn't exist. Creating...");
                // создание файла БД из CSV
                WriteLine("Done!");
            }
                
                
                

            

        }
    }
}