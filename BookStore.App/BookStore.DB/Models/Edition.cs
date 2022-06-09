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


        [Column ("Publishing_Id")]
        public int PublishingId { get; set; }
        public Publishing? publishing { get; set; }


        public int BookId { get; set; }
        public Book? Book { get; set; }

        [Column("buyprice_id")]
        public int BuypriceId { get; set; }
        public Buyprice? Buyprice { get; set; }

        [Column("saleprice_id")]
        public int SalepriceId { get; set; }
        public Saleprice? Saleprice { get; set; }

        public Edition() { }

        public Edition(string editionname, int pages, int year, Book book, Buyprice buyprice, Saleprice saleprice)
        {
            Editionname = editionname;
            Pages = pages;
            Year = year;
            Book = book;
            Buyprice = buyprice;
            Saleprice = saleprice;
        }
    }
}
