

using System.ComponentModel.DataAnnotations;

namespace DataLayer.EfClasses
{
    public class Owner
    {
        public int OwnerId { get; set; }    // ключ по соглашению
        
        public string OwnerName { get; set; } = "newuser";
        
        /// TODO: Add login/password here?
        

        // Relationships
        public virtual ICollection<Car> Cars { get; set; }
        public Owner()
        {
            this.Cars = new HashSet<Car>();
        }
    }
}
