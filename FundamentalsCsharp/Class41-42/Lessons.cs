using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Class41_42
{
    internal class Lessons
    {

        public static void IfStates()
        {
            //one way to do
            bool isGoldCustomer = true;
            int hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }

            //short way
            float price;
            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;

            //even shorted way
            float prices = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine($"{price}, {prices}");
        }
    }
}
