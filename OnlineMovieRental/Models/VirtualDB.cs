using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace OnlineMovieRental.Models
{
    public class VirtualDB : IdentityDbContext
    {
        public VirtualDB(DbContextOptions<VirtualDB> options)
            : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MembershipType>().HasData(
                new MembershipType
                {
                    Id = 1,
                    SignUpFee = 0,
                    DurationInMonths = 0,
                    DiscountRate = 0,
                    Name = "Pay as You Go",
                },
                new MembershipType
                {
                    Id = 2,
                    SignUpFee = 30,
                    DurationInMonths = 1,
                    DiscountRate = 10,
                    Name = "Monthly",
                }, 
                new MembershipType
                {
                    Id = 3,
                    SignUpFee = 90,
                    DurationInMonths = 3,
                    DiscountRate = 50,
                    Name = "Quarterly",

                },
                new MembershipType
                {
                    Id = 4,
                    SignUpFee = 300,
                    DurationInMonths = 12,
                    DiscountRate = 20,
                    Name = "Annual",
                }

            );

            modelBuilder.Entity<Genre>().HasData(
                new Genre
                {
                    Id = 1,
                    Name = "Action",
                },
            new Genre
                {
                    Id = 2,
                    Name = "Adventure",
                },
            new Genre
                {
                    Id = 3,
                    Name = "Comedy",
                },
            new Genre
                {
                    Id = 4,
                    Name = "Fantasy",
                },
            new Genre
                {
                    Id = 5,
                    Name = "Family",
                },
            new Genre
                {
                    Id = 6,
                    Name = "Horror",
                },
            new Genre
                {
                    Id = 7,
                    Name = "Mystery",
                },
            new Genre
                {
                    Id = 8,
                    Name = "Romance",
                }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Name = "Glass",
                    GenreId = 7,
                    ReleaseDate = new DateTime(2019, 01,18),
                    DateAdded = new DateTime(2019, 10,20),
                    NumberInStock = 10,
                    NumberAvailable = 10,
                },
                new Movie
                {
                    Id = 2,
                    Name = "The Kid Who Would Be King",
                    GenreId = 2,
                    ReleaseDate = new DateTime(2019, 01,25),
                    DateAdded = new DateTime(2019, 10,20),
                    NumberInStock = 30,
                    NumberAvailable = 30,
                },
                new Movie
                {
                    Id = 3,
                    Name = "The Lego Movie 2: The Second Part",
                    GenreId = 5,
                    ReleaseDate = new DateTime(2019, 02,08),
                    DateAdded = new DateTime(2019, 10,20),
                    NumberInStock = 40,
                    NumberAvailable = 40,

                },
                new Movie
                {
                    Id = 4,
                    Name = "What Men Want",
                    GenreId = 3,
                    ReleaseDate = new DateTime(2019, 02,08),
                    DateAdded = new DateTime(2019, 10,20),
                    NumberInStock = 30,
                    NumberAvailable = 30,

                },
                new Movie
                {
                    Id = 5,
                    Name = "Alita: Battle Angel",
                    GenreId = 4,
                    ReleaseDate = new DateTime(2019, 03,08),
                    DateAdded = new DateTime(2019, 10,20),
                    NumberInStock = 20,
                    NumberAvailable = 20,
                },
                new Movie
                {
                    Id = 6,
                    Name = "Captain Marvel",
                    GenreId = 1,
                    ReleaseDate = new DateTime(2019, 02,14),
                    DateAdded = new DateTime(2019, 10,20),
                    NumberInStock = 50,
                    NumberAvailable = 50,
                }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 1,
                    Name = "Kenan Sabanovic",
                    IsSubscribedToNewsletter = true,
                    MembershipTypeId = 2,
                    Birthdate = new DateTime(1994, 01,24),
                },
                new Customer
                {
                    Id = 2,
                    Name = "Faik Muslic",
                    IsSubscribedToNewsletter = true,
                    MembershipTypeId = 3,
                    Birthdate = new DateTime(1994, 01,24),
                },
                new Customer
                {
                    Id = 3,
                    Name = "Muris Cengic",
                    IsSubscribedToNewsletter = true,
                    MembershipTypeId = 1,
                    Birthdate = new DateTime(1994, 01,24),
                },
                new Customer
                {
                    Id = 4,
                    Name = "Enes Kapetanovic",
                    IsSubscribedToNewsletter = true,
                    MembershipTypeId = 2,
                    Birthdate = new DateTime(1994, 01,24),
                },
                new Customer
                {
                    Id = 5,
                    Name = "Testni Kupac",
                    IsSubscribedToNewsletter = true,
                    MembershipTypeId = 2,
                    Birthdate = new DateTime(1994, 01,24),
                },
                new Customer
                {
                    Id = 6,
                    Name = "Testni Kupac2",
                    IsSubscribedToNewsletter = true,
                    MembershipTypeId = 2,
                    Birthdate = new DateTime(1994, 01,24),
                }
            );
        }

    }
}
