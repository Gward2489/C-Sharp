using System;
using System.Collections.Generic;
using System.Linq;


namespace classes
{
    public class Employee
    {

        public string employeeFirstName {get; set;}
        public string employeeLastName {get; set;}
        public DateTime hiredOn {get; set;}
        public string employeejobTitle {get; set;}

        public Employee (string firstName, string lastName, string jobTitle)
        {
            this.employeeFirstName = firstName;
            this.employeeLastName = lastName;
            this.hiredOn = new DateTime();
            this.employeejobTitle = jobTitle;
        }
    }
}