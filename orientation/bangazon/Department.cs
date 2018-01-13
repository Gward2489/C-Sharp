using System;
using System.Collections.Generic;
using System.Linq;

namespace bangazon{
    public class Department{

        public double baseBudget = 33000; 
        public double budget {get; set;} = 0;
        public string departmentName {get; set;}
        public string departmentSupervisor {get; set;}
        private int numberOfEmployees {get; set;}
        private List<Employee> _employees {get; set;} = new List<Employee>();
        public List<Employee> Employees 
        {
            get
            {
                return _employees;
            }
        }
        public void AddEmployee (Employee employee)
        {
            _employees.Add(employee);
        }
        public void RemoveEmployee (Employee employee)
        {
            _employees.Remove(employee);
        }
        public Department (string name, string supervisor, int employeeCount) {
            departmentName = name;
            departmentSupervisor = supervisor;
            numberOfEmployees = employeeCount;
        }

        public virtual void SetBudget(double deptBudget) => this.budget = deptBudget;
        
    }
}
