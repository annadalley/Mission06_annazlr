// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_annazlr.Models;

namespace Mission06_annazlr.Migrations
{
    [DbContext(typeof(MovieInfoContext))]
    [Migration("20230221174124_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_annazlr.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Category = "Action/Adventure",
                            Director = "Anthony Russo",
                            Edited = false,
                            LentTo = "",
                            MovieTitle = "The Avengers",
                            Notes = "",
                            Rating = "PG-13",
                            Year = 2012
                        },
                        new
                        {
                            MovieID = 2,
                            Category = "Rom Com",
                            Director = "Garry Marshall",
                            Edited = false,
                            LentTo = "",
                            MovieTitle = "The Princess Diaries",
                            Notes = "",
                            Rating = "G",
                            Year = 2001
                        },
                        new
                        {
                            MovieID = 3,
                            Category = "Comedy",
                            Director = "Jared Hess",
                            Edited = false,
                            LentTo = "",
                            MovieTitle = "Nacho Libre",
                            Notes = "",
                            Rating = "PG",
                            Year = 2006
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
