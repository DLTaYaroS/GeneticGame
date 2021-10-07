using System;


namespace GeneticGame
{
    class MutateBot:Bot
    {
        
        protected int Id;
        public  MutateBot(Coord coord,int Id):base()
        {
            characters.Size= MutateChange(base.characters.Size,1);
            characters.EnergyForCloned= MutateChange(base.characters.EnergyForCloned,10);
            characters.Speed= MutateChange(base.characters.Speed,1);
              
            
        }
        private int MutateChange(int Charackter,int lvl)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int Count = rand.Next(-lvl, lvl);
            
            return Charackter+ Count;
        }
    }
}
