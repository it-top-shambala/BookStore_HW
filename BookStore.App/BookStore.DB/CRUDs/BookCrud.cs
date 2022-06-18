using BookStore.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.DB.CRUDs
{
    public class BookCrud
    {
        public BookCrud() : base() { }
        public void ADDBook(DataBase dbBook, Book book)
        {
            dbBook.Add(book);
            dbBook.SaveChanges();
        }

        public void Rename (DataBase dbBook, string name, string newname)
        {
            var book = dbBook.Books.First(b => b.NameBook == name);
            book.NameBook = newname;
            dbBook.SaveChanges();
        }
        public void Remove(DataBase dbBook, string name)
        {
            var book = dbBook.Books.First(b => b.NameBook == name);
            dbBook.Books.Remove(book);
            dbBook.SaveChanges();
        }

        public IEnumerable<Book> GetAllNameBooks(IEnumerable<Book> books)
        {
            return books;
        }
    }
}
