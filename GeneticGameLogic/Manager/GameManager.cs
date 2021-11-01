using System.Threading.Tasks;
using System.Linq;
using GeneticGameLogic.Figure.FigureFactory;
using GeneticGameLogic.Figure.BotFigure;
using System.Collections.Generic;

namespace GeneticGameLogic.Manager

{
    public class GameManager
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
            GameSpeed = 6;
            data = DataManager.GetInstance();
        }
        public void Start()
        {
            AddBot(50);
             AddEats(20);
        }
        private async Task BotStep(Bot bot)
        {

            List<Eat> selectEatList = new List<Eat>();
            data.mover.MoveBot(bot);
            bot.Step();
            var selectEat = data.ModelList.Eats.Where(e => e.ModelCoord.Equals(bot.ModelCoord)).ToList();
            selectEat.ForEach(e => bot.Eat());
            selectEatList.AddRange(selectEat);
            AddEats(selectEat.Count);
            


            selectEatList.ForEach(data.ModelList.RemoveEat);
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
                AddBot(50);
            }
            foreach (Bot bot in data.ModelList.Bots)
            {
                await BotStep(bot);
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
    
        public void AddEats(int CountEats)
        {
            for(int i = 0; i < CountEats; i++)
            {
                Eat eat = new EatFactory().Create() as Eat;
                data.ModelList.AddEat(eat);
                data.mapa.Print(eat.Model);
            }
        }
        
    }
}
