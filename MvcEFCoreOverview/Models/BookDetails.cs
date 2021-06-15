using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEFCoreOverview.Models
{
    public class BookDetails
    {
        public int BookDetailId { get; set; }
        public double Weight { get; set; }
        public Book Book { get; set; }
    }
}
