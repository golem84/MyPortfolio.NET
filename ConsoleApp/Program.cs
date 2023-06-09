using static System.IO.Directory;
using static System.IO.Path;
using static System.Console;
using DataLayer.EfClasses;
using DataLayer.EfCode;
using System.Reflection.Emit;

namespace ConsoleApp
{
    internal class Program
    {
        
        static void Main()
        {
            // Проверяем наличие файла БД в каталоге с приложением
            /*
            var currentpath = GetCurrentDirectory();
            var dbfilename = Combine(currentpath, "CarOwnership.db");

            if (!File.Exists(dbfilename))
            {
                WriteLine("Database file doesn't exist. Creating...");
                // создание файла БД из CSV
                WriteLine("Done!");
            }
            */    
            
            using (var db = new SQLiteDbContext())
            {
                db.Database.EnsureCreated();
                // + Console.WriteLine($"Database {db.Database.GetConnectionString()} created!");
                Console.Write("Добавить данные в БД? 1 - да, 0 - нет: ");
                int otvet = Convert.ToInt32(Console.ReadLine());
                switch (otvet)
                {
                    case 1:
                        var user = new Owner();
                        user.OwnerId = 1;
                        user.OwnerName = "Андрей";
                        user.Cars = new List<Car>();

                        var car = new Car();
                        car.CarId = 1;
                        car.ManufactureDate = new DateOnly(2019, 01, 11);
                        car.Price = 780000;
                        car.PurchaseDate = new DateOnly(2019, 07, 31);
                        car.BrandName = "Lada";
                        car.Model = "Vesta седан 1.8";
                        
                        user.Cars.Add(car);

                        db.Owners.Add(user);
                        db.Cars.Add(car);
                        db.SaveChanges();
                        //Console.WriteLine("Owner added:");
                        Console.WriteLine($"Owner '{user.OwnerName}' added успешно.");
                        Console.WriteLine($"Car '{car.BrandName} {car.Model}' added success." );
                        break;
        
                    case 0: 
                        break;
                }
                
            }
                

            

        }
    }
}