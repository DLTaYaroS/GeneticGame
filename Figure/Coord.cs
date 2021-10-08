using System;
namespace GeneticGame
{ 
    public struct Coord:IEquatable<Coord>
    {
        public override bool Equals(object obj)
        {
            
            return base.Equals(obj);
        }
        public static Coord GetRandomCoord()
        {

            DataManager data = DataManager.GetInstance();

            return new Coord
            {
                X = data.rand.Next(data.LeftMargine, data.RightMargine),
                Y = data.rand.Next(data.UpMargine, data.DownMargine)
            };
          
        }

        public bool Equals(Coord other)
        {
            return other.X == this.X && other.Y == this.Y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
