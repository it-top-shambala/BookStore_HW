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
        [Column("name_book")]
        public string NameBook { get; set; }
        
        [Column("amount")]
        public int Amount { get; set; }
        public Author Author { get; set; }
        public Genre Genre { get; set; }
        public Edition Edition { get; set; }
        public Book() { }
        public Book(string name_book, int amount)
        {
            NameBook = name_book;
            Amount = amount;
        }
    }
}
