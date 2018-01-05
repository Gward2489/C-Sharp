using System;
using System.Collections.Generic;
using System.Linq;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();

            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("IGC", "India Globalization Capital");
            stocks.Add("RCK", "Rock Masters");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "GM", shares: 150, price: 30.21));
            purchases.Add((ticker: "CAT", shares: 200, price: 17.84));
            purchases.Add((ticker: "IGC", shares: 45, price: 1.74));
            purchases.Add((ticker: "IGC", shares: 45, price: 2.01));
            purchases.Add((ticker: "RCK", shares: 95, price: 6.66));

            Dictionary<string, double> purchaseInfo = new Dictionary<string, double>();

            foreach ((string, int, double) purchase in purchases){
                double totalValue = purchase.Item3 * purchase.Item2;
                foreach (KeyValuePair<string, string> stockNames in stocks){
                    if (purchase.Item1 == stockNames.Key){
                        if(purchaseInfo.ContainsKey(stockNames.Value) == false){
                        purchaseInfo.Add(stockNames.Value, totalValue);
                        } else {
                            purchaseInfo[stockNames.Value] += totalValue;
                        }
                    }
                }
            }

            foreach (KeyValuePair<string, double> purchasedStock in purchaseInfo){
                Console.WriteLine($"{purchasedStock.Key}: ${purchasedStock.Value}");
            }
        }
    }
}
