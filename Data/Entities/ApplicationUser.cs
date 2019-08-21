using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace GigMatcher.Data.Entities
{
    public class ApplicationUser : IdentityUser<int>
    {
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        [ForeignKey("Musician")]
        public virtual int MusicianId { get; set; }

        public virtual Musician Musician { get; set; }
    }
}
