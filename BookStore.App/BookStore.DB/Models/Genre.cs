using BookStore.App;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookStore.DB.Models
{
    [Table("tab_genre")]
    public class Genre
    {
        [Column ("id")]
        
        public int Id { get; set; }

        [Column ("genrename")]
        public string Genrename { get; set; }
        [Column("book_id")]
        public int BookId { get; set; }
        public Book? Book { get; set; }

        public Genre()
        {
        }

        public Genre(string genrename, Book book)
        {
            Genrename = genrename;
            Book = book;
        }
    }
}

