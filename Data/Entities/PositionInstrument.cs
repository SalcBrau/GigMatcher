using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GigMatcher.Data.Entities
{
    public class PositionInstrument
    {
        public Guid PositionId { get; set; }

        public Guid InstrumentId { get; set; }

        public virtual Position Position { get; set; }
        public virtual Instrument Instrument { get; set; }
    }
}
