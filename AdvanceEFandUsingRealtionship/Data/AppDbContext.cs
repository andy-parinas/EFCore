using AdvanceEFandUsingRealtionship.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceEFandUsingRealtionship.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(b => b.Isbn).HasMaxLength(10);
            //modelBuilder.Entity<Book>().HasAlternateKey(b => b.Isbn).HasName("UniqueIsbn");
            /*
             * Using Index Property Instead of AlternateKey as describe above
             * 
             */
            modelBuilder.Entity<Book>().HasIndex(b => b.Isbn).HasName("IsbnIndex").IsUnique();
            modelBuilder.Entity<Book>().Ignore(b => b.FullTitle);
            modelBuilder.Entity<Book>().Property(b => b.CreatedAt).HasDefaultValueSql("getdate()");
            modelBuilder.Entity<Author>().HasKey(a => new { a.FirstName, a.LastName });


        }
    }
}
