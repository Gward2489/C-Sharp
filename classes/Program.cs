using System;
using System.Collections.Generic;
using System.Linq;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Company EnterprisesSupreme = new Company ("Enterprises Supreme");

            Employee Garrett = new Employee ("Garrett", "Ward", "CEO");
            Employee DannyMcbride = new Employee ("Danny", "McBride", "CFO");
            Employee BillMurray = new Employee ("Bill", "Murray", "Master of Ceremonies");

            EnterprisesSupreme.addEmployee(Garrett);
            EnterprisesSupreme.addEmployee(DannyMcbride);
            EnterprisesSupreme.addEmployee(BillMurray);

            EnterprisesSupreme.ListEmployees();
        }
    }
}
