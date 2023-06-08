using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataLayer.EfClasses;

namespace DataLayer.EfCode
{
    public class AppDbContext: DbContext
    {
        public DbSet<Owner> Owners {get;set;}

        // настройка подключения к БД
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = System.IO.Path.Combine(System.Environment.CurrentDirectory, "CarOwnership.db");
            optionsBuilder.UseSqlite($"Filename={path}");
        }
    }
}