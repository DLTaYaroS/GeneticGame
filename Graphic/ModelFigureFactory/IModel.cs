namespace GeneticGame.Graphic.ModelFigureFactory
{
    interface IModel
    {
        public IModel Model { get; set; }
        public Coord ModelCoord { get; set; }
    }
}
