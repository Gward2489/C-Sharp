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

        public string eat ()
        {
            Random magicNumber = new Random();
            int restaurantChoiceId = magicNumber.Next(0, 6);
            string lunchSpot = "";
            foreach (string restaurant in restaurantOptions)
            {
                int index = restaurantOptions.FindIndex(a => a == restaurant);
                if (index == restaurantChoiceId)
                {
                    Console.WriteLine($"{this.firstName} is eating lunch at {restaurant}");
                    lunchSpot = restaurant;
                }
            }
                return lunchSpot;
        }
        public void eat (string lunchItem)
        {
            Console.WriteLine($"{this.firstName} ate {lunchItem} at the office today");
        }

        public void eat (List<Employee> companions)
        {
            List<Employee> lunchBuddies = new List<Employee>();
            lunchBuddies.AddRange(companions);            
            Random magicNumber = new Random();
            int restaurantChoiceId = magicNumber.Next(0, 6);
            int iAmTheBuddy = 0;
            foreach (Employee buddy in lunchBuddies)
            {
                if (this.firstName == buddy.firstName && this.lastName == buddy.lastName)
                {
                    iAmTheBuddy = lunchBuddies.FindIndex(a => a == buddy);
                }
            }
            lunchBuddies.RemoveAt(iAmTheBuddy);
            foreach (string restaurant in restaurantOptions)
            {
                int index = restaurantOptions.FindIndex(a => a == restaurant);
                if (index == restaurantChoiceId)
                {
                     string buddies = "";
                     int buddyCount = lunchBuddies.Count - 1;
                     foreach (Employee buddy in lunchBuddies)
                     {
                        int buddyDex = lunchBuddies.FindIndex(a => a == buddy);
                        if (buddyDex == buddyCount)
                        {
                            buddies += $"and {buddy.firstName}";
                        } else 
                        {
                            buddies += $"{buddy.firstName}, ";
                        }
                     }

                    Console.WriteLine($"{this.firstName} is eating lunch at {restaurant} along with {buddies}.");

                }
            }   
        }
        public void eat (string food, List<Employee> companions)
        {
            List<Employee> lunchBuddies = new List<Employee>();
            lunchBuddies.AddRange(companions);
            Random magicNumber = new Random();
            int restaurantChoiceId = magicNumber.Next(0, 6);
            int iAmTheBuddy = 0;
            foreach (Employee buddy in lunchBuddies)
            {
                if (this.firstName == buddy.firstName && this.lastName == buddy.lastName)
                {
                    iAmTheBuddy = lunchBuddies.FindIndex(a => a == buddy);
                }
            }
            lunchBuddies.RemoveAt(iAmTheBuddy);
            foreach (string restaurant in restaurantOptions)
            {
                int index = restaurantOptions.FindIndex(a => a == restaurant);
                if (index == restaurantChoiceId)
                {
                     string buddies = "";
                     int buddyCount = lunchBuddies.Count - 1;
                     foreach (Employee buddy in lunchBuddies)
                     {
                        int buddyDex = lunchBuddies.FindIndex(a => a == buddy);
                        if (buddyDex == buddyCount)
                        {
                            buddies += $"and {buddy.firstName}";
                        } else 
                        {
                            buddies += $"{buddy.firstName}, ";
                        }
                     }

                    Console.WriteLine($"{this.firstName} is eating a {food} at {restaurant} along with {buddies}.");

                }
            }   
        }
    }
}