﻿// <auto-generated />
using System;
using INFMusicTest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace INFMusicTest.Migrations
{
    [DbContext(typeof(MusicDBContext))]
    [Migration("20231219133231_AddingTestData")]
    partial class AddingTestData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("INFMusicTest.Data.Entitys.Author", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("AuthorID");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorID = 10,
                            Name = "BoyWithUke"
                        },
                        new
                        {
                            AuthorID = 11,
                            Name = "21 Pilots"
                        },
                        new
                        {
                            AuthorID = 12,
                            Name = "Marilyn Manson"
                        });
                });

            modelBuilder.Entity("INFMusicTest.Data.Entitys.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"));

                    b.Property<string>("TakenFrom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("TakenSince")
                        .HasColumnType("date");

                    b.Property<DateOnly>("TakenTill")
                        .HasColumnType("date");

                    b.HasKey("BookingID");

                    b.ToTable("Bookings");

                    b.HasData(
                        new
                        {
                            BookingID = 1,
                            TakenFrom = "Dominik",
                            TakenSince = new DateOnly(2023, 12, 19),
                            TakenTill = new DateOnly(2023, 12, 21)
                        },
                        new
                        {
                            BookingID = 2,
                            TakenFrom = "IdontKnow",
                            TakenSince = new DateOnly(2023, 12, 19),
                            TakenTill = new DateOnly(2023, 12, 27)
                        });
                });

            modelBuilder.Entity("INFMusicTest.Data.Entitys.Genre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("GenreID");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreID = 1,
                            Name = "Pop"
                        },
                        new
                        {
                            GenreID = 2,
                            Name = "Soft Rock"
                        },
                        new
                        {
                            GenreID = 3,
                            Name = "Hard Rock"
                        });
                });

            modelBuilder.Entity("INFMusicTest.Data.Entitys.Offer", b =>
                {
                    b.Property<int>("OfferID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OfferID"));

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<int>("SongID")
                        .HasColumnType("int");

                    b.HasKey("OfferID");

                    b.ToTable("Offers");

                    b.HasData(
                        new
                        {
                            OfferID = 1,
                            Availability = true,
                            SongID = 1
                        },
                        new
                        {
                            OfferID = 2,
                            Availability = true,
                            SongID = 2
                        },
                        new
                        {
                            OfferID = 3,
                            Availability = false,
                            SongID = 3
                        });
                });

            modelBuilder.Entity("INFMusicTest.Data.Entitys.Song", b =>
                {
                    b.Property<int>("SongID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SongID"));

                    b.Property<int>("AuthorID")
                        .HasColumnType("int");

                    b.Property<int>("GenreID")
                        .HasColumnType("int");

                    b.Property<DateOnly>("ReleaseDate")
                        .HasColumnType("date");

                    b.Property<int>("SongLength")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("SongID");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            SongID = 1,
                            AuthorID = 10,
                            GenreID = 1,
                            ReleaseDate = new DateOnly(2023, 12, 19),
                            SongLength = 278,
                            Title = "Toxic"
                        },
                        new
                        {
                            SongID = 2,
                            AuthorID = 11,
                            GenreID = 2,
                            ReleaseDate = new DateOnly(2023, 12, 19),
                            SongLength = 278,
                            Title = "Migrane"
                        },
                        new
                        {
                            SongID = 3,
                            AuthorID = 12,
                            GenreID = 3,
                            ReleaseDate = new DateOnly(2023, 12, 19),
                            SongLength = 278,
                            Title = "Mobscene"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}