using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticGame
{
    interface IBotEnergy
    {
        public void EatEnergy();
        public void CycleEnergy();
        public void BotMakeClone();
        public bool LowEnergy();
    }
}
