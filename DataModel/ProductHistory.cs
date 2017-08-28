using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTracker.DataModel
{
    [Table("ProductHistory")]
    public class ProductHistory
    {
        [Key]
        public int ProductHistoryId { get; set; }

        public int ProductId { get; set; }

        public string Portal { get; set; }

        public string ProductName { get; set; }

        public DateTime? DateModified { get; set; }

        public string Keyword { get; set; }

        public int? Rank { get; set; }

        public string Review { get; set; }

        public string Note { get; set; }

    }
}
