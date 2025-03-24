using System;
using System.Collections.Generic;
using System.Drawing; // Point의 사용을 위해
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_10205
{
    class Game
    {
        Diagram now;
        Board gBoard = Board.GameBoard; // Singleton Board 객체를 받아올 gBoard 선언

        public int BlockNum
        {
            get
            {
                return now.BlockNum;
            }
        }

        public int Turn
        {
            get
            {
                return now.Turn;
            }
        }

        internal Point nowPosition
        {
            get
            {
                if (now == null)
                {
                    return new Point(0, 0);
                }
                return new Point(now.x, now.y);
            }
        }

        internal int this[int x, int y]
        {
            get
            {
                return gBoard[x, y];
            }
        }

        #region SINGLETON
        internal static Game Singleton
        {
            get; private set;
        }

        static Game() // 정적 생성자
        {
            Singleton = new Game();
        }

        Game()
        {
            now = new Diagram();
        }
        #endregion

        #region MOVEMENT OF SHAPES
        internal bool CanMoveLeft()
        {
            for (int xx = 0; xx < 4; xx++)
            {
                for (int yy = 0; yy < 4; yy++)
                {
                    if (BlockValue.bvals[now.BlockNum, Turn, xx, yy] != 0)
                    {
                        if (now.x + xx <= 0)
                        {
                            return false;
                        } 
                    }
                }
            }
            if (gBoard.MoveEnable(now.BlockNum, Turn, now.x-1, now.y))
        	{
                  now.MoveLeft();
                  return true;
        	}
            return false;

            //if (now.x > 0)
            //{
            //    now.MoveLeft();
            //    return true;
            //}
            //else
            //    return false;
        }

        internal bool CanMoveRight()
        {
            for (int xx = 0; xx < 4; xx++)
            {
                for (int yy = 0; yy < 4; yy++)
                {
                    if (BlockValue.bvals[now.BlockNum, Turn, xx, yy] != 0)
                    {
                        if (now.x + xx + 1 >= GameRule.BX)
                        {
                            return false;
                        }
                    }
                }
            }
            if (gBoard.MoveEnable(now.BlockNum, Turn, now.x + 1, now.y))
        	{
                 now.MoveRight();
                 return true;
	        }
            return false;
            //if ((now.x + 1) < GameRule.BX)
            //{
            //    now.MoveRight();
            //    return true;
            //}
            //else
            //    return false;
        }

        internal bool CanMoveDown()
        {
            for (int xx = 0; xx < 4; xx++)
            {
                for (int yy = 0; yy < 4; yy++)
                {
                    if (BlockValue.bvals[now.BlockNum, Turn, xx, yy] != 0)
                    {
                        if (now.y + yy + 1 >= GameRule.BY)
                        {
                            gBoard.Store(now.BlockNum, Turn, now.x, now.y);
                            return false;
                        }
                    }
                }
            }
            if (gBoard.MoveEnable(now.BlockNum, Turn, now.x, now.y + 1))
            {
                   now.MoveDown();
                   return true;
            }
            gBoard.Store(now.BlockNum, Turn, now.x, now.y);
            return false;
               
            //if ((now.y + 1) < GameRule.BY)
            //{
            //    now.MoveDown();
            //    return true;
            //}
            //else
            //    return false;
        }

        internal bool CanMoveTurn()
        {
            for (int xx = 0; xx < 4; xx++)
            {
                for (int yy = 0; yy < 4; yy++)
                {
                    if (BlockValue.bvals[now.BlockNum, (Turn + 1) % 4, xx, yy] != 0)
                    {
                        if ((now.x + xx < 0) || (now.x + xx >= GameRule.BX) || (now.y + yy >= GameRule.BY)) ;
                        {
                            return false;
                        }
                    }
                }
            }
            if(gBoard.MoveEnable(now.BlockNum, (Turn + 1) % 4, now.x, now.y))
            {
                now.MoveTurn();
                return true;
            }
            return false;
        }
        
        internal bool CanNext()
        {
            now.Reset();
            return gBoard.MoveEnable(now.BlockNum, Turn, now.x, now.y);
        }

        internal void Restart()
        {
            gBoard.ClearBoard();
        }
        #endregion
    }
}
