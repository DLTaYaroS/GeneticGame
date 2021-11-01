using System;
using GeneticGameLogic.Figure.BotFigure;
using GeneticGameLogic.Graphic;
namespace GeneticGameLogic.Manager
{
    public class DataManager
    {
        internal MargineLimit limit { get; set; }
        public Random rand {  get; private set; }
        internal FigureStorage ModelList {  get; private set; }
        internal BotMover mover {  get; private set; }


        public IMap mapa { get; set; }
        public IModelCreator create { get; set; }
        public IModelCreatorInput BotModel { get; set; }
        public IModelCreatorInput EatModel { get; set; }
        public IModelCreatorInput RedBotModel { get; set; }
        public void SetParametr(IMap _map,  IModelCreator modelCreator)
        {
            create = modelCreator;
            mapa = _map;
            int r = 600;
            limit = new MargineLimit()
            {
                DownMargine = r,
                LeftMargine = -r,
                RightMargine = r,
                UpMargine = -r
            };
        }
        private DataManager()
        {

            ModelList = new FigureStorage();
            rand = new Random();
            mover = new BotMover();

            
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
    }
}

