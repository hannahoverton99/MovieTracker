using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MovieTracker.Classes
{

public class MovieTrackerDbContext : DbContext
{
    public DbSet<User>Users {get; set;}
    public DbSet<Films>Films {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          optionsBuilder.UseMySql("server=localhost;database=movietracker;user=movietracker;password=movietracker", new MySqlServerVersion(new Version(8, 0, 37)));

        }
    }
}
