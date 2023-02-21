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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //Seeded in Data
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    MovieID = 1,
                    Category = "Action/Adventure",
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
                    Category = "Rom Com",
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
                    Category = "Comedy",
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
