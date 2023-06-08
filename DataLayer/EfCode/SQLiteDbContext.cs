using Microsoft.EntityFrameworkCore;
using DataLayer.EfClasses;

namespace DataLayer.EfCode
{
    public class SQLiteDbContext: DbContext
    {
        string path = System.IO.Path.Combine(System.Environment.CurrentDirectory + @"\CarOwnerShip.db");

        //private const string ConnectionString = "c:\\mydb.db;";


        public DbSet<Owner> Owners { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<MileAge> MileAges { get; set; }
        public DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string path = System.IO.Path.Combine(System.Environment.CurrentDirectory, DbFileName);
            optionsBuilder.UseSqlite($"Filename={ path}");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Owner>();
            builder.Entity<Car>();
            builder.Entity<MileAge>();
            builder.Entity<Event>();
           
        }

    }
}
