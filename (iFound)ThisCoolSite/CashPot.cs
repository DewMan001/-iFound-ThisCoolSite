using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _iFound_ThisCoolSite
{
    class CashPot
    {
        public int seeRemainingCash(int playerBet, int playerWallet)
        {
            int cashLeft;
            cashLeft = playerWallet - playerBet;

            return cashLeft;
        }

        public int calculatePot(int P1Bet, int P2Bet, int P3Bet, int P4Bet)
        {
            int totalPot;
            totalPot = P1Bet + P2Bet + P3Bet + P4Bet;

            return totalPot;
        }

        public int pickWinner()
        {
            //declaring a variable to be returned
            int winNumber;
            //declaring random generator
            Random winPick = new Random();

            //picking a winner
            winNumber = winPick.Next(0, 4);

            //returning the results
            return winNumber;
        }
    }
}
