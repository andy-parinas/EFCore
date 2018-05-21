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
        public DbSet<Client> Clients { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<PersonalLibrary> PersonalLibraries { get; set; }
        public DbSet<PersonalLibraryBook> PersonalLibraryBooks { get; set; }


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

            //modelBuilder.Entity<Author>().HasKey(a => new { a.FirstName, a.LastName });

            //Client -PersonalLibrary one-to-one relationship
            modelBuilder.Entity<Client>().HasOne(c => c.PersonalLibrary).WithOne(l => l.Client).HasForeignKey<PersonalLibrary>();

            //Put a constraints in the PersonalLibraryBook that no two combination of 
            //PersonalLibrary and Book should exist
            modelBuilder.Entity<PersonalLibraryBook>()
                .HasKey(pl => new { pl.BookId, pl.PersonalLibraryId });

            //Book-PersonalLibrary many-to-many relationship
            modelBuilder.Entity<PersonalLibraryBook>()
                .HasOne(pl => pl.Book).WithMany(b => b.PersonalLibraryBooks)
                .HasForeignKey(pl => pl.BookId);

            modelBuilder.Entity<PersonalLibraryBook>()
                .HasOne(pl => pl.PersonalLibrary).WithMany(l => l.PersonalLibraryBooks)
                .HasForeignKey(pl => pl.PersonalLibraryId);


        }
    }
}
