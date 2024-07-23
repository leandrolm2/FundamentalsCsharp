using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Challengs.WorkWithText
{
    internal class Ch3
    {
        public static void VerifyIfIsValidTime()
        {
            Console.WriteLine("Type any time in the 24-hour time format (e.g., 14:30):");
            var dataTime = Console.ReadLine();

            try
            {
                DateTime parsedDate = DateTime.ParseExact(dataTime, "HH:mm", CultureInfo.InvariantCulture);
                Console.WriteLine(parsedDate);
            }
            catch (FormatException)
            {
                Console.WriteLine("The input was not in the correct format.");
            }
        }
    }
}
