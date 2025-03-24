using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omok_10205
{
    class Revive
    {
        public int x { get; set; }
        public int y { get; set; }
        public STONE Stone { get; set; } // 돌 색
        public int Seq { get; set; } // 돌 순서

        public Revive(int x, int y, STONE sTONE, int seq)
        {
            this.x = x;
            this.y = y;
            Stone = sTONE;
            Seq = seq;
        }
    }
}
