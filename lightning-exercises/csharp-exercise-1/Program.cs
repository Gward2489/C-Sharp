using System;
using System.Collections.Generic;
using System.Linq;
namespace csharp_exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}; 

            // Add some more integers to the list
            // Iterate over the list and write only odd numbers to the console
            // The output should be on the same line.

            numbers.Add(21);
            numbers.Add(22);
            numbers.Add(23);

            foreach (int number in numbers){
                if (number % 2 != 0){
                    Console.Write(number + " ");
                }
            }

            // Given the following dictionary:
            Dictionary<string, int> transports = new Dictionary<string, int>(){{"bicycle", 2}};

            // Add some more items to the dictionary.
            // Iterate over the dictionary and write 'A ____ has ____ wheels' to the console.
            // Each transport should be on a new line.

            transports.Add("car", 4);
            transports.Add("plane", 0);
            transports.Add("unicycle", 1);
            Console.WriteLine("");
            foreach (KeyValuePair<string, int> vehicle in transports){
                Console.WriteLine($"A {vehicle.Key} has {vehicle.Value} wheels");
            }
        }
    }
}
