using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GigMatcher.Data.Entities
{
    public class Position
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey("PositionStatus")]
        public Guid PositionStatusId { get; set; }

        [Required]
        [ForeignKey("Gig")]
        public Guid GigId { get; set; }

        [ForeignKey("Musician")]
        public Guid MusicianId { get; set; }

        [Required]
        public decimal Pay { get; set; }

        [Required]
        public String Description { get; set; }

        public virtual PositionStatus PositionStatus { get; set; }
        public virtual Gig Gig { get; set; }
        public virtual Musician Musician { get; set; }
        public virtual ICollection<PositionInstrument> PositionInstruments { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
    }
}
