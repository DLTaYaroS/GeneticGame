using GeneticGame.Map;
namespace GeneticGame.Figure.BotFigure
{
    class BotMover
    {
        DataManager data;
        MargineLimit limit;
        private int StepGo;
        Coord coord;
        Coord Direction;
        private MapManager mapa;
        public BotMover(MargineLimit _limit)
        {
            limit = _limit;
            data = DataManager.GetInstance();
            mapa = data.mapa;           
            StepGo = 1;
        }
        private void ChangeCoord()
        {
            coord.X += Direction.X;
            coord.Y += Direction.Y;           
        }
        public void MoveBot(Bot bot, ModelCreatorInput model)
        {
            Direction.X = 0;
            Direction.Y = 0;
            coord =bot.ModelCoord;
            StepGo = bot.Speed;
            if (!BotOverMargine())
            {
                if (bot.ChanceChangeDirection > data.rand.Next(1, 100) && bot.MoveDirection != null)
                {
                    Direction = (Coord)bot.MoveDirection;
 
                }
                else
                {
                    Go();
                }                        
            }            
          
            ChangeCoord();
            bot.MoveDirection = Direction;
            bot.ModelCoord = coord;
            mapa.ChangePosition(model, bot.ModelCoord, bot.Figure);
        }
        private void Down()
        {
            Direction.X += 0;
            Direction.Y += StepGo;
        }
        private void DownLeft()
        {
            Direction.X += -StepGo;
            Direction.Y += StepGo;
        }
        private void DownRight()
        {
            Direction.X += StepGo;
            Direction.Y += StepGo;
        }
        private void Left()
        {
            Direction.X += -StepGo;
            Direction.Y += 0;
        }
        private void Right()
        {
            Direction.X += StepGo;
            Direction.Y += 0;
        }
        private void Up()
        {
            Direction.X += 0;
            Direction.Y += -StepGo;
        }
        private void UpLeft()
        {
            Direction.X += -StepGo;
            Direction.Y += -StepGo;
        }
        private void UpRight()
        {
            Direction.X += StepGo;
            Direction.Y += -StepGo;
        }
        public bool BotOverMargine()
        {      
            if (coord.X > limit.RightMargine)
                Left();
           else if (coord.X < limit.LeftMargine)
                Right();
           else if(coord.Y < limit.UpMargine)
                Down();
           else if (coord.Y > limit.DownMargine)
                Up();
            else
                 return false;
            return true;
        }
        private void Go()
        {  
            switch (data.rand.Next(1, 9))
            {
                case 1:
                    Down();
                    break;            
                case 2:
                    Left();
                    break;
                case 3:
                    DownLeft();
                    break;
                case 4:
                    UpRight();
                    break;
                case 5:
                    Up();
                    break;
                case 6:
                    UpLeft();
                    break;
                case 7:
                    Right();
                    break;
                case 8:
                    DownRight();
                    break;
            }
        }
    }
}
