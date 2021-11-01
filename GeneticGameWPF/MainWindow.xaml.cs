using GeneticGameLogic.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GeneticGameWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameManager Game;
        DataManager data;
        public MainWindow()
        {
            
            InitializeComponent();
            data = DataManager.GetInstance();
            
            data.SetParametr(new WPFMap(this), new ModelCreatorWPF());
            data.BotModel = new ModelCreatorInputWPF { ColorModel = Colors.Black, Height = 8, Width = 8, StrokeThickness = 4, Right = 2, Bottom = 2 };
            data.RedBotModel = new ModelCreatorInputWPF { ColorModel = Colors.Red, Height = 8, Width = 8, StrokeThickness = 4, Right = 2, Bottom = 2 };
            data.EatModel = new ModelCreatorInputWPF { Height = 4, Width = 4, StrokeThickness = 2, Right = 2, Bottom = 2 };
            Game = new GameManager();
                      
        }

        private async void ClickMe(object sender, RoutedEventArgs e)
        {
            Game.Start();
            for (int i = 0; i < 10000; i++)
            {

                await Game.GameCycle();

            }
        }

        private  void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
           
        }

        private async void AddNewEat(object sender, RoutedEventArgs e)
        {
            Game.AddEats(10);
        }
    }
}
