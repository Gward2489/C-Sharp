using System;
using System.Linq;
using System.Collections.Generic;


namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product,  int quantity, double amount)> transactions = new List<(string, int, double)>();
            
            (string name, int quantity, double price) productOne = ("Yo-yo", 1, 15.00);
            (string name, int quantity, double price) productTwo = ("Skateboard", 1, 70.50);
            (string name, int quantity, double price) productThree = ("Bicycle", 1, 340.92);
            (string name, int quantity, double price) productFour = ("Red Hat", 2, 24.99);
            (string name, int quantity, double price) productFive = ("Baseball Bat", 1, 38.87);

            transactions.Add(productOne);
            transactions.Add(productTwo);
            transactions.Add(productThree);
            transactions.Add(productFour);
            transactions.Add(productFive);

            int totalSalesQuantity = 0;
            double totalSalesRev = 0;

            foreach ((string, int, double) shopItem in transactions){
                totalSalesQuantity += shopItem.Item2;
                totalSalesRev += shopItem.Item3;
            };

            Console.WriteLine($"Total items sold today: {totalSalesQuantity}");
            Console.WriteLine($"Total revenue for the day: {totalSalesRev}");
        
        }
    }
}
