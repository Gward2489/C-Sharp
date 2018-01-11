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

            string jaysLunchSpot = jayBob.eat(jayBob);
        }
    }
}
