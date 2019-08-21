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
        public int Id { get; set; }
       
        [Required]
        [ForeignKey("Musician")]
        public int MusicianId { get; set; }

        [Required]
        [ForeignKey("ApplicationStatus")]
        public int ApplicationStatusId { get; set; }

        public virtual Musician Musician { get; set; }
        public virtual Position Position { get; set; }
        public virtual ApplicationStatus ApplicationStatus { get; set; }

    }
}
