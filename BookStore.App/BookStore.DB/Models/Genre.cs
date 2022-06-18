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

        [Column ("genre_name")]
        public string GenreName { get; set; }
        [Column("book_id")]
        public int BookId { get; set; }
        public Book Book { get; set; }

        public Genre()
        {
        }

        public Genre(string genre_name, Book book)
        {
            GenreName = genre_name;
            Book = book;
        }
    }
}

