using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Values
{
    public class GigStatusValues : ValueList
    {
        public readonly Value Open = new Value(1, "Open");
        public readonly Value Closed = new Value(2, "Closed");

        internal GigStatusValues()
        {
            states.Add(Open);
            states.Add(Closed);
        }
    }
}
