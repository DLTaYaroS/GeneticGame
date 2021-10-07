using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
namespace GeneticGame
{
    class ModelCreator
    {        
        Color[] colors = new Color[] {
             Colors.Red,
             Colors.Blue,
             Colors.Green,
             Colors.Brown,
             Colors.DarkGray,
             Colors.Orange,
             Colors.DarkRed,
             Colors.Yellow,
             Colors.YellowGreen,
             Colors.Purple,
             Colors.Gold,
             Colors.Gray,
        };
        Random rand;
        public ModelCreator()
        {
            rand = new Random(DateTime.Now.Millisecond);
        }
       
        public Ellipse GetModel(Coord coord,ModelCreatorInput model)
        {
            Ellipse elipse = new Ellipse();
            elipse.Width = model.Width;
            elipse.Height = model.Height;
            
            elipse.StrokeThickness = model.StrokeThickness;
            elipse.Stroke = new SolidColorBrush( GetColor(model));
            elipse.Margin = new Thickness(coord.X, coord.Y, model.Right, model.Bottom);
            return elipse;
        }

        private Color GetColor(ModelCreatorInput model)//if model.Color==null return random color
        {
            if (model.ColorModel !=null)
            {
                return model.ColorModel.Value;
            }
            rand = new Random(rand.Next(DateTime.Now.Millisecond));
            return colors[rand.Next(0, colors.Length)];
        }
    }
}
