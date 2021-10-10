using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticGame
{
    public static class IntExtension
    {
        public static void  MutateChange(this int Count, int lvl)
        {
            Count += DataManager.GetInstance().rand.Next(-lvl, lvl);
        }
    }
}
