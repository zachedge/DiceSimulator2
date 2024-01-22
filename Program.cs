using System;

namespace DiceSimulator
{
    class DiceSimulator
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the dice simulator!");

            Console.Write("How many dice rolls would you like to do? ");
            int numberOfRolls = int.Parse(Console.ReadLine());

            DiceRolling diceRolling = new DiceRolling();
            int[] results = diceRolling.SimulateRolls(numberOfRolls);

            Console.WriteLine("\nSimulation Results");
            Console.WriteLine("Each \"*\" is 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numberOfRolls}.\n");

            for (int i = 2; i <= 12; i++)
            {
                int percentage = results[i] * 100 / numberOfRolls;
                string asterisks = new string('*', percentage);
                Console.WriteLine($"{i}: {asterisks}");
            }

            Console.WriteLine("\nThat's all, Goodbye!");
        }
    }
}
