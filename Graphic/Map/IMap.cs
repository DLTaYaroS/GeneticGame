using GeneticGame.Graphic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticGame.Graphic.Map
{
    interface IMap
    {
        public void Print(IModel model);
        public void Clean(IModel model);
        public void ChangePosition(IModel model);
        
    }
}
