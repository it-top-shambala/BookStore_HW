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
        public DbSet<Genre> Genres => Set<Genre>();
        //
        //
        public DbSet<Edition> Editions => Set<Edition>();
        public DbSet<Publishing> Publishings => Set<Publishing>();
        public DbSet<Saleprice> Saleprices => Set<Saleprice>();
        public DbSet<Buyprice> Buyprices => Set<Buyprice>();
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
