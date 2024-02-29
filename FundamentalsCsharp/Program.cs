// See https://aka.ms/new-console-template for more information
using FundamentalsCsharp.Class28;
using FundamentalsCsharp.Class28.Math;
using FundamentalsCsharp.Class36_37;
using static FundamentalsCsharp.Class36_37.Lesson2;

namespace FundamentalsCsharp
{

    class Program
    {
        public static void Main(string[] args)
        {
            Person leandro = new Person();
            leandro.FirstName = "Leandro";
            leandro.LastName = "Melgarejo";
            leandro.Age = 28;

            leandro.Introduce();

            Calculator calculator = new Calculator();
            //visual to whats is happening
            var result = calculator.Add(14, 14);
            Console.WriteLine(result);

            //short way to do
            Console.WriteLine(calculator.Add(15, 15));

            //Work with arrays
            Class31.WorkingWithArray.Arrays();

            //work with string
            Class3233.Lessons.WorkWithString();

            //work with enums
            Class3435.Lessons.WorkWithEnums();

            //PrimitiveTpes
            Class36_37.Lessons.WorkWithNonAndPrimitiveTypes();
            //The value stored in this number, located in a different memory location than the incremented number within the main method, lacks significance when accessed outside the main method.
            var number = 1;
            Class36_37.Lesson2.Increment(number);
            Console.WriteLine(number);


            // Create a new instance of the PersonAge class and initialize the Age property with the value 28
            PersonAge person = new PersonAge() { Age = 28 };
            Console.WriteLine(person.Age); // Print the current age of the person (should be 28)

            // Call the static method MakeOld from the Lesson2 class, passing the instance of the PersonAge class as an argument
            Class36_37.Lesson2.MakeOld(person);

            // Print the age of the person after calling the MakeOld method
            Console.WriteLine(person.Age); // The age should now be 38 (28 + 10)

        }
    }

}
