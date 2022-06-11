using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookStore.DB.Models
{
    [Table ("tab_buyprice")]
    public class Buyprice
    {
        [Column ("id")]
        public int Id { get; set; }
        [Column ("buyprice")]
        public int Price { get; set; }

        [Column("edition_id")]
        public int EditionId { get; set; }
        public Edition Edition { get; set; }

        public Buyprice()
        {
        }

        public Buyprice(int buyprice, Edition edition)
        {
            Price = buyprice;
            Edition = edition;
        }
    }
}
