using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Challengs.WorkWithText
{
    internal class Ch2
    {
        public static void DisplayDuplicate()
        {
            Console.WriteLine("Pass a list of number sepate by a hyphen");
            var numbers = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(numbers))
            {
                Console.WriteLine("Please, type any valid number, do not send null or blanck space");
                numbers = Console.ReadLine();
            }

            var listNumber = Utils.VerifyNumbers(numbers);
            var message = Utils.HasDuplicated(listNumber) ? "DUPLICATED" : "NO DUPLICATED NUMBER";
            Console.WriteLine(message);
        }
    }
}
