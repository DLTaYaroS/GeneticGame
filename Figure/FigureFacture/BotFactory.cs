using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticGame
{
    public class BotFactory:FigureFactory
    {
        protected override IFigureModel Make()
        {
            Coord coord = Coord.GetRandomCoord();
            DataManager data = DataManager.GetInstance();
            IFigureModel result = new Bot() { ModelCoord = coord, Figure = data.create.GetModel(coord, data.BotModel), id = 0, ChanceChangeDirectione = 50 };
            return result;
        }
        
    }
}
