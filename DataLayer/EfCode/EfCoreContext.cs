using Microsoft.EntityFrameworkCore;
using DataLayer.EfClasses;

namespace DataLayer.EfCode
{
    public class EfCoreContext: DbContext
    {
        private const string DbFileName = "CarOwnership.db";
        
        private const string ConnectionString = 
            @"Data Source=c:\mydb.db;Version=3;";


        public DbSet<Owner> Owners { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<MileAge> MileAges { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
