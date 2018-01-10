using System;
using System.Collections.Generic;
using System.Linq;

namespace bangazon{
    public class Department{
        public string departmentName;
        private string departmentSupervisor;
        private int numberOfEmployees;
        public Department (string name, string supervisor, int employeeCount) {
            departmentName = name;
            departmentSupervisor = supervisor;
            numberOfEmployees = employeeCount;
        }
        
    }
}
