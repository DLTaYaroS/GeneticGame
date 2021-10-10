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

        public int Speed
        {
            get
            {
                return characters.Speed;
            }
        }
        public Bot()
        {
            characters = new BotCharacters { ChanceChangeDirectione = 50, EnergyForCloned = 40000, Size = 4, Speed = 4 };
            energy = new BotEnergy(characters);
        }   
        private Bot(Bot other)
        {
            characters = other.characters;
            characters.Size=characters.Size.MutateChange(2);
            characters.Speed=characters.Speed.MutateChange(2);
            characters.EnergyForCloned=characters.EnergyForCloned.MutateChange(128);
            characters.ChanceChangeDirectione = characters.ChanceChangeDirectione.MutateChange(20);
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

