using System.Windows;
using System.Threading.Tasks;
using GeneticGame.Graphic;
using GeneticGame.Graphic.ModelFigureFactory.WPF.WPFInput;
using GeneticGame.Graphic.Map;
using GeneticGame.Graphic.Model;

namespace GeneticGame
{
    class WPFMap:IMap
    {
        MainWindow main;
        public WPFMap(MainWindow _main)
        { 
            main = _main;//
        }
      
        public void Clean(IModel model )
        {
            main.LayoutRoot.Children.Remove(model.Model);
        }
        public void Print(IModel model )
        {

            main.LayoutRoot.Children.Add(model.Model);
        }
        
        public  void ChangePosition(ModelCreatorInputWPF model,Coord coord, WPFModel Figure)
        {
            Clean(Figure);
            Figure.Model.Margin = new Thickness(coord.X, coord.Y, model.Right, model.Bottom);
            Print(Figure);
        }

    }
}
