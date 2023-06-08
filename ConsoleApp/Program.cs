using static System.IO.Directory;
using static System.IO.Path;
using static System.Console;
using DataLayer.EfClasses;
using DataLayer.EfCode;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace ConsoleApp
{
    internal class Program
    {
        

        static void AddCar(SQLiteDbContext db)
        {
            var car = new Car();
            car.CarId = 1;
            car.ManufactureDate = new DateOnly(2019, 01, 11);
            car.Price = 780000;
            car.PurchaseDate = new DateOnly(2019, 07, 31);
            car.BrandName = "Lada";
            car.Model = "Vesta седан 1.8";
            db.Cars.Add(car);
        }


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
                db.Database.Migrate();
                // + Console.WriteLine($"Database {db.Database.GetConnectionString()} created!");
                Console.WriteLine("Что добавить в БД? 1 - владелец; 2 - машина; любая кнопка - продолжить.");
                int otvet = Convert.ToInt32(Console.ReadLine());
                switch (otvet)
                {
                    case 1:
                        var user = new Owner();
                        user.OwnerId = 1;
                        user.OwnerName = "Андрей";
                        db.Owners.Add(user);
                        db.SaveChanges();
                        //Console.WriteLine("Owner added:");
                        Console.WriteLine($"Owner '{user.OwnerName}' added успешно.");
                        break;
                    case 2:
                        var car = new Car();
                        car.CarId = 1;
                        car.ManufactureDate = new DateOnly(2019, 01, 11);
                        car.Price = 780000;
                        car.PurchaseDate = new DateOnly(2019, 07, 31);
                        car.BrandName = "Lada";
                        car.Model = "Vesta седан 1.8";
                        db.Cars.Add(car);
                        db.SaveChanges();
                        //Console.WriteLine("Car added:");
                        Console.WriteLine($"Car '{car.BrandName} - {car.Model}' added успешно.");

                        break;
                    default: 
                        break;
                }
                
            }
                

            

        }
    }
}