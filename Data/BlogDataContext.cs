using System;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class BlogDataContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseSqlServer("Server=localhost,1433;Database=Blog;User ID=sa;Password=!Slipknot2910");
            //options.UseSqlServer("Server=localhost,1433;Database=Blog2;User ID=sa;Password=!Slipknot2910");

            options.LogTo(Console.WriteLine);
        }
    }
}