using System;
using System.Collections.Generic;

namespace BookStore.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DataBase();
            db.Books.Add(new Book() 
            { 
              
                NameBook="book",
                Amount = 10
            });
            db.SaveChanges();

            Print(db.Books);
        }

        private static void Print (IEnumerable<Book> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"#{book.Id} : {book.NameBook}, {book.Amount}");
            }
        }
    }
}
