using GeneticGame.Figure.BotFigure;
namespace GeneticGame.Figure.FigureFactory
{
    public class BotFactory:FigureFactory
    {
        protected override IFigureModel Make()
        {
            Coord coord = Coord.GetRandomCoord();
            DataManager data = DataManager.GetInstance();
            IFigureModel result = new Bot() { ModelCoord = coord, Figure = data.create.GetModel(coord, data.BotModel)};
            return result;
        }
        
    }
}
