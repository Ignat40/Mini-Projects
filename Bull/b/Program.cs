using System;
using System.Data;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace BullsAndCows
{
    class Program
    {
        public static void Main()
        {
            GameLogic();
        }

        public static string GenerateNumber()
        {
            Random random = new();
            int numberToGuess = random.Next(1000, 10000);
            string toGuess = numberToGuess.ToString();
            Console.WriteLine(toGuess);
            return toGuess;
        }

        public static void GameLogic()
        {

            string toGuess = GenerateNumber();
            int attempts = 0;

            while (true)
            {

                Console.WriteLine("Your guess: ");
                string? userInput = Console.ReadLine();

                attempts++;
                int bulls = 0;
                int cows = 0;


                if (userInput.Length > toGuess.Length || userInput.Length < toGuess.Length || userInput[0] is '0')
                {
                    Console.WriteLine("Invalid Length or starts with null. Try again. ");
                }
                else
                {
                    for (int i = 0; i < userInput.Length; i++)
                    {
                        if (userInput[i] == toGuess[i])
                        {
                            bulls++;
                        }
                        else
                        {
                            for (int j = 0; j < userInput.Length; j++)
                            {
                                if (userInput[i] == toGuess[j])
                                {
                                    cows++;
                                    break;
                                }
                            }
                        }
                    }

                    Console.WriteLine($"Bulls: {bulls}, Cows: {cows}");

                    if (bulls == 4)
                    {
                        Console.WriteLine($"You Guessed it in {attempts} {(attempts < 2 ? "attempt" : "attempts")}");
                        break;
                    }
                }
            }
        }

       
    }
}