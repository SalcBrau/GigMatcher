using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Values
{
    public class Value
    {
        public readonly int Id;
        public readonly string Name;

        public Value(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
