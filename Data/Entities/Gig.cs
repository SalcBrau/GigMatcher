using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GigMatcher.Data.Entities
{
    public class Gig
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Owner")]
        [Required]
        public int OwnerId { get; set; }

        [ForeignKey("GigStatus")]
        [Required]
        public int GigStatusId { get; set; }

        [Required]
        public int NumberOfPositions { get; set; }

        [Required]
        public decimal TotalPay { get; set; }

        [Required]
        public String Location { get; set; }

        [Required]
        public DateTime GigStart { get; set; }

        [Required]
        public DateTime GigEnd { get; set; }

        [Required]
        public String Description { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public virtual Musician Owner { get; set; }
        public virtual GigStatus GigStatus { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
    }
}
