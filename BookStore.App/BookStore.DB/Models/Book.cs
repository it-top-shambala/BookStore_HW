using BookStore.DB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookStore.App
{
    [Table("tab_book")]
    public class Book
    {
        [Column ("id")]
        public int Id { get; set; }
        [Column("namebook")]
        public string NameBook { get; set; }
        // public string Genre { get; set; }
        //  public int Pages { get; set; }

        // public int Year { get; set; }

        //  public int CostPrice { get; set; }
        //  public int SellingPrice { get; set; }
        [Column("amount")]
        public int Amount { get; set; }

        public Book() { }
        public Book(string namebook, int amount ) 
        {
            NameBook = namebook;
            Amount = amount;
        }
        public Author? Author { get; set; }
    }
}
