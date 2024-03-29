﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GigMatcher.Data.Entities
{
    public class MusicianInstrument
    {
        [Required]
        [ForeignKey("Musician")]
        public int MusicianId { get; set; }

        [Required]
        [ForeignKey("Instrument")]
        public int InstrumentId { get; set; }

        public virtual Musician Musician { get; set; }
        public virtual Instrument Instrument { get; set; }
    }
}
