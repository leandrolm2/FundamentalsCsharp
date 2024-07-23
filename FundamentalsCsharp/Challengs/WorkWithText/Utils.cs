using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Challengs.WorkWithText
{
    internal class Utils
    {
        public static bool isConsecutive(List<int> numbers)
        {
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

            return isConsecutive;
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

        public static bool HasDuplicated(List<int> listNumber)
        {
            var duplited = new List<int>();
            bool hasDuplicated = false;

            for (int i = 0; i < listNumber.Count; i++)
            {
                Console.WriteLine(listNumber[i]);
                if (duplited.IndexOf(listNumber[i]) != -1)
                {
                    hasDuplicated = true;
                    break;
                }
                
                duplited.Add(listNumber[i]);
            }
            Console.WriteLine(hasDuplicated);
            return hasDuplicated;
        }

        public static string Pascalize(string text)
        {
            var words = text.Split(' ');
            string newText = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (i == 0)
                {
                    newText += words[i].ToLower();
                    continue;
                }

                string word = words[i];
                newText += char.ToUpper(word[0]) + word.Substring(1).ToLower();
            }

            return newText;
        }

        public static int NumberOfVowels(string text)
        {
            List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            int vowelsNumber = 0;
            for (int i = 0;i < text.Length; i++) 
            {
                if (vowels.IndexOf(text[i]) != -1)
                {
                    vowelsNumber++;
                }
            }

            return vowelsNumber;
        }
    }
}
