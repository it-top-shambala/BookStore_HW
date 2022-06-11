using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookStore.DB.Models
{
    [Table ("tab_stock") ]
    class Stock
    {
        [Column ("id")]
        public int Id { get; set; }
        [Column("amount")]
        public int Amount { get; set; }
    }
}
