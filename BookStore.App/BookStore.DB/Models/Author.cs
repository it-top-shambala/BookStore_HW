using BookStore.App;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookStore.DB.Models
{
    [Table("tab_autor")]
    public class Author
    {
        [Column ("id")]
        public int Id { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("patronymic")]
        public string Patronymic { get; set; }
        [Column("book_id")]
        public int BookId { get; set; }
        public Book Book { get; set; }
        public Author() { }

        public Author(string first_name, string last_name, string patronymic, Book book)
        {
            FirstName = first_name;
            LastName = last_name;
            Patronymic = patronymic;
            Book = book;
        }
    }
}
