using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Challengs.WorkWithText
{
    internal class Ch1
    {
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

        public static void isNumberConsecutive()
        {
            Console.WriteLine("Type any order of number, and we will tell you if it is a consecutive order or not");
            var arrayStringNumber = Console.ReadLine();

            while(String.IsNullOrWhiteSpace(arrayStringNumber)) 
            {
                Console.WriteLine("Please, type any valid order of number, and we will tell you if it is a consecutive order or not");
                arrayStringNumber = Console.ReadLine();
            }

            List<int> numbers = VerifyNumbers(arrayStringNumber);
            bool isConsecutive = true;

            for (int i = 1; i < numbers.Count; i++)
            {
                int diference = numbers[i] - numbers[i - 1];
                Console.WriteLine(diference);
                if (diference != 1 && diference != -1) 
                {
                    isConsecutive = false;
                    break; 
                }
            }
            Console.WriteLine(isConsecutive);
            var message = isConsecutive ? "The numbers you sent are consecutive" : "The numbers you sent are not consecutive";
            Console.WriteLine(message);
        }
    }
}
