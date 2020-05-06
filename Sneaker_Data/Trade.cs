using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sneaker_Data
{
    public class Trade
    {
        [Key]
        [Required]
        public int TransactionId { get; set; }
        [Required]
        public int ProfileId { get; set; }

        [ForeignKey(nameof(ProfileId))]
        public virtual Profile Profile { get; set; }
        //[Required]
        //public int SneakerId { get; set; }
        //[ForeignKey(nameof(SneakerId))]
        //public virtual Sneaker Sneaker { get; set; }
        [Required]
        public DateTimeOffset DateofTrade { get; set; }

        

    }
}
