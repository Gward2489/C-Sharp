using System;
using System.Collections.Generic;
using System.Linq;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> familyDictionary = new Dictionary<string, Dictionary<string, string>>();
            familyDictionary.Add("father", new Dictionary<string, string>(){
               {"name", "Bill"},
               {"age", "61"} 
            });
            familyDictionary.Add("mother", new Dictionary<string, string>(){
               {"name", "Kim"},
               {"age", "56"} 
            });
            familyDictionary.Add("sister", new Dictionary<string, string>(){
               {"name", "Lexie"},
               {"age", "23"} 
            });

            foreach (KeyValuePair<string, Dictionary<string, string>> fam in familyDictionary)
            {
                string famStatementPartOne = "";
                string famStatementPartTwo = "";
                foreach (KeyValuePair<string, string> info in fam.Value)
                {
                    if (info.Key == "name")
                    {
                        famStatementPartOne += $"{info.Value} is my {fam.Key}";
                    }
                    else if (info.Key == "age")
                    {
                        famStatementPartTwo += $" and is {info.Value} years old";
                    }
                }
                famStatementPartOne += famStatementPartTwo;
                Console.WriteLine(famStatementPartOne);
            }
        }
    }
}
