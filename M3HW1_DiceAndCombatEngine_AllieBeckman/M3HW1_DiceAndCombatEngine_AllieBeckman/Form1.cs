using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M3HW1_DiceAndCombatEngine_AllieBeckman
{
    public partial class Form1 : Form
    {
        // When game opens set monster and player health, base attack, armor, and weapon.
        private Player player = new Player();
        private Creature creature = new Creature();

        int creatureHealth;
        int creatureDamage;
        int creatureAttBonus;
        string creatureArmor;
        int creatureArmorPts;

        int playerHealth;
        int playerDamage;
        int playerAttPoints;
        string playerWeaponName;
        int playerWeaponPts;
        string playerArmor;
        int playerArmorPts;

        public Form1()
        {
            InitializeComponent();

            // give values to variables and place them in the display
            creature.creature();

            creatureHealth = creature.getHP();
            creatureArmor = creature.getArmorClass();
            creatureArmorPts = creature.getArmorBonus();
            creatureAttBonus = creature.getAttBonus();

            player.creature();

            playerHealth = player.getHP();
            playerArmor = player.getArmorClass();
            playerArmorPts = player.getArmorBonus();
            playerAttPoints = player.getAttBonus();
            player.playerWeapon();
            playerWeaponName = player.getWepName();
            playerWeaponPts = player.getWeaponDamage();

            lblMACName.Text = creatureArmor;
            lblMAP.Text = creatureArmorPts.ToString();
            lblWeaponName.Text = playerWeaponName;
            lblWeapPts.Text = playerWeaponPts.ToString();
            lblMACPoints.Text = creatureArmorPts.ToString();
            lblMHP.Text = creatureHealth.ToString();
            lblMDmg.Text = "";

            lblPACName.Text = playerArmor;
            lblPACBonus.Text = playerArmorPts.ToString();
            lblPAP.Text = playerArmorPts.ToString();
            lblPHP.Text = playerHealth.ToString();
            lblPDmg.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            // when the button is pressed get a new base attack based on the die roll
            creature.creature();
            player.creature();

            playerAttPoints = player.getAttBonus();

            creatureAttBonus = creature.getAttBonus();

            creatureDamage = creatureAttBonus;

            playerDamage = playerAttPoints + playerWeaponPts;

            lblMDmg.Text = creatureDamage.ToString();

            lblPDmg.Text = playerDamage.ToString();

            // each crature including player attacks
            playerHealth = playerHealth - creatureDamage;

            creatureHealth = creatureHealth - playerDamage;

            // display new health after damage is dealt
            lblMHP.Text = creatureHealth.ToString();
            lblPHP.Text = playerHealth.ToString();

            // display how much damage was dealt
            lblPlayerHealthLost.Text = "- " + creatureDamage;
            lblMonsterHealthLost.Text = "- " + playerDamage;

            // win lose
            if (playerHealth <= 0)
            {
                panelWinLose.Visible = true;
                lblWinLose.Text = "The monster won";
            }
            if (creatureHealth <= 0)
            {
                panelWinLose.Visible = true;
                lblWinLose.Text = "The player won";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
