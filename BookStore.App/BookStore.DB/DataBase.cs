using System;
using System.Collections.Generic;
using System.Text;
using BookStore.DB.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.App
{
    public abstract class DataBase : DbContext
    {
        public DbSet<Book> Books => Set<Book>();
        public DbSet<Author> Authors => Set<Author>();
        public DataBase()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=books.db");
        }

    }
}
