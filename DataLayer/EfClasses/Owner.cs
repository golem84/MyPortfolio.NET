

namespace DataLayer.EfClasses
{
    public class Owner
    {
        public int OwnerId { get; set; }    // ключ по соглашению
        public string OwnerName { get; set; }

        // Relationships
        public ICollection<Car> Cars { get; set; }
    }
}
