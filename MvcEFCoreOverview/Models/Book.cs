using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEFCoreOverview.Models
{
    [Table("tbl_Books")]
    public class Book
    {
   
        public int ID { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
        [Required]
        [StringLength(200)]
        public string Genre { get; set; }
        public int Pages { get; set; }
        [Column("Published")]
        public int YearPublished { get; set; }

        public string Author { get; set; }
        public bool IsBestSeller { get; set; }
        public int Counters { get; set; }
        [ForeignKey("BookDetail")]
        public int BookDetailId { get; set; }
        public  BookDetails BookDetail { get; set; }


        [NotMapped]
        public string FullName
        {
            get {

                return $"{Author}";
                    }
        }
    }
}
