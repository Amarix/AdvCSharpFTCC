using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3HW1_DiceAndCombatEngine_AllieBeckman
{
    class RandomDie
    {
        private int dieSize;

        private int dieResult;

        private Random r = new Random();

        public void roll()
        {
            // die size/ how many faces the die has.
            dieSize = r.Next(1, 6);

            // this sets the damage. the value on each die face
            switch (dieSize){
                case 1: dieResult = 5;
                    break;
                case 2: dieResult = 10;
                    break;
                case 3: dieResult = 15;
                    break;
                case 4: dieResult = 20;
                    break;
                case 5: dieResult = 25;
                    break;
                case 6: dieResult = 30;
                    break;
                default: dieResult = 15;
                    break;
            }

        }

        public int getDieResult()
        {
            return dieResult;
        }
    }
}
