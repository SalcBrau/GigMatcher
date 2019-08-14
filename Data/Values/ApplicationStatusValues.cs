using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Values
{
    public class ApplicationStatusValues : ValueList
    {
        public readonly Value Submitted = new Value(1, "Submitted");
        public readonly Value Declined = new Value(2, "Declined");
        public readonly Value Withdrawn = new Value(3, "Withdrawn");
        public readonly Value Accepted = new Value(4, "Accepted");

        internal ApplicationStatusValues()
        {
            states.Add(Submitted);
            states.Add(Declined);
            states.Add(Withdrawn);
            states.Add(Accepted);
        }
    }
}
