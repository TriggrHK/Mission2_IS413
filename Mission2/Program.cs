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

            //write all of the intro lines and get the number of rolls the player would like thrown
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("\nHow many dice rolls would you like to simulate? ");
            int.TryParse(Console.ReadLine(), out int numRolls);

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls");
            Console.WriteLine("Total number of rolls = " + numRolls + ".\n");

            //only store values for 2-12
            int[] rollCount = new int[11];

            Random rnd = new Random();

            //for however many rolls requested randomly generate two dice with values between 1-6
            for (int i = 0; i < numRolls; i++)
            {
                int diceOne = rnd.Next(1,7);
                int diceTwo = rnd.Next(1,7);

                rollCount[diceOne + diceTwo - 2]++;
            }

            //skip 0 and 1 because they won't ever be rolled
            for (int i = 0; i < rollCount.Count(); i++)
            {
                //divide the number of times each combo was rolled by one-percent of the total number of rolls
                int numStars = Convert.ToInt32(Math.Floor(rollCount[i] / (numRolls * 0.01)));
                string stars = new string('*', numStars);
                //account for the array storing values from 2-12
                Console.WriteLine((i+2) + ": " + stars);
            }

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
            //keep it from auto closing the console
            Console.ReadKey();
        }
    }
}
