using System;
using System.Collections.Generic;
using System.Linq;

namespace bangazon
{
    public class Employee
    {
        public string firstName {get; set;}
        public string lastName {get; set;}
        public List<string> restaurantOptions = new List<string>()
        {
            "Pizza Palace",
            "Burger Land",
            "Holy Gyro",
            "The Cabbage Buffet",
            "The Gravy Bucket",
            "McFeinstein's Fine Hot Dogs and Fried Pickles"
        };

        public Employee (string first, string last)
        {
            this.firstName = first;
            this.lastName = last;
        }

        public string eat (Employee lunchEater)
        {
            Random magicNumber = new Random();
            int restaurantChoiceId = magicNumber.Next(0, 6);
            string lunchSpot = "";
            foreach (string restaurant in restaurantOptions)
            {
                int index = restaurantOptions.FindIndex(a => a == restaurant);
                if (index == restaurantChoiceId)
                {
                    Console.WriteLine($"{lunchEater.firstName} is eating lunch at {restaurant}");
                    lunchSpot = restaurant;
                }
            }
                return lunchSpot;
        }

    }
}