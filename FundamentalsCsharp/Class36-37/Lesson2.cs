using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Class36_37
{
    public class Lesson2
    {
        public class PersonAge
        {
            public int Age;
        }

        public static void Increment(int number) 
        {
            number += 10;
        }

        public static void MakeOld(PersonAge person) 
        {
            person.Age += 10;
        }
    }
}
