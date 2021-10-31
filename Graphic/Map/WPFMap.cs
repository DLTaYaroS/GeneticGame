using System.Windows.Shapes;
using System.Windows;
using System.Threading.Tasks;
using GeneticGame.Graphic;

namespace GeneticGame
{
    class WPFMap:IGraphic
    {
        MainWindow main;
        public WPFMap(MainWindow _main)
        { 
            main = _main;//
        }
      
        public async Task Clean(IGraphicModel model)
        {
            main.LayoutRoot.Children.Remove(model);
        }
        public async Task Print(Ellipse ellipse)
        {

            main.LayoutRoot.Children.Add(ellipse);
        }
        
        public  async Task ChangePosition(ModelCreatorInputWPF model,Coord coord,Ellipse Figure)
        {
            await Clean(Figure);
            Figure.Margin = new Thickness(coord.X, coord.Y, model.Right, model.Bottom);
             Print(Figure);
        }

    }
}
