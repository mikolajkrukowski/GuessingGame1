using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(50) + 1;
            int guessNumber = 0;
            int tries = 0;

            while (guessNumber != number)
            {
                tries++;

                Console.Write("Guess the number between 1 and 50. You have 10 chances.");
                int.TryParse(Console.ReadLine(), out guessNumber);

                if (guessNumber > number)
                {
                    Console.WriteLine("{0} is too high!", guessNumber);
                }
                else if (guessNumber < number)
                {
                    Console.WriteLine("{0} is too low!", guessNumber);
                }
                else
                {
                    Console.WriteLine("{0} is correct! GZ. Want to play again?", guessNumber);
                    Console.WriteLine("Number of tries: {0}", tries);
                }
            }

        }


    }
}