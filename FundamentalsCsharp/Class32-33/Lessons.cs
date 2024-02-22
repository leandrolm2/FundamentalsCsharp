using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Class3233
{
    class Lessons
    {
        public static void WorkWithString()
        {
            var firsName = "Leanlm";
            var lastName = "Hamedani";

            //ways to concatenate a string
            var fullName = firsName + " " +lastName;

            var myFullName = string.Format("My name is {0} {1}", firsName, lastName);

            var names =  new string[3] { "John", "Jane", "Jay-z" };

            var formattedNames = string.Join(", ", names);
            

            var text = @"Hi leandro!
This a more legible way to use:
backslache, new line";
            Console.WriteLine(text);
        }

    }
}
