using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FundamentalsCsharp.Challengs.ArraysAndLists
{
    public class Ch3
    {
        public static void sortNumbers()
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Digite any numer: ");
            string input; // Get input from the user

            int number;

            while (numbers.Count < 5)
            {
                try
                {
                    Console.WriteLine($"Give us a number!");
                    input = Console.ReadLine();

                    number = int.Parse(input); // Attempt to convert to integer
                    if(numbers.IndexOf(number) == -1 ) 
                    {
                        numbers.Add(number);
                        Console.WriteLine($"Nice, you have give us {numbers.Count}/5 that you need!");
                    } else
                    {
                        Console.WriteLine($"The number {number} has been used, try another one.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            numbers.Sort();
            Console.WriteLine("\n");
            Console.WriteLine("Nice! We sorted the numbers you passed to us, they are in this order now!");
            Console.WriteLine("\n");

            foreach (int SortedNumber in numbers)
            {
                Console.Write(SortedNumber + " ");
            }
            Console.WriteLine("\n");

        }
    }
}
