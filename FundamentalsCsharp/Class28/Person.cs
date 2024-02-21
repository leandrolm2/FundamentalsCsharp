// See https://aka.ms/new-console-template for more information

namespace FundamentalsCsharp.Class28
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {FirstName} {LastName} and I'm {Age} years old");
        }
    }

}
