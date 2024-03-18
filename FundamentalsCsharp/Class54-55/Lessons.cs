using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Class54_55
{
    public class Lessons
    {
        public static void WorkWithlist()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            numbers.Add(1);
            numbers.AddRange(new int[3] {5,6,7});

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("last index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);

        }
    }
}
