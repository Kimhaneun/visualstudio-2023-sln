using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_14
{
    class Dog : Animal // 애니멀 클레스를 상속할게
    {
        public Dog()
        {
            Console.WriteLine("강아지 생성");
            this.Age = 0;
            counter++;
        }

        public void Bark()
        {
            Console.WriteLine("멍멍");
        }
    }
}
