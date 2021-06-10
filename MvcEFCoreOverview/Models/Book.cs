using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEFCoreOverview.Models
{
    public class Book
    {
        [Required]
        [StringLength(200)]
        public int ID { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [Required]
        [StringLength(200)]
        public string Genre { get; set; }
        public int Pages { get; set; }
        public int YearPublished { get; set; }

        public string Author { get; set; }
        public bool IsBestSeller { get; set; }
        public int Counters { get; set; }
    }
}
