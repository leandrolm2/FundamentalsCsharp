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
            // Creating a Person object and introducing them
            Person leandro = new Person();
            leandro.FirstName = "Leandro";
            leandro.LastName = "Melgarejo";
            leandro.Age = 28;
            leandro.Introduce();
            Console.WriteLine();

            // Performing arithmetic operations using the Calculator class
            Calculator calculator = new Calculator();
            // Visual representation of what's happening
            var result = calculator.Add(14, 14);
            Console.WriteLine(result);

            // Short way to perform addition
            Console.WriteLine(calculator.Add(15, 15));
            Console.WriteLine();

            // Working with arrays
            Console.WriteLine("Working with Arrays:");
            Class31.WorkingWithArray.Arrays();
            Console.WriteLine();

            // Working with strings
            Console.WriteLine("Working with Strings:");
            Class3233.Lessons.WorkWithString();
            Console.WriteLine();

            // Working with enums
            Console.WriteLine("Working with Enums:");
            Class3435.Lessons.WorkWithEnums();
            Console.WriteLine();

            // Working with non-primitive types
            Console.WriteLine("Working with Non-Primitive Types:");
            Class36_37.Lessons.WorkWithNonAndPrimitiveTypes();
            // The value stored in this number, located in a different memory location than the incremented number within the main method,
            // lacks significance when accessed outside the main method.
            var number = 1;
            Class36_37.Lesson2.Increment(number);
            Console.WriteLine(number);
            Console.WriteLine();

            // Creating and using a PersonAge object
            Console.WriteLine("Working with PersonAge:");
            PersonAge person = new PersonAge() { Age = 28 };
            Console.WriteLine(person.Age); // Print the current age of the person (should be 28)

            // Call the static method MakeOld from the Lesson2 class, passing the instance of the PersonAge class as an argument
            Class36_37.Lesson2.MakeOld(person);

            // Print the age of the person after calling the MakeOld method
            Console.WriteLine(person.Age); // The age should now be 38 (28 + 10)
            Console.WriteLine();

            // Working with if statements
            Console.WriteLine("Working with If Statements:");
            Class41_42.Lessons.IfStates();
            Console.WriteLine();

            // Working with switch statements
            Console.WriteLine("Working with Switch Statements:");
            Class41_42.Lessons2.StateSwitch();
            Console.WriteLine();

            // Displaying a section header for challenges
            Console.WriteLine("==================================================================================");
            Console.WriteLine("CHALLENGES!!!");
            //Challengs.NoPrimitiveTypes.Ch1.IsNumberValid();
            //Challengs.NoPrimitiveTypes.Ch2.FindTheMax();
            //Challengs.NoPrimitiveTypes.Ch3.speedLimit();

            //Challengs.ControlFlow.Ch1.HowManyDiviseBy();
            //Challengs.ControlFlow.Ch1.TypeANumber();
            //Challengs.ControlFlow.Ch1.GuessTheNumber();
            //Challengs.ControlFlow.Ch1.FactoringNumber();
            //Challengs.ControlFlow.Ch1.FindMaxOfNumbers();

            //Challengs.ArraysAndLists.Ch1.displayFriendsName();
            //Challengs.ArraysAndLists.Ch2.reverseName();
            //Challengs.ArraysAndLists.Ch3.sortNumbers();
            //Challengs.ArraysAndLists.Ch4.DisplayNumbers();
            Challengs.ArraysAndLists.Ch5.ThreeSmallestFromTheList();

            Console.WriteLine("==================================================================================");

            //Workin with loops
            Console.WriteLine("Working with with loops:");
            Class44_45_46_47.Lessons.ForLoops();
            //Class44_45_46_47.Lessons.ForEachLoops();
            //Class44_45_46_47.Lessons.WhileLoops();
            Console.WriteLine();

            //Workin with method random
            Console.WriteLine("Workin with method random:");
            Class48.Lessons.RandomMethod();

            //Workin with Arrays
            Console.WriteLine("Workin with Arrays:");
            Class52_53.Lessons.WorkWithArray();

            //work with List
            Class54_55.Lessons.WorkWithlist();

        }
    }
}

