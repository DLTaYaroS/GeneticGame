namespace GeneticGameLogic.Graphic
{
    public interface IMap
    {
        public void Print(IModel model);
        public void Clean(IModel model);
        public void ChangePosition(IModel model,Coord coord);
        
    }
}
