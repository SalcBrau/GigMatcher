using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GigMatcher.Data.Entities
{
    public class Application
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        
        [Required]
        [ForeignKey("Opening")]
        public Guid OpeningId { get; set; }

        [Required]
        [ForeignKey("Musician")]
        public Guid MusicianId { get; set; }

        public virtual Opening Opening { get; set; }
        public virtual User User { get; set; }

    }
}
