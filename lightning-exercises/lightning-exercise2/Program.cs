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



            List<int> numbers = new List<int>(){ 23, 45, 36, 39, 102, 493, 474, 34, 11, 35, 99 };

            // Using Linq...
            // 1. Find the sum of numbers
            int sum = numbers.Sum();


            // 2. Find the average of the numbers
            double average = numbers.Average();

            // 3. Create a new List of numbers greater than 30

            List<int> newNumbers = new List<int>();

            foreach(int numb in numbers){
                if (numb > 30){
                    newNumbers.Add(numb);
                }
            }

        }
    }
}
