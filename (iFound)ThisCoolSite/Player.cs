﻿using System;
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

        public void setPlayerName(string Name)
        {
            PlayerName = Name;

        }

        public string getPlayerName()
        {
            return PlayerName;
        }

        public void setPlayerWallet(int Cash)
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

    }
}
