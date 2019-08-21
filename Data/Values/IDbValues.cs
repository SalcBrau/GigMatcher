using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Values
{
    public interface IDbValues
    {
        ApplicationStatusValues ApplicationStatus { get;  }

        GigStatusValues GigStatus { get; }

        PositionStatusValues PositionStatus { get; }

        InstrumentTypeValues IntrumentType { get; }
    }
}
