using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_18
{
    class Cat : Animal
    {
        #region 오버라이딩_1
        public void Eat()
        {
            Console.WriteLine("고양이는 아그작 아그작");
        }
        #endregion
    }
}
