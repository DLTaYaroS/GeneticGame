using System.Threading.Tasks;
using System.Linq;
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
            GameSpeed = 10;
            data = DataManager.GetInstance();
        }
        public void Start()
        {
            AddBot(50);
            AddEats(300);
        }
        
        public async Task GameCycle()
        {
            //AddEats(25);
            foreach(Bot bot in data.ModelList.Bots)
            {
           
                data.move.MoveBot(bot, data.BotModel);
                bot.BotCycle();
                Eat eat = data.ModelList.EatExistInCoord(bot.ModelCoord);
                if (eat != null)
                {
                    bot.Eat();
                  //  data.ModelList.RemoveEat(eat);
                }
            }
         //   var selectClone = data.ModelList.Bots.Where(b => b.CheckPossibilityMakeBot()).Select(b => b.Clone()).ToList();
         //   data.ModelList.Bots.RemoveAll(bot => bot.BotDied().ToList()); 
            await Task.Delay(GameSpeed);
        }

        
        private void AddBot(uint CountBots)
        {           
            for (int i = 0; i < CountBots; i++)
            {
                data.ModelList.Bots.Add(new BotFactory().Create() as Bot);
               // data.Bots.Add(new BotFactory().Create() as Bot);
            }
        }
    
        private void AddEats(uint CountEats)
        {
            for(int i = 0; i < CountEats; i++)
            {
                Eat eat = new EatFactory().Create() as Eat;
                data.ModelList.AddEat(eat);
                data.mapa.Print(eat.Figure);
            }
        }
        
    }
}
