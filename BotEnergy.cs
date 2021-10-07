using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticGame
{
    class BotEnergy:IBotEnergy
    {
       
        public BotEnergy(BotCharacters characters)
        {
            EnergyCycle = 0;
            EnergyCycle += characters.Size* characters.Size;
            EnergyCycle += characters.Speed* characters.Speed;

            EnergyForCloned= characters.EnergyForCloned;
        }
        private int EnergyCycle;
        private int Energy;
        private static int EnergyFromEat;
        private int EnergyForCloned;
        public void EatEnergy()
        {
            Energy += EnergyFromEat;
        }
        public void CycleEnergy()
        {
            Energy -= EnergyCycle;
        }
        public bool FullEnergyForClone()
        {
            if (Energy >= EnergyForCloned)
            {
                return true;
            }
            return false;
        }
        public void BotMakeClone()
        {
            Energy -= EnergyCycle * 4;
        }
        public bool LowEnergy()
        {
            if (Energy <= 0)
            {
                return true;
            }
            return false;
        }

    }
}
