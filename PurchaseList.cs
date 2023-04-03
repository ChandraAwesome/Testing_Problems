using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PurchaseList
    {
       public static void Orders()
        {
            Console.WriteLine("Enter the prices with space between");
            string[] prices = Console.ReadLine().Split(); // read space-separated prices
            HashSet<string> soldOnce = new HashSet<string>(); // set to store prices sold once
            HashSet<string> soldMultiple = new HashSet<string>(); // set to store prices sold multiple times

            for (int i = 0; i < prices.Length; i++)
            {
                string price = prices[i];
                if (soldMultiple.Contains(price)) // already sold multiple times
                {
                    continue;
                }
                else if (soldOnce.Contains(price)) // already sold once, move to soldMultiple set
                {
                    soldOnce.Remove(price);
                    soldMultiple.Add(price);
                }
                else // first time selling this price
                {
                    soldOnce.Add(price);
                }
            }

            Console.WriteLine("Prices sold only once:");
            foreach (string price in soldOnce)
            {
                Console.WriteLine(price);
            }

            Console.WriteLine("Prices sold more than once:");
            foreach (string price in soldMultiple)
            {
                Console.WriteLine(price);
            }
        }
    }

}
