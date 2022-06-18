using BookStore.App;
using BookStore.DB.CRUDs;
using BookStore.DB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookStoreWPF.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var db = new BookCrud();
            ADDInitialization(db);
            db.Books.Load();
            this.DataContext = db.Books.Local.ToBindingList();
        }

        private static void ADDInitialization(BookCrud db)
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

            var genre1 = new Genre("Сomedy", book1);
            var genre2 = new Genre("Сomedy", book2);
            var genre3 = new Genre("Fantasy", book3);
            var genre4 = new Genre("Fantasy", book4);

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

        private void totalbooks_Click(object sender, RoutedEventArgs e)
        {
            var listbook = ListBooks.ItemsSource as IEnumerable<Book>;
            var total = 0;
            foreach (var book in listbook)
            {
                total += book.Amount;
            }
            MessageBox.Show($"Total books in stock {total}");
        }

        private void amountbooks_Click(object sender, RoutedEventArgs e)
        {
            if (ListBooks.SelectedItem == null)
            {
                MessageBox.Show("Book not selected");
                return; 
            }
            Book book = ListBooks.SelectedItem as Book;
            MessageBox.Show($"Amount {book.NameBook} in stock {book.Amount.ToString()} pieces");
        }
    }
}
