using GeneticGame.Graphic.Model;
using System.Windows.Shapes;
namespace GeneticGame.Graphic.ModelFigureFactory.WPF.WPFInput
{
    class WPFModel: IModel
    {
        public Coord ModelCoord { get ; set; }
        public Ellipse Model { get; set; }
    }
}
