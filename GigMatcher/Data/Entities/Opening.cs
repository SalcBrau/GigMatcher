using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GigMatcher.Data.Entities
{
    public class Opening
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey("Gig")]
        public Guid GigId { get; set; }
        public virtual Gig Gig { get; set; }
        public List<Application> Applications { get; set; }
    }
}
