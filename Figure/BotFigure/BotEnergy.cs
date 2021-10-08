namespace GeneticGame
{
    class BotEnergy:IBotEnergy
    {
       
        public BotEnergy(BotCharacters characters)
        {
            EnergyCycle = 0;
            Energy = 8024;
            EnergyCycle += characters.Size*5;
            EnergyCycle += characters.Speed *5;
            EnergyFromEat = 512;
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
