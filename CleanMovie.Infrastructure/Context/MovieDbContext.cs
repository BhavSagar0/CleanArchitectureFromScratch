using CleanMovie.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure.Context
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //One to many (Members and Rentals)
            modelBuilder.Entity<Member>()
                .HasOne(s => s.Rental)
                .WithMany(s => s.Members)
                .HasForeignKey(s => s.RentalId);

            //Many to many (Rental and Movie)
            modelBuilder.Entity<MovieRental>()
                .HasKey(g => new { g.MovieId, g.RentalId });

            //handle decimal precision

            modelBuilder.Entity<Movie>()
                .Property(r => r.RentalCost)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Rental>()
                .Property(r => r.RentalCost)
                .HasColumnType("decimal(18,2)");

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MovieRental> MovieRentals { get; set; }
    }
}
