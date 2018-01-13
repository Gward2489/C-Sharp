using System;
using System.Collections.Generic;
using System.Linq;

namespace bangazon
{
    public class DayEmployee : Employee, IDayShift
    {
        public DayEmployee(string first, string last) : base(first, last)
        {
        }

        public bool dayShift { get; set;} = true;
    }
}