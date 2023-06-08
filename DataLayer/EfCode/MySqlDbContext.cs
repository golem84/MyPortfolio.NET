using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataLayer.EfClasses;

namespace DataLayer.EfCode
{
    public class MySqlDbContext: DbContext
    {
        public DbSet<Owner> Owners {get;set;}
        public DbSet<Car> Cars { get;set;}
        public DbSet<MileAge> MileAges { get;set;}
        public DbSet<Event> Events { get; set; }

        // настройка подключения к БД
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string conn = "server=racknerd;user=andrew;password=MyPass@1;database=usersdb;";
            string conn = "server=localhost;user=root;password=root;database=usersdb;";
            optionsBuilder.UseMySQL(conn);
            //Console.WriteLine("Database created successfully.");
        }
    }
}