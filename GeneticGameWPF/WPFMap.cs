using System.Threading.Tasks;
using System.Windows;
using GeneticGameLogic.Graphic;

namespace GeneticGameWPF
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
            var md=model as WPFModel;
            main.LayoutRoot.Children.Remove(md.Model);
        }
        public void Print(IModel model )
        {
            var md = model as WPFModel;
            main.LayoutRoot.Children.Add(md.Model);
        }
        
        public  void ChangePosition(IModel model,Coord coord)
        {
            var md = model as WPFModel;
            Clean(model);
           
            md.Model.Margin = new Thickness(coord.X, coord.Y,2, 2);
            Print(model);
        }

    }
}
