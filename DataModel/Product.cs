using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTracker.DataModel
{  
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string Portal { get; set; }

        public string ProductName { get; set; }

        public string Keyword { get; set; }

        public string Category { get; set; }

        public int? Rank { get; set; }

        public decimal? ReviewCount { get; set; }

        public DateTime? EntryDate { get; set; }

        public string Description { get; set; }
    }
}
