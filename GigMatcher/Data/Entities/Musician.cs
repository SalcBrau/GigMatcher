using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GigMatcher.Data.Entities
{
    public class Musician
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [ForeignKey("User")]
        public String UserId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int YearsPlaying { get; set; } = 0;

        [Required]
        public int YearsProfessionalExperience { get; set; } = 0;

        [Required]
        public DateTime DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                DateTime now = DateTime.Today;
                int age = now.Year - ((DateOfBirth == null) ? DateOfBirth.Year : now.Year);
                if (DateOfBirth > now.AddYears(-age)) age--;
                return age;
            }
        }

        public int Rating { get; set; }

        public String Location { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Gig> Gigs { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
        public virtual ICollection<MusicianInstrument> MusicianInstruments { get; set; }
    }
}
