using System.Windows.Shapes;
namespace GeneticGame
{
    class Bot: IFigureModel
    {
        public void BotCycle()
        {
            energy.CycleEnergy();
        }
        public bool CheckPossibilityMakeBot()
        {
            return energy.FullEnergyForClone();
        }
        public void Eat()
        {
            energy.EatEnergy();
        }
        public bool BotDied()
        {
            return energy.LowEnergy();
        }

        protected BotCharacters characters;
        public Bot()
        {
            characters = new BotCharacters { ChanceChangeDirectione = 55, EnergyForCloned = 1024, Size = 4, Speed = 4 };

            energy = new BotEnergy(characters);
        }
        

        private BotEnergy energy;
        public Coord? MoveDirection { get; set; }
        public int ChanceChangeDirectione
        {
            get { return characters.ChanceChangeDirectione; }
        }

        public Coord ModelCoord { get; set; }
        public Ellipse Figure { get; set; }
         

        public Bot Clone()
        {
            energy.BotMakeClone();
            return new MutateBot();
        }
    }
}

