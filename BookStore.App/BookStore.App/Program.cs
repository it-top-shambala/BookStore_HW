using BookStore.DB.CRUDs;
using BookStore.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new BookCrud();
            ADDInitialization(db);
            Book book0 = new Book()
            {
                NameBook = "book0",
                Amount = 5
            };
            db.ADDBook(book0);

            Print(db.Books);
            Console.WriteLine();

            db.Rename("book1", "BOOK1");

            //var book = db.Books.First(b => b.Id == 2);
            //db.Books.Remove(book);
            //db.SaveChanges();
            //Print(db.Books);
            Console.WriteLine();
            //book = db.Books.First(b => b.NameBook=="book1");
            //book.NameBook = "dfdfdsf";
            //db.SaveChanges();
            Print(db.Books);

            db.Remove("book0");
            Console.WriteLine();
            Print(db.Books);
        }

        private static void ADDInitialization (BookCrud db)
        {
            var book1 = new Book()
            {
                NameBook = "book1",
                Amount = 10
            };
            var book2 = new Book()
            {
                NameBook = "book2",
                Amount = 2
            };
            var book3 = new Book()
            {
                NameBook = "book3",
                Amount = 6
            };
            var book4 = new Book()
            {
                NameBook = "book4",
                Amount = 7
            };

            db.Books.AddRange(book1, book2, book3, book4);

            var author1 = new Author("Alexander", "Sergeyevich", "Pushkin", book1);
            var author2 = new Author("Mikhail", "Yurjevich", "Lermontov", book2);
            var author3 = new Author("Alexander", "Sergeyevich", "Pushkin", book3);
            var author4 = new Author("Mikhail", "Yurjevich", "Lermontov", book4);

            db.Authors.AddRange(author1, author2, author3, author4);
              
            db.SaveChanges();
        }


        private static void Print (IEnumerable<Book> books)
        {
           
            foreach (var book in books)
            {
                Console.WriteLine($"#{book.Id} : {book.NameBook}, {book.Amount}");
                if (book.Author == null) continue;
                
                    Console.WriteLine($"{book.Author.Firstname} {book.Author.Patronymic} {book.Author.Lastname}");
                
               
            }
        }

       
    }
}
