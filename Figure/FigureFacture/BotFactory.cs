using GeneticGame.Figure.BotFigure;
namespace GeneticGame.Figure.FigureFactory
{
    public class BotFactory
    {
        internal Bot Create()
        {
            Coord coord = Coord.GetRandomCoord();
            DataManager data = DataManager.GetInstance();
            return new Bot() { ModelCoord = coord, Figure = data.create.GetModel(coord, data.BotModel)};
 
        }
        
    }
}
