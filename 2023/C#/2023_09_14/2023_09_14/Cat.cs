using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_14
{
    class Cat:Animal
    {
        public Cat()
        {
            Console.WriteLine("고양이 생성");
            this.Age = 0;
            counter++;
        }

        public void Bark()
        {
            Console.WriteLine("냥냥");
        }
    }
}
