using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(30) + 1;
            int guessNumber = 0;
            int tries = 0;

            while (guessNumber != number)
            {
                tries++;

                Console.Write("Guess the number between 1 and 30. \n");
                int.TryParse(Console.ReadLine(), out guessNumber);

                if (guessNumber > number)
                {
                    Console.WriteLine("{0} is too high! \n", guessNumber);
                }
                else if (guessNumber < number)
                {
                    Console.WriteLine("{0} is too low! \n", guessNumber);
                }
                else
                {
                    Console.WriteLine("{0} is correct! GZ. Want to play again? \n", guessNumber);
                    Console.WriteLine("Number of tries: {0}", tries);
                }
            }

        }


    }
}