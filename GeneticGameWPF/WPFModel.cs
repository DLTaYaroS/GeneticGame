using System.Windows.Shapes;
using GeneticGameLogic.Graphic;
namespace GeneticGameWPF
{
    class WPFModel: IModel
    {
        public Coord ModelCoord { get ; set; }
        public Ellipse Model { get; set; }
    }
}
