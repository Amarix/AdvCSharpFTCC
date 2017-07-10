using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_7_RandomCard_AllieBeckman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandCard_Click(object sender, EventArgs e)
        {
            // Create a random object.
            Random r = new Random();

            // get a random index.
            int index = r.Next(cardImageList.Images.Count);

            // Display a random card.
            cardPictureBox.BackgroundImage = cardImageList.Images[index];
        }
    }
}
