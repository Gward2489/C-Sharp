using System;
using System.Collections.Generic;
using System.Linq;

namespace bangazon
{
    public class HandicapEmployee : Employee, IHandicap
    {
        public HandicapEmployee(string first, string last) : base(first, last)
        {
        }

        public bool brokenArm { get; set;} = true;
    }
}