using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();

            Console.Write("Choose a lower bound: ");
            int lower = Convert.ToInt32(Console.ReadLine());
            Console.Write("Choose an upper bound: ");
            int upper = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("I'm thinking of a number between {0}-{1}!", lower, upper);
            int myNum = rng.Next(lower, upper+1);
            int userGuess = -1;
            int numTries = 0;

            while (userGuess != myNum)
            {
                Console.Write("Please enter your guess: ");
                userGuess = Convert.ToInt32(Console.ReadLine());
                numTries++;

                if(userGuess < myNum)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if(userGuess > myNum)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine("You won in {0} tries! Press any key to exit.", numTries);
                    Console.ReadKey();
                    return;
                }
            }
            
        }
    }
}
