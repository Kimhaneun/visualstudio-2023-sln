using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_10205
{
    class Diagram
    {
        public int x { get; set; }
        public int y { get; set; }
        public int Turn { get; set; }
        public int BlockNum { get; set; }

        public Diagram() // 도형이 생성 되었을 때
        {
            Reset();
        }

        public void Reset()
        {
            Random random = new Random();
            x = GameRule.SX;
            y = GameRule.SY;
            Turn = random.Next() % 4;
            BlockNum = random.Next() % 7;
        }

        internal void MoveLeft()
        {
            x--;
        }

        internal void MoveRight()
        {
            x++;
        }

        internal void MoveTurn()
        {
            Turn = (Turn + 1) % 4; // 0, 1, 2, 3 순서로 회전
        }

        internal void MoveDown()
        {
            // 실제 수학 좌표와는 다르다.
            // 테트리스 게임 이므로 위로 이동은 존재하지 않는다.
            y++;
        }
        
        
    }
}
