using Mission2;
using System.Diagnostics.Tracing;

//Class that takes a number of times a dice is rolled and prints out a histogram of how often (percentage) each number was rolled.
public class Program
{
    //main method that runs in this class automatically
    private static void Main(string[] args)
    {
        //Instantiates the object from the rollDice class
        rollDice rolledDice = new rollDice();

        //Initializing the number of rolls at 0, and creates the numRolls variable
        int numRolls;
        int[] eachRollCount = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        //Welcomes the user to the game and asks them how many times they want to roll the dice, then sets their answer to the userInput variable
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.Write("\nHow many times will the dice be thrown? ");
        string userInput = System.Console.ReadLine();

        //If the user's input is null, it will run this error message and quit the game. 
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

        //Initializes the rolledTotals integer list and runs the calculateRolls method in the rollDice class (other page)
        int[] rollTotals = rolledDice.calculateRolls(numRolls);

        //For each of the returned values of the returned values rolled, add a count of 1 for each time that number was rolled.
        for (int iCount = 0; iCount < numRolls; iCount++)
        {
            int roll = rollTotals[iCount];

            eachRollCount[roll - 2] += 1;
        }

        //Return the number of rolls and the explanation of the results
        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = " + numRolls + ".\n");

        //For each possible number rolled, calculate the percentage of times that number was rolled, round it to the nearest whole number, and print an asterisk for each percent for that number. 
        for (int iCount = 0; iCount < eachRollCount.Length; iCount++)
        {
            float percent = (((float)eachRollCount[iCount]/numRolls) * 100);
            //int asterisksCount = (int)Math.Round(percent) //I use this version unless I am using the developer command prompt and compiling it;
            int asterisksCount = (int)percent;

            string asterisks = new string('*', asterisksCount);

            System.Console.WriteLine((iCount + 2) + ": " + asterisks);
        }

        //Print a thank you message
        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}