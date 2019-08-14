using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Values
{
    public abstract class ValueList
    {
        protected List<Value> states = new List<Value>();

        public IEnumerable<Value> Values
        {
            get
            {
                return states;
            }
        }
    }
}
