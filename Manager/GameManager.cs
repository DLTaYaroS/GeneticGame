using System.Threading.Tasks;
namespace GeneticGame
{
    class GameManager
    {     
        private DataManager data;
        public int BotSpeed { private get; set; }    
        public GameManager()
        {        
            data = DataManager.GetInstance();
        }
        public void Start()
        {
            AddBot(100);
            AddEats(100);
        }
        public async Task GameCycle()
        {
            AddEats(10);
          
            foreach(Bot bot in data.Bots)
            {
                bot.BotCycle();
                data.move.MoveBot(bot, data.BotModel);
            }
                   
            await Task.Delay(50);

        }

        
        private void AddBot(uint CountBots)
        {           
            for (int i = 0; i < CountBots; i++)
            { 
                data.Bots.Add(new BotFactory().Create() as Bot);
            }
        }
    
        private void AddEats(uint CountEats)
        {
            for(int i = 0; i < CountEats; i++)
            {
                Eat eat = new EatFactory().Create() as Eat;
                data.Eats.Add(eat);
                data.mapa.Print(eat.Figure);
            }
        }
        
    }
}
