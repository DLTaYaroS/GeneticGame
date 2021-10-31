using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace GeneticGame.Graphic.ModelFigureFactory.WPF
{
    class WPFFigure : IModel
    {
        public Ellipse WPFModelFigure { get; set; } 
        public Coord ModelCoord { get; set;}
        public IModel Model {
            get {
                return this;
            }
            set
            {
               
            }
        }
    }
}
