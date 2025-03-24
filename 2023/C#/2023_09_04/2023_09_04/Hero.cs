using System;

namespace _2023_09_04
{
    public class Hero
    {   // [접근 한정자]
        // protected: 다른 곳에서는 접근을 불허하지만, 자식에겐 허가한다.
        // internal: 같은 네임스페이스 안에서는 접근을 허용한다.
        // public: 모든 곳에서 접근을 허용한다.

        // 공통되는 속성
        public string name { get; set; }
        public int lv { get; set; }
        public int hp { get; set; }
        public int exp { get; set; }

        internal void Walk()
        {
            Console.WriteLine("걸어서 이동 중입니다.");
            hp -= 5;
        }

        internal void Run()
        {
            Console.WriteLine("뛰어가는 중입니다.");
            hp -= 10;
        }
    }
}



