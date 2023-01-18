using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("\nHow many dice rolls would you like to simulate? ");
            int.TryParse(Console.ReadLine(), out int numRolls);

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls");
            Console.WriteLine("Total number of rolls = " + numRolls + ".\n");

            int[] rollCount = new int[13];

            Random rnd = new Random();

            for (int i = 0; i < numRolls; i++)
            {
                int diceOne = rnd.Next(1,7);
                int diceTwo = rnd.Next(1,7);

                rollCount[diceOne + diceTwo]++;
            }

            //skip 0 and 1 because they won't ever be rolled
            for (int i = 2; i < rollCount.Count(); i++)
            {
                //divide the number of times each combo was rolled by one-percent of the total number of rolls
                int numStars = Convert.ToInt32(Math.Floor(rollCount[i] / (numRolls * 0.01)));
                string stars = new string('*', numStars);
                Console.WriteLine(i + ": " + stars);
            }

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
            //keep it from auto closing the console
            Console.ReadKey();
        }
    }
}
