using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.EfClasses
{
    public class Car
    {
        public int CarId { get; set; }  // ключ по соглашению
        
        public string BrandName { get; set; } = "";
        
        public string Model { get; set; } = "";
        public string? RegNumber { get; set; }
        
        public DateOnly ManufactureDate { get; set; }
        
        public DateOnly PurchaseDate { get; set; }
        public int MileAge { get; set; }
        public decimal Price { get; set; }

        // Relationships
        public ICollection<MileAge>? MileAges { get; set; }
        public ICollection<Event>? Events { get; set; }

    }
}