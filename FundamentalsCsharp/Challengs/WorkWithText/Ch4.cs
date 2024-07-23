using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Challengs.WorkWithText
{
    internal class Ch4
    {
        public static void PascalizeText() 
        {
            Console.WriteLine("Type any text and we will made them in pascalCase");
            var text = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Please, Type any text and we will made them in pascalCase");
                text = Console.ReadLine();
            }
            Console.WriteLine(Utils.Pascalize(text));
        }
    }
}
