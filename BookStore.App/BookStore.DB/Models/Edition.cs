using BookStore.App;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookStore.DB.Models
{
    [Table("tab_edition")]
    public class Edition
    {
        [Column("id")]
        public int Id { get; set; }
        [Column ("edition_name")]
        public string EditionName { get; set; }
        [Column("pages")]
        public int Pages { get; set; }
        [Column("year")]
        public int Year { get; set; }
        public Publishing Publishing { get; set; }
        public BuyPrice BuyPrice { get; set; }
        public Saleprice SalePrice { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }

        public Edition() { }

        public Edition(string edition_name, int pages, int year, Book book)
        {
            EditionName = edition_name;
            Pages = pages;
            Year = year;
            Book = book;
           
        }
    }
}
