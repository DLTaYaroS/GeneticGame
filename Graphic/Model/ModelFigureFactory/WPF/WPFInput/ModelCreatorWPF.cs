using GeneticGame.Graphic.ModelFigureFactory.WPF.WPFInput;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
namespace GeneticGame
{
    class ModelCreatorWPF
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
        public ModelCreatorWPF()
        {
        }
       
        public WPFModel GetModel(Coord coord,ModelCreatorInputWPF model)
        {
            Ellipse elipse = new Ellipse();
            elipse.Width = model.Width;
            elipse.Height = model.Height;
            
            elipse.StrokeThickness = model.StrokeThickness;
            elipse.Stroke = new SolidColorBrush( GetColor(model));
            elipse.Margin = new Thickness(coord.X, coord.Y, model.Right, model.Bottom);
            return new WPFModel() { Model = elipse, ModelCoord = coord };
        }

        private Color GetColor(ModelCreatorInputWPF model)//if model.Color==null return random color
        {
            if (model.ColorModel !=null)
            {
                return model.ColorModel.Value;
            }
            return colors[DataManager.GetInstance().rand.Next(0, colors.Length)];
        }
    }
}
