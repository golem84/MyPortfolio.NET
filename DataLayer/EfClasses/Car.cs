namespace DataLayer.EfClasses
{
    public class Car
    {
        public int CarId { get; set; }  // ключ по соглашению
        public string BrandName { get; set; }
        public string Model { get; set; }
        public string RegNumber { get; set; }
        public DateOnly ManufactureDate { get; set; }
        public DateOnly PurchaseDate { get; set; }
        public int Mileage { get; set; }
        public decimal Price { get; set; }
    }
}