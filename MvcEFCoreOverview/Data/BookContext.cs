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
        public DbSet<BookDetails> BookDetails { get; set; }

        //Optie A
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-AO42BIR6\\SQLEXPRESS;Database=BookEF;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
