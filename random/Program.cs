using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> randomNumbers = new List<int>();
            List<int> squaredNumbers = new List<int>();
            List<int> numbersToRemove = new List<int>();
            Random randomNumber = new Random();
            int counter = 0;

            do
            {
                int hotDigits = randomNumber.Next(1, 100);
                randomNumbers.Add(hotDigits);
                counter += 1;
            } while (counter < 20);  

            foreach(int numb in randomNumbers)
            {
                int bigNumber = numb * numb;
                squaredNumbers.Add(bigNumber);
            }

            foreach (int numb in squaredNumbers)
            {
                if (numb % 2 != 0)
                {
                    numbersToRemove.Add(numb);
                }
            }

            foreach (int numb in numbersToRemove)
            {
                squaredNumbers.Remove(numb);
            }
            
            foreach (int numb in squaredNumbers)
            {
                Console.WriteLine(numb);
            }
        }
    }
}
