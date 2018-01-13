using System;
using System.Collections.Generic;
using System.Linq;

namespace bangazon
{
    class Program
    {
        public static void Main() 
        {   

            List<Department> departments = new List<Department>();

            Marketing marketingDept = new Marketing("Marketing", "Jay Bob", 14);
            marketingDept.addMarketingIdea("botNet", "buy bots and flood the internet with our product");
            marketingDept.SetBudget(marketingDept.baseBudget);
            departments.Add(marketingDept);
            

            CustomerService customerServiceDept = new CustomerService("Customer Service", "Dwayne The Rock Johnson", 3 );
            customerServiceDept.addScript("Customer Retention", "Please do not quit our service you are the best customer we have ever had and we love you like we love out pet pig Harold");
            customerServiceDept.SetBudget(customerServiceDept.baseBudget);
            departments.Add(customerServiceDept);
            foreach (Department d in departments)
            {
                Console.WriteLine($"{d.departmentName}:");
                Console.WriteLine($"Budget:{d.budget}");
                Console.WriteLine(" ");
            }

            Employee jayBob = new Employee("Jay", "Bob");
            Employee joeSchmoe = new Employee("Joe", "Schmoe");
            Employee danSchman = new Employee("Dan", "Schman");
            Employee harrisBuchannon = new Employee("Harris", "Buchannon");
            Employee toddFellows = new Employee("Todd", "Fellows");
            Employee ronaldCools = new Employee("Ronald", "Cools");

            List<Employee> Employees = new List<Employee>()
            {
                jayBob,
                joeSchmoe,
                danSchman,
                harrisBuchannon,
                toddFellows,
                ronaldCools
            };

            string jaysLunchSpot = jayBob.eat();
            joeSchmoe.eat("Fried Veggies");
            toddFellows.eat(Employees);
            ronaldCools.eat("Mega Combo Deluxe", Employees);

            Console.WriteLine(" ");

            HandicapEmployee BartPhillips = new HandicapEmployee("Bart", "Phillips");
            HandicapEmployee ToddJefferies = new HandicapEmployee("Todd", "Jefferies");
            SummerEmployee TiffanyLewis = new SummerEmployee("Tiffany", "Lewis");
            DayEmployee AndreaSlovjic = new DayEmployee("Andrea", "Slovjic");
            NightEmployee JesseFortana = new NightEmployee("Jesse", "Fortana");
            SummerEmployee PipBopkins = new SummerEmployee("Pip", "Bopkins");
            NightEmployee LilJoe = new NightEmployee("Lil", "Joe");
            DayEmployee MarthaBudglet = new DayEmployee("Martha", "Budglet");

            marketingDept.AddEmployee(BartPhillips);
            marketingDept.AddEmployee(TiffanyLewis);
            marketingDept.AddEmployee(AndreaSlovjic);
            marketingDept.AddEmployee(JesseFortana);
            customerServiceDept.AddEmployee(ToddJefferies);
            customerServiceDept.AddEmployee(PipBopkins);
            customerServiceDept.AddEmployee(LilJoe);
            customerServiceDept.AddEmployee(MarthaBudglet);
            marketingDept.AddEmployee(harrisBuchannon);
            marketingDept.AddEmployee(danSchman);
            customerServiceDept.AddEmployee(toddFellows);
            customerServiceDept.AddEmployee(jayBob);

            foreach (Department d in departments)
            {
                Console.WriteLine($"{d.departmentName}:");
                List<Employee> _employees = d.Employees;
                foreach (Employee employee in _employees)
                {
                    string employeeInfo = $"{employee.firstName} {employee.lastName}";
                    var hello = employee.GetType();
                    if (employee.GetType() == typeof(bangazon.HandicapEmployee))
                    {
                        employeeInfo += " is currently handicap with a broken arm.";
                    } 
                    else if (employee.GetType() == typeof(bangazon.NightEmployee))
                    {
                        employeeInfo += " works the night shift.";
                    }
                    else if (employee.GetType() == typeof(bangazon.DayEmployee))
                    {
                        employeeInfo += " works the day shift.";
                    }
                    else if (employee.GetType() == typeof(bangazon.SummerEmployee))
                    {
                        employeeInfo += " only works in the summer";
                    }
                    else 
                    {
                        employeeInfo += " is a regular full time employee.";
                    }
                    Console.WriteLine(employeeInfo);
                }
                    Console.WriteLine(" ");
            }    
        }
    }
}
