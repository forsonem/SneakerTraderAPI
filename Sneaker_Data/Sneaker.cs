using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sneaker_Data
{
    public enum Condition { Used = 1, LightlyUsed = 2, Good, VeryGood, BrandNew }
    public class Sneaker
    {
        [Key]
        public int SneakerId { get; set; }
        public int ProfileId { get; set; }

        [ForeignKey(nameof(ProfileId))]
        public virtual Profile Profile { get; set; }

        [Required]
        public string OfficialName { get; set; }

        [Required]
        public string BrandName { get; set; }

        [Required]
        [Display(Name = "Value ($)")]
        public double TodaysValue { get; set; }
        public List<Sneaker> TradeValue { get; set; }
        public Condition Condition { get; set; }

        [Required]
        [Display(Name = "Date Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Date Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }

        [Display(Name = "Trade History")]
        public List<Trade> TradeHistory { get; set; }

    }
}
