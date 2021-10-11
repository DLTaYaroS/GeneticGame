using GeneticGame.Figure.BotFigure;
namespace GeneticGame.Figure.FigureFactory
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
