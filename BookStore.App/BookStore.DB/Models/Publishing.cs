using BookStore.App;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BookStore.DB.Models
{
    [Table("tab_publishing")]
    public class Publishing
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("publishingnname")]
        public string PublishingName { get; set; }
        [Column("edition_id")]
        public int EditionId { get; set; }
        public Edition Edition { get; set; }
        public Publishing() { }

        public Publishing(string publishingName, Edition edition)
        {
            PublishingName = publishingName;
            Edition = edition;
        }
    }
}

