﻿using System.Diagnostics;
using EFConsoleTutorial.Models;
using Microsoft.EntityFrameworkCore;

namespace EFConsoleTutorial
{
    public class SchoolContext : DbContext
    {
        //entities
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SchoolDb;Trusted_Connection=True;");
        }
    }
}
