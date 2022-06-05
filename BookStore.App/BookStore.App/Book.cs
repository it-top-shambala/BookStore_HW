using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.App
{
    public class Book
    {
        public int Id { get; set; }
        public string NameBook { get; set; }
        public string Genre { get; set; }
        public int Pages { get; set; }

        public int Year { get; set; }
        
        public int CostPrice { get; set; }
        public int SellingPrice { get; set; }
        public int Amount { get; set; }
    }
}
