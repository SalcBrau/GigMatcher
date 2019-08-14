using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Values
{
    public class InstrumentTypeValues : ValueList
    {
        public readonly Value Percussion = new Value(1, "Percussion");
        public readonly Value Strings = new Value(2, "Strings");
        public readonly Value Brass = new Value(3, "Brass");
        public readonly Value Woodwinds = new Value(4, "Woodwinds");
        public readonly Value Keys = new Value(5, "Keys");

        internal InstrumentTypeValues()
        {
            states.Add(Percussion);
            states.Add(Strings);
            states.Add(Brass);
            states.Add(Woodwinds);
            states.Add(Keys);
        }
    }
}
