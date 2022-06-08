using BookStore.App;
using System;
using System.Collections.Generic;
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


    }
}
