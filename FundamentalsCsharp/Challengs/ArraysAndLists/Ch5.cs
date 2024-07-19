using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Challengs.ArraysAndLists
{
    internal class Ch5
    {
        public static List<int> SortArray(List<int> number)
        {
            List<int> sortedNumbers = new List<int>();

            for (int i = 0; i < number.Count - 1; i++)
            {
                for (int j = 0; j < number.Count - i - 1; j++)
                {
                    if (number[j] > number[j + 1])
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

            return sortedNumbers;

        }

        public static List<int> VerifyNumbers(string input)
        {
            string pattern = @"\d+";

            List<int> numbers = new List<int>();

            foreach (Match match in Regex.Matches(input, pattern))
            {
                numbers.Add(int.Parse(match.Value));
            }

            return numbers;
        }

        public static void ThreeSmallestFromTheList()
        {
            bool stopLoop = false;

            while(stopLoop)
            {
                Console.WriteLine("Type five number divide by cotes");
                string listNumbers = Console.ReadLine();

                List<int> numbers = VerifyNumbers(listNumbers);

                if (numbers.Count < 5)
                {
                    Console.WriteLine("Invalid List! The list has to have at least 5 valid int numbers");
                } else
                {
                    List<int> sortedNumbers = SortArray(numbers);
                    Console.WriteLine($"The 3 smoles nuumbers that you pass in the list are {sortedNumbers[0]}, {sortedNumbers[1]}, {sortedNumbers[2]}");
                }
            }
        }
    }
}
