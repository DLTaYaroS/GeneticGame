using System;
using System.Collections.Generic;

namespace GeneticGame
{
    class FigureIdList
    {
        public List<IFigureModel> Bots { get; set; }
        public List<IFigureModel> Eats { get; set; }
        public FigureIdList()
        {
            Bots = new List<IFigureModel>();
            Eats = new List<IFigureModel>();
        }
        public void RemoveFigure(IFigureModel figure)
        {
            if (figure is Bot)
            {
                Bots.Remove(figure);
            }
            if (figure is Eat)
            {
                Eats.Remove(figure);
            }
        }
        public void AddFigure(IFigureModel figure)
        {
            if(figure is Bot)
            {
                Bots.Add(figure);
            }
            if(figure is Eat)
            {
                Eats.Add(figure);
            }
        }
    }
}
