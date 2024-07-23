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
    }
}
