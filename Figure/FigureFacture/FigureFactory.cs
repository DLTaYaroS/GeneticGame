
namespace GeneticGame
{
    public abstract class FigureFactory
    {
        protected abstract IFigureModel Make();
        public IFigureModel Create()
        {
            return this.Make();
        }
    }
}
