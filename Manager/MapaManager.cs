using System.Windows.Shapes;
using System.Windows;
namespace GeneticGame
{
    class MapaManager
    {
        MainWindow main;
        public MapaManager(MainWindow _main)
        { 
            main = _main;//
        }
      
        public void Clean(Ellipse ellipse)
        {
            main.LayoutRoot.Children.Remove(ellipse);
        }
        public void Print(Ellipse ellipse)
        {
            
            main.LayoutRoot.Children.Add(ellipse);
        }
        public void ChangePosition(ModelCreatorInput model,Coord coord,Ellipse Figure)
        {
            Clean(Figure);
            Figure.Margin = new Thickness(coord.X, coord.Y, model.Right, model.Bottom);
            Print(Figure);
        }

    }
}
