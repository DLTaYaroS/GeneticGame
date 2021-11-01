namespace GeneticGameLogic.Figure.BotFigure
{
    public interface IBotEnergy
    {
        public void EatEnergy();
        public void CycleEnergy();
        public void BotMakeClone();
        public bool LowEnergy();
    }
}
