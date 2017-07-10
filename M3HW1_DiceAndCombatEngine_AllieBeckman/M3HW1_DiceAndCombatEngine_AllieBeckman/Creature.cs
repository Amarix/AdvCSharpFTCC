using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3HW1_DiceAndCombatEngine_AllieBeckman
{
    class Creature
    {
        private int Hitpoints;
        private int AttackBonus;
        private string ArmorClass;
        private int ArmorBonus;
        private RandomDie Damage = new RandomDie();

        public void creature()
        {
            Damage.roll();

            ArmorBonus = Damage.getDieResult() + 1;

            if (ArmorBonus < 15)
            {
                ArmorClass = "Cloth Amror";
            }
            else if (ArmorBonus < 35 && ArmorBonus > 15)
            {
                ArmorClass = "Leather Armor";
            }
            else if (ArmorBonus >= 35)
            {
                ArmorClass = "Iron Armor";
            }

            Damage.roll();
            Hitpoints = (Damage.getDieResult()*10) + ArmorBonus;

            AttackBonus = Damage.getDieResult();
        }

        public string getArmorClass()
        {
            return ArmorClass;
        }

        public int getArmorBonus()
        {
            return ArmorBonus;
        }

        public int getHP()
        {
            return Hitpoints;
        }

        public int getDamage()
        {
            return Damage.getDieResult();
        }

        public int getAttBonus()
        {
            return AttackBonus;
        }

    }

    class Player : Creature
    {
        private string WeaponName;
        private int WeaponDamage;
        private RandomDie r = new RandomDie();

        public void playerWeapon()
        {
            r.roll();
            WeaponDamage = r.getDieResult();
            if (WeaponDamage < 15)
            {
                WeaponName = "Wood Sword";
            }
            else if (WeaponDamage < 35 && WeaponDamage > 15)
            {
                WeaponName = "Iron Sword";
            }
            else if (WeaponDamage >= 35)
            {
                WeaponName = "Steel Sword";
            }

        }

        public int getWeaponDamage()
        {
            return WeaponDamage;
        }

        public string getWepName()
        {
            return WeaponName;
        }
    }
}
