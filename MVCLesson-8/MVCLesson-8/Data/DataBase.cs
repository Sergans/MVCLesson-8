using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCLesson_8.Models;


namespace MVCLesson_8.Data
{
    public class DataBase:DbContext
    {
        public DbSet<Employee>Employees { get; set; }
        public DataBase()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=mvslesson8;Trusted_Connection=True;");
        }


    }
}
