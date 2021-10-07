using System;


namespace GeneticGame
{
    class BotMover
    {
        int LeftMargine;
        int RightMargine;
        int UpMargine;
        int DownMargine;
        private int StepGo;
        Coord coord;
        Coord Direction;
        Random rand;
        private MapaManager mapa;
        public BotMover(MainWindow main,MapaManager _mapa)
        {
            mapa = _mapa;
            rand = new Random(DateTime.Now.Millisecond);
            StepGo = 20;
            LeftMargine = -Convert.ToInt32(main.Width*2  );
            UpMargine = -Convert.ToInt32(main.Height*2  );
            RightMargine = Convert.ToInt32(main.Width*2 ) ;
            DownMargine = Convert.ToInt32(main.Height*2 ) ;
            
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
            if (!BotOverMargine())
            {
                if (bot.ChanceChangeDirectione > rand.Next(1, 100) && bot.MoveDirection != null)
                {
                    Direction = (Coord)bot.MoveDirection;
 
                }
                else
                {
                    Go();
                }
      
                         
            }
            
            
            
            
            bot.MoveDirection = Direction;
            ChangeCoord();
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
            if (coord.X > RightMargine)
                Left();
           else if (coord.X < LeftMargine)
                Right();
           else if(coord.Y < UpMargine)
                Down();
           else if (coord.Y > DownMargine)
                Up();
            else
                 return false;

            return true;
        }
        private void Go()
        {
           
    
            switch (rand.Next(1, 9))
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
