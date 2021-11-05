using System;
using System.Collections.Generic;
using System.Text;
using GeneticGameLogic.Graphic;

namespace GeneticGameLogic.Figure.BotFigure
{
    interface IMover
    {
        public void RandomMoveBot(IModel model);
    }
}
