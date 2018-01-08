using System;
using System.Collections.Generic;
using System.Linq;

namespace classes
{
    public class Company
    {
        /* 
            Some readonly properties
        */
        public string Name {get; set;}

        public DateTime CreatedOn { get; set;}

        public List<Employee> employees {get; set;}

        public void addEmployee (Employee newEmployee) 
            {
                employees.Add(newEmployee);
            }
        
        public void removeEmployee (Employee key)
            {
                employees.Remove(key);
            }

        public Company (string companyName)
            {
                this.Name = companyName;
                this.CreatedOn = new DateTime();
                this.employees = new List<Employee>();  
            }

        public void ListEmployees() 
            {
                foreach (Employee Employee in employees) {
                    Console.WriteLine($"{Employee.employeeFirstName}");
                }
            }
    }
}