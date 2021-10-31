using System.Threading.Tasks;
using System.Linq;
using GeneticGame.Figure.FigureFactory;
using GeneticGame.Figure.BotFigure;
using System.Collections.Generic;

namespace GeneticGame
{
    class GameManager
    {     
        private DataManager data;
        private int gameSpeed;
        public int BotCount()
        {
            return data.ModelList.Bots.Count;
        }
        public int GameSpeed
        {
            private get { return gameSpeed; }
            set
            {
                if (value >= 1)
                {
                    gameSpeed = value;
                }
                else
                {
                    gameSpeed = 20;
                }
            }
        }
        public GameManager()
        {
            GameSpeed = 1;
            data = DataManager.GetInstance();
        }
        public void Start()
        {
            AddBot(200);
          //    AddEats(200);
        }
        private void BotStep(Bot bot)
        {
            List<Eat> selectEatList = new List<Eat>();
            data.move.MoveBot(bot, data.BotModel);
            bot.Step();
            var selectEat = data.ModelList.Eats.Where(e => e.ModelCoord.Equals(bot.ModelCoord)).ToList();
            selectEat.ForEach(e => bot.Eat());
            selectEatList.AddRange(selectEat);
            selectEatList.ForEach(data.ModelList.RemoveEat);
            AddEats(selectEatList.Count);
        }
        private void SelectBot()
        {
            var selectClone = data.ModelList.Bots.Where(b => b.CheckPossibilityMakeBot()).Select(b => b.Clone()).ToList();
            data.ModelList.AddBots(selectClone);
            var SelectDeadBot = data.ModelList.Bots.Where(bot => bot.BotDied()).ToList();
            data.ModelList.RemoveBots(SelectDeadBot);
        }
        public async Task GameCycle()
        {
         //   AddEats(1);
            if (data.ModelList.Bots.Count <= 0)
            {
                AddBot(1);
            }
            foreach (Bot bot in data.ModelList.Bots)
            {
                BotStep(bot);
            }
            SelectBot();
            
            await Task.Delay(GameSpeed);
        }

        
        private void AddBot(uint CountBots)
        {           
            for (int i = 0; i < CountBots; i++)
            {
                data.ModelList.Bots.Add(new BotFactory().Create() as Bot);
            }
        }
    
        private void AddEats(int CountEats)
        {
            for(int i = 0; i < CountEats; i++)
            {
                Eat eat = new EatFactory().Create() as Eat;
                data.ModelList.AddEat(eat);
                //data.mapa.Print(eat.Figure);
            }
        }
        
    }
}
