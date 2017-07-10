using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// desplay monster character with stats
//
// 9/9/16
// CSC 253
// Allie Beckman

namespace Beckman_Homework7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Local variables
                const int SIZE = 4;                     // Number of monsters
                int[] monsters = new int[SIZE];           // Array of monsters
                int index = 0;                          // Loop counter
                StreamReader inputFile;                 // For file input  

                // Open the file and get a StreamReader object.
                inputFile = File.OpenText("characterStats.txt");

                // add the monsters to the array.
                while (!inputFile.EndOfStream && index < monsters.Length)
                {
                    monsters[index] = int.Parse(inputFile.ReadLine());
                    index++;
                }

                // Close the file. 
                inputFile.Close();

                // Display monsters
                foreach (int value in monsters)
                {
                    monsterListBox.Items.Add(value);
                }

                int Goblin = monsters[0];
                int Werewolf = monsters[1];
                int Giant = monsters[2];
                int programmer = monsters[3];

                
            }
            catch (Exception ex)
            {
                // Display an error message. 
                MessageBox.Show(ex.Message);
            }

        }



        private void nextButton_Click(object sender, EventArgs e)
        {
            // once button is clicked select the next item in the invisible list box
            if (monsterListBox.SelectedIndex < monsterListBox.Items.Count - 1)
            {
                monsterListBox.SelectedIndex = monsterListBox.SelectedIndex + 1;
            }



            try {
                // turn the selected item into an int (this saves the whole number all
                // stats in a bunch)
                int selectedItem = int.Parse(monsterListBox.SelectedItem.ToString());
                //healthLabel.Text = selectedItem.ToString();

                // create a new array to hold the seperated stats
                int[] stats = new int[7];
                {

                    // temporary array to collect each value
                    var statsSeperator = new Stack<int>();
                    do
                    {
                        // seperating each number into it's own value
                        statsSeperator.Push(selectedItem % 10);
                        selectedItem /= 10;
                    } while (selectedItem > 0);

                    // stick the new array of numbers into the premade array
                    stats = statsSeperator.ToArray();

                    // get each value in order, for example every second int
                    // in the whole origonal number is the health stat and every
                    // third number is the stamina stat.
                    int monsterPic = stats[0];
                    int healthStat = stats[1];
                    int staminaStat = stats[2];
                    int manaStat = stats[3];
                    int armorStat = stats[4];
                    int strengthStat = stats[5];
                    int intelligenceStat = stats[6];


                    // desplay the stats in their respective labels
                    healthLabel.Text = healthStat.ToString();
                    staminaLabel.Text = staminaStat.ToString();
                    manaLabel.Text = manaStat.ToString();
                    armorLabel.Text = armorStat.ToString();
                    strengthLabel.Text = strengthStat.ToString();
                    intelligenceLabel.Text = intelligenceStat.ToString();

                    // use these to change image and name label
                    if (monsterPic == 1)
                    {
                        displayMonsterBox.BackgroundImage = Beckman_Homework7_2.Properties.Resources.goblin;
                        monsterNameLabel.Text = "Goblin";
                    }
                    else if(monsterPic == 2)
                    {
                        displayMonsterBox.BackgroundImage = Beckman_Homework7_2.Properties.Resources.werewolf;
                        monsterNameLabel.Text = "Werewolf";
                    }
                    else if(monsterPic == 3)
                    {
                        displayMonsterBox.BackgroundImage = Beckman_Homework7_2.Properties.Resources.giant;
                        monsterNameLabel.Text = "Giant";
                    }
                    else if(monsterPic == 4)
                    {
                        displayMonsterBox.BackgroundImage = Beckman_Homework7_2.Properties.Resources.programmer;
                        monsterNameLabel.Text = "Programmer";
                    }
                }

            }
            catch (Exception NullReferenceException) { }
        }



        private void leftButton_Click(object sender, EventArgs e)
        {

            // sort through the list box created with the origonal array
            if (monsterListBox.SelectedIndex > 0)
            {
                monsterListBox.SelectedIndex = monsterListBox.SelectedIndex - 1;
            }


            try
            {

                // save the newly selected value as an int variable
                int selectedItem = int.Parse(monsterListBox.SelectedItem.ToString());

                // make a new array to be used for seperating the stats
                int[] stats = new int[7];
                {
                    // seperate the int value from the list
                    var statsSeperator = new Stack<int>();
                    do
                    {
                        statsSeperator.Push(selectedItem % 10);
                        selectedItem /= 10;
                    } while (selectedItem > 0);

                    // put the newly seperated numbers into the new array
                    stats = statsSeperator.ToArray();

                    // give each item in the new array it's own variable
                    // it's specific to the stats and in order. The second variable
                    // is equal to health and the third is always stamina ect.
                    int monsterPic = stats[0];
                    int healthStat = stats[1];
                    int staminaStat = stats[2];
                    int manaStat = stats[3];
                    int armorStat = stats[4];
                    int strengthStat = stats[5];
                    int intelligenceStat = stats[6];

                    // display stats
                    healthLabel.Text = healthStat.ToString();
                    staminaLabel.Text = staminaStat.ToString();
                    manaLabel.Text = manaStat.ToString();
                    armorLabel.Text = armorStat.ToString();
                    strengthLabel.Text = strengthStat.ToString();
                    intelligenceLabel.Text = intelligenceStat.ToString();

                    // use these to change image and name label
                    if (monsterPic == 1)
                    {
                        displayMonsterBox.BackgroundImage = Beckman_Homework7_2.Properties.Resources.goblin;
                        monsterNameLabel.Text = "Goblin";
                    }
                    else if (monsterPic == 2)
                    {
                        displayMonsterBox.BackgroundImage = Beckman_Homework7_2.Properties.Resources.werewolf;
                        monsterNameLabel.Text = "Werewolf";
                    }
                    else if (monsterPic == 3)
                    {
                        displayMonsterBox.BackgroundImage = Beckman_Homework7_2.Properties.Resources.giant;
                        monsterNameLabel.Text = "Giant";
                    }
                    else if (monsterPic == 4)
                    {
                        displayMonsterBox.BackgroundImage = Beckman_Homework7_2.Properties.Resources.programmer;
                        monsterNameLabel.Text = "Programmer";
                    }
                }
            }
            catch (Exception NullReferenceException) { }
        }



        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
