using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEFCoreOverview.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Pages { get; set; }
        public int YearPublished { get; set; }

    }
}
