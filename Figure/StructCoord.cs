namespace GeneticGame
{ 
    public struct Coord
    {
        public static Coord GetRandomCoord()
        {
            Coord c;
            DataManager data = DataManager.GetInstance();
         
            c.X = data.rand.Next(data.LeftMargine, data.RightMargine);
            c.Y = data.rand.Next(data.UpMargine, data.DownMargine);
            return c;
        }
        public int X;
        public int Y;
    }
}
