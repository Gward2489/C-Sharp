using System;
using System.Collections.Generic;
using System.Linq;

namespace lightning_exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Dictionary with a key of type string and value type of double

            Dictionary<string, double> firstDictionary = new Dictionary<string, double>();

            // 2. Dictionary with key of type string and value of type List<int[]>

            Dictionary<string, List<int[]>> secondDictionary = new Dictionary<string, List<int[]>>();

            // 3. List of dictionaries with a key of type string and a value of type dictionary with a key of type int and value of type string

            List<Dictionary<string, Dictionary<int, string>>> thirdDictionary = new List<Dictionary<string, Dictionary<int, string>>>();

        }
    }
}
