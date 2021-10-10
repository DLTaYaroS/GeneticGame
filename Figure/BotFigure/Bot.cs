using System.Windows.Shapes;
using GeneticGame.Figure.FigureFactory;
using System.Windows;
using System.Windows.Media;

namespace GeneticGame.Figure.BotFigure
{
    class Bot: IFigureModel,IBot
    {
        protected BotCharacters characters;
        private BotEnergy energy;
        public Coord? MoveDirection { get; set; }
        public int ChanceChangeDirection
        {
            get { return characters.ChanceChangeDirectione; }
        }

        public Coord ModelCoord { get; set; }
        public Ellipse Figure { get; set; }
        
        

        public void Step()
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

        
        public Bot()
        {
            characters = new BotCharacters { ChanceChangeDirectione = 55, EnergyForCloned = 10000, Size = 4, Speed = 4 };
            energy = new BotEnergy(characters);
        }   
        private Bot(Bot other)
        {
            this.characters = other.characters;
            this.characters.Size.MutateChange(1);
            this.characters.Speed.MutateChange(1);
            this.characters.EnergyForCloned.MutateChange(32);
            this.characters.ChanceChangeDirectione.MutateChange(10);
            energy = new BotEnergy(characters);       
        }
        public Bot Clone()
        {
            energy.BotMakeClone();
            DataManager data = DataManager.GetInstance();
            return new Bot(this) { ModelCoord = this.ModelCoord, Figure = data.create.GetModel(this.ModelCoord, data.RedBotModel) };
        }
    }
}

