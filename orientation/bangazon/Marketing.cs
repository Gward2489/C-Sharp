using System;
using System.Collections.Generic;
using System.Linq;

namespace bangazon
{
    public class Marketing : Department
    {
        public double budget {get; set;}
        public List<Dictionary<string, string>> marketingIdeas {get; set;} = new List<Dictionary<string, string>>();


        public Marketing(double budgetAmt, string name, string supervisor, int employeeCount) : base(name, supervisor, employeeCount)
        {
            budget = budgetAmt;
        }

        public void addMarketingIdea(string ideaName, string idea){
            Dictionary<string, string> marketingIdea = new Dictionary<string, string>();
            marketingIdea.Add(ideaName, idea);
            marketingIdeas.Add(marketingIdea);
        }


    }
}