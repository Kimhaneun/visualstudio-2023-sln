using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_14
{
    class Archer : Hero
    {
        #region 1교시
        public Archer()
        {
            Console.WriteLine("아처 생성");
            counter++;
        }
        #endregion

        #region 2교시
        public new void Fire()
        {
            Console.WriteLine("용이여 적들을 삼켜라!");
        }
        #endregion
    }
}
