namespace GeneticGame
{
    public static class IntExtension
    {
        public static int  MutateChange(this int Count, int lvl)
        {
            return Count += DataManager.GetInstance().rand.Next(-lvl, lvl);
        }
    }
}
