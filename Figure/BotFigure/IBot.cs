using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
namespace GeneticGame
{
    interface IBot
    {
        
        public int ChanceChangeDirection { get; set; }
        public Coord Direction { get; set; }
        public void Eat();
        public Bot CloneMute(int id);
        public void Step();
    }
}
