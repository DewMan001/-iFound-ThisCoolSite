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
        }

        private void btn_GenBets_Click(object sender, EventArgs e)
        {
            //Randomly setting the chosen bet for player 2
            numUpDown_P2Bet.Text = Play2.autoPickBet(Int32.Parse(lbl_Player2Wallet.Text)).ToString();

            //Randomly setting the chosen bet for player 3
            numUpDown_P3Bet.Text = Play3.autoPickBet(Int32.Parse(lbl_Player3Wallet.Text)).ToString();

            //Randomly setting the chosen bet for player 4
            numUpDown_P4Bet.Text = Play4.autoPickBet(Int32.Parse(lbl_Player4Wallet.Text)).ToString();
        }
    }
}
