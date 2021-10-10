using System.Windows.Shapes;
namespace GeneticGame.Figure.FigureFactory
{
    public interface IFigureModel
    { 
        public Coord ModelCoord { get; set; }
        public Ellipse Figure { get; set; }
    }
}
