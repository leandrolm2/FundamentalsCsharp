using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Challengs.NoPrimitiveTypes
{
    public class Ch1
    {
        public static void IsNumberValid()
        {
            Console.Write("Digite a number: ");

            string isNumberValid = Console.ReadLine();
            if (!int.TryParse(isNumberValid, out int intValue))
            {
                Console.WriteLine("Only number are acceptable!");
                return;
            }

            int numberWrite = int.Parse(isNumberValid);
            if (numberWrite >= 1 && numberWrite <= 10)
                Console.WriteLine("It's a valid NUmber.");
            else
                Console.WriteLine("That's a invalid number.");
        }
    }
}
