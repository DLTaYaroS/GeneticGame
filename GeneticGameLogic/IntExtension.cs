using GeneticGameLogic.Manager;

namespace GeneticGameLogic
{
    public static class IntExtension
    {
        public static void  MutateChange(this int Count, int lvl)
        {
            Count += DataManager.GetInstance().rand.Next(-lvl, lvl);
        }
    }
}
