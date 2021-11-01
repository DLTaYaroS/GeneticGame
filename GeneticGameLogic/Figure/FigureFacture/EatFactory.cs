using GeneticGameLogic.Figure.BotFigure;
using GeneticGameLogic.Graphic;
using GeneticGameLogic.Manager;

namespace GeneticGameLogic.Figure.FigureFactory
{ 
    public class EatFactory
    {
        internal Eat Create()
        {
            Coord coord = Coord.GetRandomCoord();
            DataManager data = DataManager.GetInstance();
            return new Eat() { ModelCoord = coord, Model = data.create.GetModel(coord, data.EatModel) };
          
        }
    }
}
