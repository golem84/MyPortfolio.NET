using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EfClasses
{
    public class CarMileage
    {
        public int CarId { get; set; }
        public int MileageId { get; set; }

        // Relationships
        public Car Car { get; set; }
        public MileAge Mileage { get; set; }
    }
}
