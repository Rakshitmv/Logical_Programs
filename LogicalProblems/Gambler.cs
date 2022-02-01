using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class Gambler
    {
        public void GamblerSimulation()
        {
            Console.WriteLine("Enter the number of times you want to run the experiment");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Stake");
            int stake = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Goal");
            int goal = Convert.ToInt32(Console.ReadLine());

            int stakeRemaining = stake;
            int betWinCount = 0; 
            bool didWin = false; 
            int noOfTimesRun = 0;


            while (num > 0 || stakeRemaining != 0 || didWin)
            {
                Random random = new Random();
                int RESULT = random.Next(0, 2); 

                stakeRemaining--; 

                if (RESULT == 0) 
                {
                    stakeRemaining -= 2; 
                }
                else 
                {
                    betWinCount++;
                    stakeRemaining += 2;
                }

                if (stakeRemaining == goal)
                {
                    didWin = true;
                }
                noOfTimesRun++;
                num--;
            }
            double percentWin = ((double)betWinCount / noOfTimesRun) * 100;
            double percentLoss = 100 - percentWin;

            Console.WriteLine("The total no of Bet Wins are: " + betWinCount + "\n Percentage Win: " + percentWin + "\n Percentage Loss: " + percentLoss);

        }
    }
}
