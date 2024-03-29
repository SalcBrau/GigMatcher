﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GigMatcher.Data.Entities
{
    public class Instrument
    {   
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [ForeignKey("InstrumentType")]
        public int InstrumentTypeId { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public virtual InstrumentType InstrumentType { get; set; }
        public virtual ICollection<MusicianInstrument> MusicianInstruments { get; set; }
        public virtual ICollection<PositionInstrument> PositionInstruments { get; set; }
    }
}
