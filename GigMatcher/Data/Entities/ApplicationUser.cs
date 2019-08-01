using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GigMatcher.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Instrument { get; set; } = "N/A";

        [Required]
        public int YearsPlaying { get; set; } = 0;

        [Required]
        public int YearsProfessionalExperience { get; set; } = 0;

        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                DateTime now = DateTime.Today;
                int age = now.Year - ((DateOfBirth == null) ?  DateOfBirth.Year : now.Year);
                if (DateOfBirth > now.AddYears(-age)) age--;
                return age;
            }
        }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public virtual ICollection<Gig> Gigs { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
    }
}
