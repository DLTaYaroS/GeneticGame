using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticGame
{
     struct BotCharacters
    {
        public BotCharacters(int EnergyForCloned, int Speed,int Size)
        {
            this.EnergyForCloned = EnergyForCloned;
            this.Speed = Speed;
            this.Size = Size;
        }
        public int EnergyForCloned;
        public int Speed;
        public int Size;
    }
}
