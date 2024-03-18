using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Class52_53
{
    public class Lessons
    {
        internal static void WorkWithArray()
        {
            var numbers = new int[]{ 1, 2, 3, 4, 5 };

            Console.WriteLine("Lenght: " + numbers.Length);

            //indexOf
            var indexFound = Array.IndexOf(numbers, 4);
            Console.WriteLine(indexFound);

            //Clear()
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of Clear()");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var item in another)
            {
                Console.WriteLine(item);
            }

            //Sort()
            Array.Sort(numbers);

            Console.WriteLine("Effect of Sort()");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //Reverse()
            Array.Reverse(numbers);

            Console.WriteLine("Effect of Reverse()");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
