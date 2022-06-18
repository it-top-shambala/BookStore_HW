using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookStore.DB.Models
{
    [Table ("tab_buyprice")]
    public class BuyPrice
    {
        [Column ("id")]
        public int Id { get; set; }
        [Column ("buy_price")]
        public int Price { get; set; }

        [Column("edition_id")]
        public int EditionId { get; set; }
        public Edition Edition { get; set; }

        public BuyPrice()
        {
        }

        public BuyPrice(int buy_price, Edition edition)
        {
            Price = buy_price;
            Edition = edition;
        }
    }
}
