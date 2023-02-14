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
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
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
