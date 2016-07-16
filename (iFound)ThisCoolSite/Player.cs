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
        Player()
        {
            PlayerName = "Betty Betterson";
            PlayerWallet = 4844;
        }

        private void setPlayerName(string Name)
        {
            PlayerName = Name;

        }

        private string getPlayerName()
        {
            return PlayerName;
        }

        private void setPlayerWallet(int Cash)
        {
            PlayerWallet = Cash;
        }

        private int getPlayerWallet()
        {
            return PlayerWallet;
        }
    }
}
