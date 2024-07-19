using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Challengs.ArraysAndLists
{
    internal class Ch4
    {
        public static void SortArray(List<int> number)
        {
            List<int> sortedNumbers = new List<int>();

            for ( int i = 0; i < number.Count - 1; i++ )
            {
                for (int j = 0; j < number.Count - i - 1; j++)
                {
                    if(number[j] > number[j + 1])
                    {
                        int temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                    }

                }
            }

            for (int i = 0; i < number.Count; i++)
            {
                if (sortedNumbers.IndexOf(number[i]) == -1)
                {
                    sortedNumbers.Add(number[i]);
                }
            }

            string stringSortedNumbers = string.Join(", ", sortedNumbers);

            Console.WriteLine($"The sorted number that you pass without the repeated numbers are {stringSortedNumbers}");
        }

        public static void DisplayNumbers()
        {
            
            List<int> numbers = new List<int>();

            string input = "";
            int number;

            while (input != "quit")
            {
                try
                {
                    Console.WriteLine("Type any valid number or 'quit', if you wanna exit the game");
                    input = Console.ReadLine();

                    if (input != "quit")
                    {
                        number = int.Parse(input); // Attempt to convert to integer
                        numbers.Add(number);
                        Console.WriteLine($"Nice, you have give us the number {number}, now youu have the numbers {String.Join(", ", numbers)} in your list!");
                    }
                }
                catch 
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
            SortArray(numbers);
        }
    }
}
