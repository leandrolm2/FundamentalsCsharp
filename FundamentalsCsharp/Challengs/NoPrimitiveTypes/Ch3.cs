using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Challengs.NoPrimitiveTypes
{
    public class Ch3
    {
        public static void speedLimit()
        {
            Console.WriteLine("Speed camera simulation.");
            Console.Write("Type the speed limit.(ONLY THE NUMBERS, NOT THE KM): ");

            int speedLimit = int.Parse(Console.ReadLine());

            Console.Write("Type the speed of the car: ");

            int carSpeed = int.Parse(Console.ReadLine());

            if (carSpeed > speedLimit)
            {
                double demeritPoint = (carSpeed - speedLimit) / 5;
                string hasLicense = demeritPoint > 12 ? $"License Suspended,  {demeritPoint} demerit points" : $"you have, {demeritPoint} demerit points";
                Console.WriteLine(hasLicense);
            }
            else
            {
                Console.WriteLine($"{carSpeed} it's a acceptable velocity");
            }
        }
    }
}
