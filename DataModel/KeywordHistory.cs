using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTracker.DataModel
{
    [Table("KeywordHistory")]
    public class KeywordHistory
    {
        [Key]
        public int KeywordHistoryId { get; set; }

        public DateTime DateModified { get; set; }

        public int ProductId { get; set; }

        public string Keyword { get; set; }
    }
}
