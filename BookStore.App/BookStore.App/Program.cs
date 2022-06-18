using BookStore.DB.CRUDs;
using BookStore.DB.Models;
using System;
using System.Collections.Generic;

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

          //  Print(db.Books);
          //  Console.WriteLine();

            db.Rename("book1", "BOOK1");

            //var book = db.Books.First(b => b.Id == 2);
            //db.Books.Remove(book);
            //db.SaveChanges();
            //Print(db.Books);
          //  Console.WriteLine();
            //book = db.Books.First(b => b.NameBook=="book1");
            //book.NameBook = "dfdfdsf";
            //db.SaveChanges();
          //  Print(db.Books);

            db.Remove("book0");
            //  Console.WriteLine();
            //Print(db.Books);
           
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

            var genre1 = new Genre("Сomedy",  book1);
            var genre2 = new Genre("Сomedy",  book2);
            var genre3 = new Genre("Fantasy",  book3);
            var genre4 = new Genre("Fantasy",  book4);

            db.Genres.AddRange(genre1, genre2, genre3, genre4);



            var edition1 = new Edition("Edition1", 100, 1877, book1);
            var edition2 = new Edition("Edition2", 200, 1879, book2);
            var edition3 = new Edition("Edition3", 250, 1894, book3);
            var edition4 = new Edition("Edition4", 150, 1900, book4);

            db.Editions.AddRange(edition1, edition2, edition3, edition4);

            var publ1 = new Publishing("Issuer1", edition1);
            var publ2 = new Publishing("Issuer2", edition2);
            var publ3 = new Publishing("Issuer3", edition3);
            var publ4 = new Publishing("Issuer4", edition4);

            db.Publishings.AddRange(publ1, publ2, publ3, publ4);
            var cost1 = new Buyprice(1250, edition1);
            var cost2 = new Buyprice(1300, edition2);
            var cost3 = new Buyprice(2250, edition3);
            var cost4 = new Buyprice(1000, edition4);

            db.Buyprices.AddRange(cost1, cost2, cost3, cost4);

            var sale1 = new Saleprice(1350, edition1);
            var sale2 = new Saleprice(1400, edition2);
            var sale3 = new Saleprice(2550, edition3);
            var sale4 = new Saleprice(1100, edition4);

            db.Saleprices.AddRange(sale1, sale2, sale3, sale4);

            db.SaveChanges();
        }


        private static void Print (IEnumerable<Book> books)
        {
           
            foreach (var book in books)
            {
                Console.WriteLine($"#{book.Id} : {book.NameBook}, {book.Amount}");
                if (book.Author == null) continue;
                
                    Console.WriteLine($"{book.Author.Firstname} {book.Author.Lastname} {book.Author.Patronymic} ");

                if (book.Genre == null) continue;
                     Console.WriteLine($"{book.Genre.Genrename} ");
                Console.WriteLine($"{book.Edition.Editionname} {book.Edition.Year} ");
                Console.WriteLine($"{book.Edition.Publishing.PublishingName} ");
                Console.WriteLine($"{book.Edition.Buyprice.Price} / {book.Edition.Saleprice.Price}");
                Console.WriteLine();
            }
        }

       
    }
}
