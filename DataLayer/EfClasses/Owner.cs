

using System.ComponentModel.DataAnnotations;

namespace DataLayer.EfClasses
{
    public class Owner
    {
        public int OwnerId { get; set; }    // ключ по соглашению
        
        public string OwnerName { get; set; } = "newuser";
        
        /// TODO: Add login/password here?
        

        // Relationships
        public ICollection<Car>? Cars { get; set; }
    }
}
