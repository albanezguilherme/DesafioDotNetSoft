using DesafioSoft.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSoft.Infrastructure
{
    public class DesafioSoftContext : DbContext
    {
        public DesafioSoftContext(DbContextOptions<DesafioSoftContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 1,
                Author = "J. K. Rowling",
                Title = "Harry Potter e a Pedra Filosofal",
                Year = "1997"
            },
            new Book
            {
                Id = 2,
                Author = "J. K. Rowling",
                Title = "Harry Potter e a Câmara Secreta",
                Year = "1998"
            },
            new Book
            {
                Id = 3,
                Author = "J. K. Rowling",
                Title = "Harry Potter e o Prisioneiro de Azkaban",
                Year = "1999"
            });
        }        
    }
}
