﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieTracker.Classes;

#nullable disable

namespace MovieTracker.Migrations
{
    [DbContext(typeof(MovieTrackerDbContext))]
    [Migration("20240828180532_SecondBuild")]
    partial class SecondBuild
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("MovieTracker.Classes.Films", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateWatched")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("MovieGenre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("MovieTracker.Classes.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("MovieTracker.Classes.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserProfileId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserProfileId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MovieTracker.Classes.Films", b =>
                {
                    b.HasOne("MovieTracker.Classes.Profile", null)
                        .WithMany("WatchedMovies")
                        .HasForeignKey("ProfileId");
                });

            modelBuilder.Entity("MovieTracker.Classes.User", b =>
                {
                    b.HasOne("MovieTracker.Classes.Profile", "UserProfile")
                        .WithMany()
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("MovieTracker.Classes.Profile", b =>
                {
                    b.Navigation("WatchedMovies");
                });
#pragma warning restore 612, 618
        }
    }
}
