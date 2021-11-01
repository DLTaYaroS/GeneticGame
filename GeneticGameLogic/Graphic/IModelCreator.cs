using System;
using System.Collections.Generic;
using System.Text;

namespace GeneticGameLogic.Graphic
{
    public interface IModelCreator
    {
        public IModel GetModel(Coord coord, IModelCreatorInput model);
    }
}
