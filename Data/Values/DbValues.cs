using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Values
{
    public class DbValues : IDbValues
    {
        public GigStatusValues GigStatus { get => new GigStatusValues(); }

        public ApplicationStatusValues ApplicationStatus { get => new ApplicationStatusValues(); }

        public PositionStatusValues PositionStatus { get => new PositionStatusValues(); }

        public InstrumentTypeValues IntrumentType { get => new InstrumentTypeValues();  }
    }
}
