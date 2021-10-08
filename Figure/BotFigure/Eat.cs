using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GeneticGame
{
    class Eat: IFigureModel
    {
        public Coord ModelCoord { get; set; }
        public Ellipse Figure { get; set; }
    } 
}
