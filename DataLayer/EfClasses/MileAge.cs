

namespace DataLayer.EfClasses
{
    //struct 
    
    public class MileAge
    {
        public int MileAgeId { get; set; }
        public DateOnly Date { get; set; }
        public int Miles { get; set; }

        /*
        // Relationships
        public int CarId { get; set; }
        */

        
    }
}
