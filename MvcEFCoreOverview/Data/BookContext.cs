using Microsoft.EntityFrameworkCore;
using MvcEFCoreOverview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEFCoreOverview.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-AO42BIR6;Database=BookEF;Integrated=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
