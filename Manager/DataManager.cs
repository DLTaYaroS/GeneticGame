using System;
using System.Windows.Media;
using GeneticGame.Map;
using GeneticGame.Figure.BotFigure;
namespace GeneticGame
{
    class DataManager
    {
        public Random rand { get; private set; }
        public FigureStorage ModelList { get; private set; }
        public ModelCreatorInput BotModel { get; private set; }
        public ModelCreatorInput EatModel { get; private set; }
        public ModelCreatorInput RedBotModel { get; private set; }
        public BotMover move { get; private set; }
        public MapManager mapa { get; private set; }
        public ModelCreator create { get; private set; }
        public WPFMargineLimit limit { get;  set; }
        public void SetMainWindow(MainWindow main)
        {
            limit = new WPFMargineLimit
            {
                LeftMargine = -Convert.ToInt32(main.Width ),
                UpMargine = -Convert.ToInt32(main.Height ),
                DownMargine = Convert.ToInt32(main.Height ),
                RightMargine = Convert.ToInt32(main.Width )
            };
            mapa = new MapManager(main);
            move = new BotMover(limit);
            
        }
        private DataManager() {
            
            ModelList = new FigureStorage();
            rand = new Random(DateTime.Now.Millisecond);
            BotModel = new ModelCreatorInput { ColorModel = Colors.Black, Height = 8, Width = 8, StrokeThickness = 4, Right = 2, Bottom = 2 };
            RedBotModel = new ModelCreatorInput { ColorModel = Colors.Red, Height = 8, Width = 8, StrokeThickness = 4, Right = 2, Bottom = 2 };
            EatModel = new ModelCreatorInput { Height = 4, Width = 4, StrokeThickness = 2, Right = 2, Bottom = 2 };      
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

