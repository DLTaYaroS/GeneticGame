﻿namespace GeneticGame
{
    public class EatFactory:FigureFactory
    {
        protected override IFigureModel Make()
        {
            Coord coord = Coord.GetRandomCoord();
            DataManager data = DataManager.GetInstance();
            IFigureModel result = new Eat() { ModelCoord = coord, id=0, Figure = data.create.GetModel(coord, data.EatModel) };
            return result;
        }
    }
}
