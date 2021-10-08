using System;


namespace GeneticGame
{
    class MutateBot:Bot
    {
        public  MutateBot():base()
        {
            characters.Size= MutateChange(base.characters.Size,1);
            characters.EnergyForCloned= MutateChange(base.characters.EnergyForCloned,10);
            characters.Speed= MutateChange(base.characters.Speed,1);
            characters.ChanceChangeDirectione = MutateChange(base.ChanceChangeDirectione, 3);
            Figure = DataManager.GetInstance().create.GetModel(ModelCoord, DataManager.GetInstance().BotModel);
        }
        private int MutateChange(int Charackter,int lvl)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int Count = rand.Next(-lvl, lvl);
            
            return Charackter+ Count;
        }
    }
}
