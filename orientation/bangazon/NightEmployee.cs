using System;
using System.Collections.Generic;
using System.Linq;

namespace bangazon
{
    public class NightEmployee : Employee, INightShift
    {
        public NightEmployee(string first, string last) : base(first, last)
        {
        }

        public bool nightShift { get; set;} = true;
    }
}