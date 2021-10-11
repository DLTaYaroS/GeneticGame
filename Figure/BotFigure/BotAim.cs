using System.Linq;

namespace GeneticGame.Figure.BotFigure
{
    static class BotAim
    {
        private static int LvlRadar=100;
        private static bool CheckCoord(Coord botCoord,Coord direction)
        {
            var eatList = DataManager.GetInstance().ModelList.Eats;
            var selectEat = eatList.Where(e => e.ModelCoord.Equals(botCoord + direction)).ToList();
            if (selectEat.Count>0)
                return true;
            else
                return false;
        }
        private static Coord GetFirstEat(Coord botCoord, int lvl)
        {
            
            Coord direction = new Coord();
            direction.X = lvl;
            direction.Y = lvl;
            if (CheckCoord(botCoord, direction))
                return direction;
            direction.X = 0;
            direction.Y = lvl;
            if (CheckCoord(botCoord, direction))
                return direction;
            direction.X = lvl;
            direction.Y = 0;
            if (CheckCoord(botCoord, direction))
                return direction;
            direction.X = -lvl;
            direction.Y = 0;
            if (CheckCoord(botCoord, direction))
                return direction;
            direction.X = 0;
            direction.Y = -lvl;
            if (CheckCoord(botCoord, direction))
                return direction;
            direction.X = -lvl;
            direction.Y = -lvl;
            if (CheckCoord(botCoord, direction))
                return direction;
            direction.X = -lvl;
            direction.Y = lvl;
            if (CheckCoord(botCoord, direction))
                return direction;
            direction.X = lvl;
            direction.Y = -lvl;
            if (CheckCoord(botCoord, direction))
                return direction;
            return new Coord { X = 0, Y = 0 };


        }
        public static Coord GetDirectione(Coord coord)
        {
            Coord zero = new Coord { X = 0, Y = 0 };
            Coord direction;
            for(int i = 0; i < LvlRadar; i++)
            {
               direction= GetFirstEat(coord, 1);
                if (!direction.Equals(zero))
                {
                    return direction;
                }
            }
            return zero;
           
        }
    }
}
