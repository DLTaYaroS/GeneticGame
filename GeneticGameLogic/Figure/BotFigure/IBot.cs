using GeneticGameLogic.Graphic;

namespace GeneticGameLogic.Figure.BotFigure
{
    interface IBot
    {
        public int ChanceChangeDirection { get; set; }
        public Coord? MoveDirection { get; set; }
        public void Eat();
        public Bot Clone();
        public void Step();
    }
}
