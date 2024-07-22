using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Class64
{
    internal class Lessons
    {
        public static void WorkWithString()
        {
            var fullName = "Leandro Melgarejo ";

            Console.WriteLine("Trim: '{0}'",  fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'",  fullName.Trim().ToUpper());
            Console.WriteLine("ToUpper: '{0}'",  fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');

            var firstName = fullName.Substring(0, index);
            var lastName =  fullName.Substring(index + 1);

            Console.WriteLine("firstName: '{0}'", firstName);
            Console.WriteLine("lastName: '{0}'", lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("firstName: {0}", names[0]);
            Console.WriteLine("lastName: {0}", names[1]);

            Console.WriteLine(fullName.Replace("leandro", "leonardo"));

           if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
