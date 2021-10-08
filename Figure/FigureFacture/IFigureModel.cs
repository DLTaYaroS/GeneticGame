using System.Windows.Shapes;
namespace GeneticGame
{
    public interface IFigureModel
    { 
        public Coord ModelCoord { get; set; }
        public Ellipse Figure { get; set; }
    }
}
