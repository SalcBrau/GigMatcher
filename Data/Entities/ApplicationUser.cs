using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace GigMatcher.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [ForeignKey("Musician")]
        public virtual Guid MusicianId { get; set; }

        public virtual Musician Musician { get; set; }
    }
}
