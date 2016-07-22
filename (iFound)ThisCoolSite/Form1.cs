using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _iFound_ThisCoolSite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //making the players
        Player Play1 = new Player();
        Player Play2 = new Player();
        Player Play3 = new Player();
        Player Play4 = new Player();

        private void Form1_Load(object sender, EventArgs e)
        {
            //setting player 1's name and wallet amount
            lbl_Player1.Text = Play1.getPlayerName();
            lbl_Player1Wallet.Text = Play1.getPlayerWallet().ToString();

            //setting player 2's name and wallet amount
            lbl_Player2.Text = Play2.getPlayerName();
            lbl_Player2Wallet.Text = Play2.getPlayerWallet().ToString();

            //setting player 3's name and wallet amount
            lbl_Player3.Text = Play3.getPlayerName();
            lbl_Player3Wallet.Text = Play3.getPlayerWallet().ToString();

            //setting player 4's name and wallet amount
            lbl_Player4.Text = Play4.getPlayerName();
            lbl_Player4Wallet.Text = Play4.getPlayerWallet().ToString();

            //calculating pot total on launch
            //setting up variables
            int P1Bet = Int32.Parse(numUpDown_P1Bet.Text);
            int P2Bet = Int32.Parse(numUpDown_P2Bet.Text);
            int P3Bet = Int32.Parse(numUpDown_P3Bet.Text);
            int P4Bet = Int32.Parse(numUpDown_P4Bet.Text);
            CashPot calculator = new CashPot();
            //running calculation
            int potTotal = calculator.calculatePot(P1Bet, P2Bet, P3Bet, P4Bet);
            //setting label to newly calculated value
            lbl_TotalPot.Text = potTotal.ToString();

        }

        private void btn_GenBets_Click(object sender, EventArgs e)
        {
            //declaring the variables for the various bets
            int Play2Bet;
            int Play3Bet;
            int Play4Bet;
            Random reRoll = new Random();

            //Randomly setting the chosen bet for player 2
            Play2Bet = Play2.autoPickBet(Int32.Parse(lbl_Player2Wallet.Text));

            //Randomly setting the chosen bet for player 3
            Play3Bet = Play3.autoPickBet(Int32.Parse(lbl_Player3Wallet.Text));

            //Randomly setting the chosen bet for player 4
            Play4Bet = Play4.autoPickBet(Int32.Parse(lbl_Player4Wallet.Text));

            if (Play2Bet == Play3Bet || Play2Bet == Play4Bet)
            {
                Play2Bet = reRoll.Next(0, Int32.Parse(lbl_Player2Wallet.Text));
                numUpDown_P2Bet.Text = Play2Bet.ToString();
            }
            
            if(Play3Bet == Play2Bet || Play3Bet == Play4Bet)
            {
                Play3Bet = reRoll.Next(0, Int32.Parse(lbl_Player3Wallet.Text));
                numUpDown_P3Bet.Text = Play3Bet.ToString();
            }

            if(Play4Bet == Play2Bet || Play4Bet == Play3Bet)
            {
                Play4Bet = reRoll.Next(0, Int32.Parse(lbl_Player4Wallet.Text));
                numUpDown_P4Bet.Text = Play4Bet.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cashPot function for the things we need to do to Total Pot
            CashPot functions = new CashPot();
            //variable for the combined total of all of the bets
            int TotalPot;

            //Determining the bets from the players
            //first with Player 1
            int P1Bet;
            P1Bet = Int32.Parse(numUpDown_P1Bet.Text);

            //and now Player 2
            int P2Bet;
            P2Bet = Int32.Parse(numUpDown_P2Bet.Text);

            //and now Player 3
            int P3Bet;
            P3Bet = Int32.Parse(numUpDown_P3Bet.Text);

            //and finally player 4
            int P4Bet;
            P4Bet = Int32.Parse(numUpDown_P4Bet.Text);

            //pulling in their wallets
            //Player1's wallet
            int P1Wallet;
            P1Wallet = Int32.Parse(lbl_Player1Wallet.Text);

            //Player2's wallet
            int P2Wallet;
            P2Wallet = Int32.Parse(lbl_Player2Wallet.Text);

            //Player3's wallet
            int P3Wallet;
            P3Wallet = Int32.Parse(lbl_Player3Wallet.Text);

            //Player4's wallet
            int P4Wallet;
            P4Wallet = Int32.Parse(lbl_Player4Wallet.Text);

            //Figuring out what they have left
            CashPot calculator = new CashPot();
            //Player 1's remainder (and label being set)
            int P1Remainder = calculator.seeRemainingCash(P1Bet, P1Wallet);
            lbl_Player1Wallet.Text = P1Remainder.ToString();

            //Player 2's remainder (and label being set)
            int P2Remainder = calculator.seeRemainingCash(P2Bet, P2Wallet);
            lbl_Player2Wallet.Text = P2Remainder.ToString();

            //Player 3's remainder (and label being set)
            int P3Remainder = calculator.seeRemainingCash(P3Bet, P3Wallet);
            lbl_Player3Wallet.Text = P3Remainder.ToString();

            //Player 4's remainder (and label being set)
            int P4Remainder = calculator.seeRemainingCash(P4Bet, P4Wallet);
            lbl_Player4Wallet.Text = P4Remainder.ToString();

            //calculating total pot
            TotalPot = functions.calculatePot(P1Bet, P2Bet, P3Bet, P4Bet);

            //picking a winner
            int winner = functions.pickWinner();

            if (winner == 1)
            {
                P1Wallet = P1Remainder + TotalPot;
                lbl_Player1Wallet.Text = P1Wallet.ToString();
            }
            else if (winner == 2)
            {
                P2Wallet = P2Remainder + TotalPot;
                lbl_Player2Wallet.Text = P2Wallet.ToString();
            }
            else if (winner = 3)
        }

        private void numUpDown_P1Bet_ValueChanged(object sender, EventArgs e)
        {
            //setting up bet variables
            int P1Bet = Int32.Parse(numUpDown_P1Bet.Text);
            int P2Bet = Int32.Parse(numUpDown_P2Bet.Text);
            int P3Bet = Int32.Parse(numUpDown_P3Bet.Text);
            int P4Bet = Int32.Parse(numUpDown_P4Bet.Text);

            //calculating total pot
            CashPot calculator = new CashPot();

            int PotTotal;
            PotTotal = calculator.calculatePot(P1Bet, P2Bet, P3Bet, P4Bet);

            lbl_TotalPot.Text = PotTotal.ToString();
        }

        private void numUpDown_P2Bet_ValueChanged(object sender, EventArgs e)
        {
            //setting up bet variables
            int P1Bet = Int32.Parse(numUpDown_P1Bet.Text);
            int P2Bet = Int32.Parse(numUpDown_P2Bet.Text);
            int P3Bet = Int32.Parse(numUpDown_P3Bet.Text);
            int P4Bet = Int32.Parse(numUpDown_P4Bet.Text);

            //calculating total pot
            CashPot calculator = new CashPot();

            int PotTotal;
            PotTotal = calculator.calculatePot(P1Bet, P2Bet, P3Bet, P4Bet);

            lbl_TotalPot.Text = PotTotal.ToString();
        }

        private void numUpDown_P3Bet_ValueChanged(object sender, EventArgs e)
        {
            //setting up bet variables
            int P1Bet = Int32.Parse(numUpDown_P1Bet.Text);
            int P2Bet = Int32.Parse(numUpDown_P2Bet.Text);
            int P3Bet = Int32.Parse(numUpDown_P3Bet.Text);
            int P4Bet = Int32.Parse(numUpDown_P4Bet.Text);

            //calculating total pot
            CashPot calculator = new CashPot();

            int PotTotal;
            PotTotal = calculator.calculatePot(P1Bet, P2Bet, P3Bet, P4Bet);

            lbl_TotalPot.Text = PotTotal.ToString();
        }

        private void numUpDown_P4Bet_ValueChanged(object sender, EventArgs e)
        {
            //setting up bet variables
            int P1Bet = Int32.Parse(numUpDown_P1Bet.Text);
            int P2Bet = Int32.Parse(numUpDown_P2Bet.Text);
            int P3Bet = Int32.Parse(numUpDown_P3Bet.Text);
            int P4Bet = Int32.Parse(numUpDown_P4Bet.Text);

            //calculating total pot
            CashPot calculator = new CashPot();

            int PotTotal;
            PotTotal = calculator.calculatePot(P1Bet, P2Bet, P3Bet, P4Bet);

            lbl_TotalPot.Text = PotTotal.ToString();
        }
    }
}
