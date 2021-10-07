using System;
using System.Windows.Shapes;

namespace GeneticGame
{
    class Bot: IFigureModel
    {
        public void BotCycle()
        {
            
        }
        protected BotCharacters characters;
        public Bot()
        {
            characters = new BotCharacters(3,3,3);

            energy = new BotEnergy(characters);
        }
        

        private BotEnergy energy;
        public Coord? MoveDirection { get; set; }
        public int ChanceChangeDirectione { get; set; }
        public Coord ModelCoord { get; set; }
        public Ellipse Figure { get; set; }
        public int id { get; set; }
         
        public void Eat()
        {
            
        }

        public Bot Clone(int id)
        {
            return new MutateBot(ModelCoord,id);
        }
    }
}

