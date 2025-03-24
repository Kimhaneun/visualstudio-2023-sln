using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024Winter
{
    class Archr : Hero
    {
        public int arrow { get; set; }
        public int bow { get; set; }

        public void Go()
        {
            Console.WriteLine("활 쏘는 중입니ㅏ.");
        }

        private void bowAttack()
        {
            Console.WriteLine("쏘기!");
        }
    }
}
