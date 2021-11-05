using System.Collections.Generic;
using System.Linq;
using GeneticGameLogic.Figure.BotFigure;
using GeneticGameLogic.Graphic;

namespace GeneticGameLogic.Manager

{
     class FigureStorage
    {
        public List<Bot> Bots { get; set; }
        public List<Eat> Eats { get; set; }
        public Eat EatExistInCoord(Coord coord)
        {
            return Eats.FirstOrDefault(e => e.ModelCoord.Equals(coord));           
        }
        public FigureStorage()
        {
            Bots = new List<Bot>();
            Eats = new List<Eat>();
        }
        public void RemoveEat(Eat eat)
        {
           
            Eats.Remove(eat);
        }
        public void RemoveBots(IEnumerable<Bot> bots)
        { 
            foreach(Bot bot in bots)
            {
                Bots.Remove(bot);
                DataManager.GetInstance().mapa.Clean(bot.Model);
            }
        }
        public void AddBots(IEnumerable<Bot> bots)
        {
            Bots.AddRange(bots);
        }
        public void AddEat(Eat eat)
        {
            Eats.Add(eat);
        }
    }
}
