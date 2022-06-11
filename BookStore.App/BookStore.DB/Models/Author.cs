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
        [Column("firstname")]
        public string Firstname { get; set; }
        [Column("lastname")]
        public string Lastname { get; set; }
        [Column("patronymic")]
        public string Patronymic { get; set; }
        [Column("book_id")]
        public int BookId { get; set; }
        public Book Book { get; set; }
        public Author() { }

        public Author(string firstname, string lastname, string patronymic, Book book)
        {
            Firstname = firstname;
            Lastname = lastname;
            Patronymic = patronymic;
            Book = book;
        }
    }
}
