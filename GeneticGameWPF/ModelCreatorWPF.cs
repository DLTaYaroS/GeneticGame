using GeneticGameLogic.Graphic;
using GeneticGameLogic.Manager;

using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
namespace GeneticGameWPF
{
    class ModelCreatorWPF:IModelCreator
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



        public IModel GetModel(Coord coord,  IModelCreatorInput model)
        {
            Ellipse elipse = new Ellipse();
            elipse.Width = model.Width;
            elipse.Height = model.Height;
            var md = model as ModelCreatorInputWPF;
            elipse.StrokeThickness = md.StrokeThickness;
            elipse.Stroke = new SolidColorBrush( GetColor(md));
            elipse.Margin = new Thickness(coord.X, coord.Y, md.Right, md.Bottom);
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
