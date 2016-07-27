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
    public partial class frm_Play1Edit : Form
    {
        public frm_Play1Edit()
        {
            InitializeComponent();
        }

        private void btn_P1Save_Click(object sender, EventArgs e)
        {
            //Declaring the player variable that
            //we're going to be editing
            Player P1Edit = new Player();

            //Declaring variable for the new name
            string P1EditedName;
            //filling that variable with the text from the textbox
            P1EditedName = txt_P1EditName.Text;

            //setting the variable as the name for player 1
            P1Edit.setPlayerName(P1EditedName);


            //Declaring variable for the new
            //wallet amount
            int P1EditedWallet;
            //filling that variable with the text from
            //numeric up down
            P1EditedWallet = Int32.Parse(numUpDown_P1EditWallet.Text);

            //setting that variable as the wallet amount
            //for player 1
            P1Edit.setPlayerWallet(P1EditedWallet);
        }
    }
}
