using System;
using System.Collections.Generic;
using System.Linq;

namespace bangazon
{
    public class Marketing : Department, ISecurityClearance
    {
        public List<Dictionary<string, string>> marketingIdeas {get; set;} = new List<Dictionary<string, string>>();
        public bool securityClearance { get;} = true;

        public Marketing(string name, string supervisor, int employeeCount) : base(name, supervisor, employeeCount)
        {
        }

        public void addMarketingIdea(string ideaName, string idea){
            Dictionary<string, string> marketingIdea = new Dictionary<string, string>();
            marketingIdea.Add(ideaName, idea);
            marketingIdeas.Add(marketingIdea);
        }

        public override void SetBudget(double deptBudget) => this.budget = (deptBudget += 15000);
    }
}