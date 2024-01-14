using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class rollDice
    {
        public int[] calculateRolls(int numRolls)
        {
            Random random = new Random();

            int[] rollTotals = new int[numRolls];

            for (int iCount = 0; iCount < numRolls; iCount++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                int diceTotal = dice1 + dice2;

                rollTotals[iCount] = diceTotal;
            }

            return rollTotals;
        }
    }
}
