using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Class48
{
    public class Lessons
    {
        public static void RandomMethod() 
        {
            var random = new Random();

            const int passwordLength = 32;

            var buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0,26));
            }

            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
