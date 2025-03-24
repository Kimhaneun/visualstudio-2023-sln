using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_14
{
    class Animal
    {
        protected int Age { get; set; }

        protected static int counter = 0;

        public void Print()
        {
            Console.WriteLine(counter);
        }

        public Animal()
        {
            Console.WriteLine("동물 생성");
        }

        public void Eat()
        {
            Console.WriteLine("냠냠");
        }

        public void Sleep()
        {
            Console.WriteLine("zz");
        }
    }
}
