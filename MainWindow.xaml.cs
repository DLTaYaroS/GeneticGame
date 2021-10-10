using System;
using System.Windows;
using System.Threading.Tasks;
namespace GeneticGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        GameManager Game;
        public MainWindow()
        {        
            InitializeComponent();
            DataManager.GetInstance().SetMainWindow(this);
            Game = new GameManager();
        }

        private async void ClickMe(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
               await Game.GameCycle();            
              
            }
        }
        
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {     
            Game.Start();
            for (int i = 0; i < 100000; i++)
            {
               await Game.GameCycle();
            }
        }
       
        
    }
}
