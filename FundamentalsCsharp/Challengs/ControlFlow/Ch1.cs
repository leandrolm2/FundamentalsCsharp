﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCsharp.Challengs.ControlFlow
{
    public class Ch1
    {
        public static void HowManyDiviseBy()
        {
            int howMuchIsDivisible = 0;

            for (int i = 0; i <= 100; i++)
            {
                if(i % 3 == 0) howMuchIsDivisible++;
            }

            Console.WriteLine($"There's {howMuchIsDivisible} that are divisible by 3 between 1 and 100");
        }

        public static void FactoringNumber()
        {
            Console.Write("Please type the number you want to see the factorial: ");
            string numberToFactorial = Console.ReadLine();

            if (int.TryParse(numberToFactorial, out int isNumber))
            {
                int result = 1;

                for (int i = isNumber; i >= 1; i--)
                {
                    result *= i;
                }

                Console.WriteLine($"The factorial of {isNumber} is: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        public static void FindMaxOfNumbers()
        {
            Console.Write("Find the max beetwen all number you send to the program. To exit  e have the result send any letter and not a number.");

            var maxNumber = 0;
            List<int> numbers = new List<int>();

            while (true)
            {
                Console.Write("Please enter a number  otherwise, type a letter to finish the application: ");

                var hasNumber = Console.ReadLine();
                if (String.IsNullOrEmpty(hasNumber))
                {
                    Console.WriteLine("blanck space not allowed, read the instrutions and try again.");
                    continue;
                }

                if (int.TryParse(hasNumber, out int isNumber))
                {
                    numbers.Add(isNumber);
                    Console.WriteLine($"You add: {isNumber} to the list of numbers!");
                    continue;
                }

                break;
            }


            foreach(int number in  numbers)
            {
                maxNumber = maxNumber < number ? number : maxNumber;
            }

            Console.WriteLine($"The max number between the ones you sent is {maxNumber}");
        }

        public static void TypeANumber()
        {
            Console.WriteLine("Type a Number to sum if the previous one or type 'ok' to exit.");
            Console.WriteLine();
            int sumOfNumbers = 0;
            int isNumber = 0;

            while (true)
            {
                Console.Write("Digite the command: ");

                var hasSome = Console.ReadLine();
                if(String.IsNullOrEmpty(hasSome))
                {
                    Console.WriteLine("blanck space not allowed, read the instrutions and try again.");
                    continue;
                }
                if (int.TryParse(hasSome, out isNumber))
                {
                    sumOfNumbers += isNumber;
                    Console.WriteLine($"Running total: {sumOfNumbers}");
                    continue;
                }

                if(hasSome == "ok")
                {
                    Console.WriteLine($"The some of all number you pass is {sumOfNumbers}");
                    break;
                }

                Console.WriteLine($"'{hasSome}' it's a invalide command, read the instrutions and try again.");
                Console.WriteLine();
                continue;
            }
        }

        public static void GuessTheNumber()
        {
            Console.WriteLine("Guess the number! You have only 4 guesses.");
            Console.WriteLine();
            Random random = new Random();
            int randomNumber = random.Next(1, 11);
            int howManyGuesses = 1;
            int isNumber = 0;
            while (true)
            {
                Console.Write("Digite a number between 1 and 10: ");

                var numberGuessesd = Console.ReadLine();
                if (String.IsNullOrEmpty(numberGuessesd))
                {
                    Console.WriteLine("blanck space not allowed, read the instrutions and try again.");
                    continue;
                }
                if (int.TryParse(numberGuessesd, out isNumber))
                {

                    if(isNumber >= 1 && isNumber <= 10)
                    {
                        howManyGuesses++;
                        if (howManyGuesses > 4)
                        {
                            Console.WriteLine($"You run out of guesses and lost the game. T-T");
                            Console.WriteLine($"The random number was {howManyGuesses}");
                            break;
                        }

                        if (howManyGuesses <= 4 && isNumber == randomNumber)
                        {
                            Console.WriteLine($"CORRECT GUESS! THE NUMBER REALLY IS {randomNumber}!");
                            break;
                        }

                        Console.WriteLine($"Wrong guess... you only have ({4 - howManyGuesses}) left.");
                        Console.WriteLine(howManyGuesses);
                        continue;
                    }

                    Console.WriteLine($"The number {isNumber} it's not a integer number between 1 and 10, read the instrutions and try again.");
                    continue;
                }
                

                Console.WriteLine($"'{numberGuessesd}' it's a invalide command, read the instrutions and try again.");
                Console.WriteLine();
                continue;
            }
        }


    }
}
