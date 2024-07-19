using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FundamentalsCsharp.Challengs.ArraysAndLists
{
    public class Ch2
    {

        public static void reverseName()
        {
            string name = "";
            Console.WriteLine("Digite any name: ");
            name = Console.ReadLine();

            while (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("Value can not be empty, digite any name so we may proced: ");
                name = Console.ReadLine();
            }

            List<char> nameLetters = name.ToCharArray().ToList();
            int howManyLetters = nameLetters.Count;
            string invertedName = "";

            for (int i = howManyLetters; i > 0; i--)
            {
                invertedName += nameLetters[i - 1];
            }

            Console.WriteLine(invertedName);
        }
    }
}
