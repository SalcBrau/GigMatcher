using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Values
{
    public class PositionStatusValues : ValueList
    {
        public readonly Value Open = new Value(1, "Open");
        public readonly Value Closed = new Value(2, "Closed");

        internal PositionStatusValues()
        {
            states.Add(Open);
            states.Add(Closed);
        }
    }
}
