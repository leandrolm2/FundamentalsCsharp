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
    }
}
