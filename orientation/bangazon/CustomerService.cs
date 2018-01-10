using System;
using System.Collections.Generic;
using System.Linq;

namespace bangazon
{
    public class CustomerService : Department
    {
        public List<Dictionary <string, string>> scripts = new List<Dictionary<string, string>>();
        public CustomerService(string name, string supervisor, int employeeCount) : base(name, supervisor, employeeCount)
        {
        }
        public void addScript(string scriptName, string scriptText)
        {
            Dictionary<string, string> script = new Dictionary<string, string>();
            script.Add(scriptName, scriptText);
            scripts.Add(script);
        }
    }
}