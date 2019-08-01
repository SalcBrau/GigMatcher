using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GigMatcher.Data.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string Instrument { get; set; }

        public ICollection<Gig> Gigs { get; set; }

        public ICollection<Application> Applications { get; set; }
    }
}
