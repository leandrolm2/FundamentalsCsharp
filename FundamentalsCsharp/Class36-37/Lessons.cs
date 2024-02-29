using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Class36_37
{
    internal class Lessons
    {
        public static void WorkWithNonAndPrimitiveTypes()
        {
            // Primitive Types (int)
            var a = 10;        // Initialize variable 'a' with the value 10
            var b = a;         // Create a new variable 'b' and assign the value of 'a' to it
            b++;               // Increment the value of 'b' by 1
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));  // Output the values of 'a' and 'b'

            // Non-Primitive Types (Array)
            var array1 = new int[3] { 1, 2, 3 };  // Initialize an array 'array1' with values 1, 2, and 3
            var array2 = array1;                   // Create a new variable 'array2' and assign the reference of 'array1' to it
            array2[0] = 0;                         // Modify the first element of 'array2'
            Console.WriteLine($"array[0]: {array1[0]}, array2[0]: {array2[0]}");  // Output the values of array elements
        }

    }
}
