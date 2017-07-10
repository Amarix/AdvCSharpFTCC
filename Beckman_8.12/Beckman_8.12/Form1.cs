using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// A slot machine project
//
// 10/13/16
// CSC 253
// Allie Beckman

namespace Beckman_8._12
{
    public partial class Form1 : Form
    {
        
        private int bet; // current bet
        private int winnings; // current winnings
        private int totWinnings; // total winnings
        private int totalBet; // total bet
        public int index1; // index for image one
        public int index2; // index for image two
        public int index3; // index for image three


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            try
            {
                // get the users bet
                bet = int.Parse(textBox1.Text);

                // add the bet to previous bets for total bets made
                totalBet = bet + totalBet;
                // change images
                changePictureImages();

                // calculate current and total winnings
                calculateWinnings(index1, index2, index3);
            }
            catch
            {
                // nothing runs if bet cannot be found
                textBox1.Text = "Bet Invalid.";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // display totals to the lables
            lblTotWin.Text = totWinnings.ToString();
            lblTotBet.Text = totalBet.ToString();

            // display the total winnings and bets made
            panel1.Visible = true;
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }

        private void changePictureImages()
        {
            // create a random
            Random r = new Random();

            // get three different randoms for the indexs
            index1 = r.Next(0, 4);
            index2 = r.Next(0, 4);
            index3 = r.Next(0, 4);

            // display different images using indexs
            pictureBox1.BackgroundImage = imageList1.Images[index1];
            pictureBox2.BackgroundImage = imageList1.Images[index2];
            pictureBox3.BackgroundImage = imageList1.Images[index3];
        }

        public void calculateWinnings(int one, int two, int three)
        {
            // if two of the three match
            if (one == two || one == three || two == three)
            {
                // if all three match
                if (one == two && one == three)
                {
                    // winnings current
                    winnings = bet * 3;

                    // winnings total
                    totWinnings = winnings + totWinnings;

                    // display current win amount
                    testBox.Text = "Winner: " + winnings.ToString();
                }
                else
                {
                    // winnings current
                    winnings = bet * 2;

                    // winnings total
                    totWinnings = winnings + totWinnings;

                    // display current win amount
                    testBox.Text = "Winner: " + winnings.ToString();
                }
            }
            else
            {
                // no winnings
                winnings = 0;

                // display loss message
                testBox.Text = "Try again!";
            }
        }
    }
}
