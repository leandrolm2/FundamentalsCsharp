// See https://aka.ms/new-console-template for more information
using FundamentalsCsharp.Class28;
using FundamentalsCsharp.Class28.Math;

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
        }
    }

}
