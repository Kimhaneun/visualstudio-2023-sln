using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_10205
{
    class GameRule
    {
        #region STATE CONSTANT
        internal const int B_WIDTH = 30; // 사각형 한 칸의 너비
        internal const int B_HEIGHT = 30; // 사각형 한 칸의 높이
        internal const int BX = 12; // 가로로 들어가는 사각형 갯수
        internal const int BY = 20; // 세로로 들어가는 사각형 갯수
        internal const int SX = 4; // 도형이 떨어지는 시작 논리적 좌표 X
        internal const int SY = 0; // 도형이 떨어지는 시작 논리적 좌표 Y
        #endregion
    }
}
