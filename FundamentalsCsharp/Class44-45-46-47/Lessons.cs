using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Class44_45_46_47
{
    public class Lessons
    {
        public static void ForLoops() 
        {
            for (var i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void ForEachLoops() 
        {
            var name = "John Smith";

            //The loop starts at index 0, and iterates up to and including the last index of the string.
            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            //that's a clean way of doing loops
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
        }

        public static void WhileLoops()
        {

            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();

                if(!String.IsNullOrEmpty(input))
                {
                    Console.Write($"@Echo: {input}");
                    Console.WriteLine();
                    continue;
                }
                break;
            }
        }
    }
}
