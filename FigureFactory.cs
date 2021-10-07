using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticGame
{
    public abstract class FigureFactory
    {
        protected abstract IFigureModel Make();
        public IFigureModel Create()
        {
            return this.Make();
        }
    }
}
