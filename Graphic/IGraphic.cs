using GeneticGame.Graphic.Model;
namespace GeneticGame.Graphic
{
    interface IGraphic
    {
        public void Print(IModel model);
        public void Clean(IModel model);
        public void ChangePosition(Coord newPosition, IModel model);
    }
}
