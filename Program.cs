using Mission2;
using System.Diagnostics.Tracing;

public class Program
{
    private static void Main(string[] args)
    {
        rollDice rolledDice = new rollDice();

        //Initializing the number of rolls at 0.
        int numRolls;
        int[] eachRollCount = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        System.Console.WriteLine("Welcome to the dice throwing simulator!");

        System.Console.Write("\nHow many times will the dice be thrown? ");
        string userInput = System.Console.ReadLine();
        if (userInput != null)
        {
            numRolls = int.Parse(userInput);
        }
        else
        {
            // Handle the case where input is null (e.g., user closed the console window)
            // You might want to provide a default value or exit the program in a controlled manner.
            System.Console.WriteLine("\nInvalid input. Exiting the program.");
            return;
        }

        int[] rollTotals = rolledDice.calculateRolls(numRolls);

        for (int iCount = 0; iCount < numRolls; iCount++)
        {
            int roll = rollTotals[iCount];

            eachRollCount[roll - 2] += 1;
        }

        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = " + numRolls + ".\n");

        for (int iCount = 0; iCount < eachRollCount.Length; iCount++)
        {
            float percent = (((float)eachRollCount[iCount]/numRolls) * 100);
            int asterisksCount = (int)Math.Round(percent);

            string asterisks = new string('*', asterisksCount);

            System.Console.WriteLine((iCount + 2) + ": " + asterisks);
        }

        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}