using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _iFound_ThisCoolSite
{
    class Player
    {
        string PlayerName;
        int PlayerWallet;
        public Player()
        {
            PlayerName = "Betty B";
            PlayerWallet = 4844;
        }

        private void setPlayerName(string Name)
        {
            PlayerName = Name;

        }

        public string getPlayerName()
        {
            return PlayerName;
        }

        private void setPlayerWallet(int Cash)
        {
            PlayerWallet = Cash;
        }

        public int getPlayerWallet()
        {
            return PlayerWallet;
        }

        public int autoPickBet(int upperLimit)
        {
            
            Random betGenerator = new Random();

            int pickedBet = betGenerator.Next(0, upperLimit);

            return pickedBet;
        }

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
    }
}
