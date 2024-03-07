using System;
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
