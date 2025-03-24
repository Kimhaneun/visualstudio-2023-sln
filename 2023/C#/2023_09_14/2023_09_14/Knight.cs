using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_14
{
    class Knight: Hero
    {
        #region 1교시
        public Knight()
        {
            Console.WriteLine("아처 생성");
            counter++;
        }
        #endregion

        #region 2교시
        public new void Fire()
        {
            Console.WriteLine("용이 내가 된다!");
        }
        #endregion
    }
}
