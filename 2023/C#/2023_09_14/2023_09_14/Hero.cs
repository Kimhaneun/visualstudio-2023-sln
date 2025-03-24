using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_14
{
    class Hero
    {
        #region 1교시
        protected static int counter = 0;

        public Hero()
        {
            Console.WriteLine("영웅 생성");
        }

        public void CounterPrint()
        {
            Console.WriteLine(counter);
        }
        #endregion

        public void Fire()
        {
            Console.WriteLine("Q");

        }
    }
}
