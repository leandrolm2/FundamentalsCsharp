using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Challengs.NoPrimitiveTypes
{
    public class Ch2
    {
        public static void FindTheMax()
        {
            Console.WriteLine("Digite two numbers and let the program find the max between then.");
            Console.Write("Type the first Number: ");

            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Type the Second Number: ");

            int secondNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"first number {firstNumber} is bigger than the second one {secondNumber}");
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine($"Second number {secondNumber} is bigger than the first one {firstNumber}");
            }
            else
            {
                Console.WriteLine($"Both numbers have the same lenght");
            }

        }
    }
}
