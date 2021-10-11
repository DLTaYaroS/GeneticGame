using System.Windows.Shapes;
using GeneticGame.Graphic.Model;
using System.Windows;
using System.Windows.Media;
using GeneticGame.Graphic.ModelFigureFactory;

namespace GeneticGame.Figure.BotFigure
{
    class Bot: IModel,IBot
    {
        protected BotCharacters characters;
        private BotEnergy energy;
        
        public int ChanceChangeDirection
        {
            get { return characters.ChanceChangeDirectione; }
        }

        public Coord ModelCoord { get; set; }
        public Coord? MoveDirection { get; set; }
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

        public IModel Model { get ; set; }

        public Bot()
        {
            characters = new BotCharacters { ChanceChangeDirectione = 50, EnergyForCloned = 1100500, Size = 10, Speed = 10 };
            energy = new BotEnergy(characters);
        }   
        private Bot(Bot other)
        {
            characters = other.characters;
            characters.Size=characters.Size.MutateChange(4);
            characters.Speed=characters.Speed.MutateChange(4);
            characters.EnergyForCloned=characters.EnergyForCloned.MutateChange(528);
            characters.ChanceChangeDirectione = characters.ChanceChangeDirectione.MutateChange(40);
            energy = new BotEnergy(characters);       
        }
        public Bot Clone()
        {
            energy.BotMakeClone();
            DataManager data = DataManager.GetInstance();
            return new Bot(this) { ModelCoord = this.ModelCoord, Model = data.create.GetModel(this.ModelCoord, data.RedBotModel) };
        }
    }
}

