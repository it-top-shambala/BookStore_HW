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
        [Column ("editionname")]
        public string Editionname { get; set; }
        [Column("pages")]
        public int Pages { get; set; }
        [Column("year")]
        public int Year { get; set; }
        public Publishing Publishing { get; set; }
        public Buyprice Buyprice { get; set; }
        public Saleprice Saleprice { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }

        public Edition() { }

        public Edition(string editionname, int pages, int year, Book book)
        {
            Editionname = editionname;
            Pages = pages;
            Year = year;
            Book = book;
           
        }
    }
}
