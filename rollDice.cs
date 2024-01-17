using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This is in the same namespace as the Program.cs class
namespace Mission2
{
    //rollDice method that rolls each dice and puts the numbers rolled into an array (that is passed back to the Program.cs)
    internal class rollDice
    {
        //Method that rolls each dice and puts the numbers rolled into an array
        public int[] calculateRolls(int numRolls)
        {
            //Get the random object into my code
            Random random = new Random();

            //Setting the rollTotals variable equal to an array with the size of the number of rolls
            int[] rollTotals = new int[numRolls];

            //For loop randomly rolling the dice (1 to 6), adding them up, and adding the sum to the rollTotals array.
            for (int iCount = 0; iCount < numRolls; iCount++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                int diceTotal = dice1 + dice2;

                rollTotals[iCount] = diceTotal;
            }

            //Then the rollTotals array is sent back to the Program.cs
            return rollTotals;
        }
    }
}
