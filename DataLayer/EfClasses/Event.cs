using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EfClasses
{
    public class Event
    {
        public int EventId { get; set; }
        [Required]
        [MaxLength(256)]
        [Column("Descr")]
        public string Description { get; set; } = "";
        public DateOnly EventDate { get; set; }
        public MileAge? MileAge { get; set; }
        [Required]
        [MaxLength(512)]
        [Column("Content")]
        public string WorkContent { get; set; } = "";
        public decimal PartsPrice { get; set; } = 0;
        public decimal WorkCost { get; set; } = 0;

        
        /// TODO: добавить автоматическое занесение даты и пробега в таблицу MileAges с проверкой на уникальность
        
    }
}
