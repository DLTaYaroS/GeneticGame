namespace GeneticGame.Graphic
{
    interface IGraphic
    {
        public void Print(IGraphicModel model);
        public void Clean(IGraphicModel model);
        public void ChangePosition(Coord newPosition, IGraphicModel model);
    }
}
