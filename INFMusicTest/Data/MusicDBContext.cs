using INFMusicTest.Data.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFMusicTest.Data
{
    public class MusicDBContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Booking> Bookings { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Author>()
                .HasData(
                    new Author(10, "BoyWithUke"),
                    new Author(11, "21 Pilots"),
                    new Author(12,"Marilyn Manson")
                    );

            modelBuilder.Entity<Genre>()
                .HasData(
                    new Genre(1,"Pop"),
                    new Genre(2,"Soft Rock"),
                    new Genre(3,"Hard Rock")
                );

            modelBuilder.Entity<Song>()
                .HasData(
                    new Song(1, "Toxic", 1,  10),
                    new Song(2,"Migrane", 2, 11),
                    new Song(3,"Mobscene", 3, 12)
                );

            modelBuilder.Entity<Offer>()
                .HasData(
                    new Offer(1, 1, true),
                    new Offer(2, 2, true),
                    new Offer(3, 3, false)
                );

            modelBuilder.Entity<Booking>()
                .HasData(
                    new Booking(1, DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now.AddDays(2)), "Dominik"),
                    new Booking(2, DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now).AddDays(8), "IdontKnow")
                );

        }
    }
}
