using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace FundamentalsCsharp.Challengs.WorkWithText
{
    internal class Ch5
    {
        public static void howManyVowels()
        {
            Console.WriteLine("Type any word and we will tell you how many vowels there is on that word");
            var stringWord = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(stringWord))
            {
                Console.WriteLine("Please, Type any valid");
                stringWord = Console.ReadLine();
            }

            Console.WriteLine(Utils.NumberOfVowels(stringWord));
        }
    }
}
