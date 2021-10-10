namespace GeneticGame.Figure.BotFigure
{
    interface IBot
    {
        public int ChanceChangeDirection { get; }
        public Coord? MoveDirection { get; set; }
        public void Eat();
        public Bot Clone();
        public void Step();
    }
}
