using System;
using System.Windows;
using System.Threading.Tasks;
using GeneticGameWPF;

namespace GeneticGame
{
    public partial class MainWindow : Window
    {
        
        
        public MainWindow()
        {        
            InitializeComponent();
            
        }
        public void StartButton(object sender, RoutedEventArgs e)
        {
           
            GeneticGameWPF.MainWindow mw = new GeneticGameWPF.MainWindow();
            mw.Show();

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        
        }
    }
}
