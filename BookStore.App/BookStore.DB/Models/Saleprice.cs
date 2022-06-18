using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookStore.DB.Models
{
    [Table("tab_saleprice")]
    public class Saleprice
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("sale_price")]
        public int Price { get; set; }
        [Column("edition_id")]
        public int EditionId { get; set; }
        public Edition Edition { get; set; }

        public Saleprice()
        {
        }

        public Saleprice(int price, Edition edition)
        {
            Price = price;
            Edition = edition;
        }
    }
}
