using System;
using System.Collections.Generic;
using System.Linq;

namespace bangazon
{
    public class SummerEmployee : Employee, ISummerEmployee
    {
        public SummerEmployee(string first, string last) : base(first, last)
        {
        }

        public List<string> MonthsOfEmployment = new List<string>(){
            "June",
            "July",
            "August",
            "September",
        };

        List<string> ISummerEmployee.MonthsOfEmployment {get; set;}
    }
}