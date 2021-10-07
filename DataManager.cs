using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace GeneticGame
{
    class DataManager
    {
        public Random rand { get; private set; }
        public FigureIdList List { get; private set; }
        public ModelCreatorInput BotModel { get; private set; }
        public ModelCreatorInput EatModel { get; private set; }
        public BotMover move { get; private set; }
        public List<Bot> Bots { get; private set; }
        public List<Eat> Eats { get; private set; }
        public MapaManager mapa { get; private set; }
        public ModelCreator create { get; private set; }
        public int LeftMargine { get; private set; }
        public int RightMargine { get; private set; }
        public int UpMargine { get; private set; }
        public int DownMargine { get; private set; }

        public void SetMainWindow(MainWindow main)
        {
            mapa = new MapaManager(main);
            move = new BotMover(main, mapa);
            LeftMargine = -Convert.ToInt32(main.Width * 1.5);
            UpMargine = -Convert.ToInt32(main.Height * 1.5);
            DownMargine = Convert.ToInt32(main.Height * 1.5);
            RightMargine = Convert.ToInt32(main.Width * 1.5);
        }
        private DataManager() {
            rand = new Random(DateTime.Now.Millisecond);
            Bots = new List<Bot>();
            Eats = new List<Eat>();
            BotModel = new ModelCreatorInput { ColorModel = Colors.Black, Height = 8, Width = 8, StrokeThickness = 4, Right = 2, Bottom = 2 };
            EatModel = new ModelCreatorInput { Height = 2, Width = 2, StrokeThickness = 2, Right = 1, Bottom = 1 };      
            create = new ModelCreator();
        }

        private static DataManager _instance;

        public static DataManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DataManager();
            }
            return _instance;
        }

        public static void someBusinessLogic()
        {
            // ...
        }
    }
}

