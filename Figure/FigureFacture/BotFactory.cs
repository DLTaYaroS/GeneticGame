using GeneticGameLogic.Figure.BotFigure;
using GeneticGameLogic.Graphic;
using GeneticGameLogic.Manager;

namespace GeneticGameLogic.Figure.FigureFactory
{
    public class BotFactory
    {
        internal Bot Create()
        {
            Coord coord = Coord.GetRandomCoord();
            DataManager data = DataManager.GetInstance();
            return new Bot() { ModelCoord = coord, Model = data.create.GetModel(coord, data.BotModel)};

        }
        
    }
}
