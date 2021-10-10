using System.Windows.Shapes;
using GeneticGame.Figure.FigureFactory;
namespace GeneticGame.Figure.BotFigure
{
    class Eat: IFigureModel
    {
        public Coord ModelCoord { get; set; }
        public Ellipse Figure { get; set; }
    } 
}
