using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
namespace GeneticGame.Graphic.ModelFigureFactory.WPF
{
    class WPFEatFigure : WPFFigure
    {

        public Coord ModelCoord { get ; set ; }
        public Ellipse WPFModelFigure { get; set; }
    }
}
