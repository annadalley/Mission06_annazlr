using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_annazlr.Models
{
    public class MovieInfoContext : DbContext
    {
        //Constructor
        public MovieInfoContext (DbContextOptions<MovieInfoContext> options) : base (options)
        {
            //Leave Blank for now
        }

        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID=1, CategoryName="Action"},
                new Category { CategoryID=2, CategoryName = "RomCom"},
                new Category { CategoryID=3, CategoryName = "Comedy"},
                new Category { CategoryID=4, CategoryName = "Drama"},
                new Category { CategoryID=5, CategoryName = "Other"}
            );

            //Seeded in Data
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    MovieID = 1,
                    CategoryID = 1,
                    MovieTitle = "The Avengers",
                    Year = 2012,
                    Director = "Anthony Russo",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""


                },
                new ApplicationResponse
                {
                    MovieID = 2,
                    CategoryID = 2,
                    MovieTitle = "The Princess Diaries",
                    Year = 2001,
                    Director = "Garry Marshall",
                    Rating = "G",
                    Edited = false,
                    LentTo = "",
                    Notes = ""

                },

                new ApplicationResponse
                {
                    MovieID = 3,
                    CategoryID = 3,
                    MovieTitle = "Nacho Libre",
                    Year = 2006,
                    Director = "Jared Hess",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""

                }
            );
        }
    }
}
