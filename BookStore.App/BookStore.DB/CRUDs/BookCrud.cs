using BookStore.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.DB.CRUDs
{
    public class BookCrud : DataBase
    {
        public BookCrud () : base() { }
        public void ADDBook(Book book)
        {
           this.Books.Add(book);
          
            this.SaveChanges();
        }

        public void Rename (string name, string newname)
        {
            var book = this.Books.First(b => b.NameBook == name);
            book.NameBook = newname;
            this.SaveChanges();
        }
        public void Remove(string name)
        {
            var book = this.Books.First(b => b.NameBook == name);
            this.Remove(book);
            this.SaveChanges();
        }

        public IEnumerable<Book> GetAllNameBooks(IEnumerable<Book> books)
        {
            return books;
        }
    }
}
