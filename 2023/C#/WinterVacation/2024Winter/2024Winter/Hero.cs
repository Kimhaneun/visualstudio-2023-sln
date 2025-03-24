using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024Winter
{
    class Hero
    {
        public string nam { get; set; }
        float xp { get; set; }

        internal void Walk()
        {
            // 반환값이 없는 메서ㅡ
            Console.WriteLine("걸어서 이ㅗㅇ 중입니ㅏ.");
        }

        protected void Run() // 자식 클래스 내부에서 접근 가능 
        {
            Console.WriteLine("ㅟ어가는 중입니ㅏ.");
        }

        internal string Fir() // internal: 같은 namespace 소속에게 공개ㅚㅁ
        {
            // 반환값이 있는 메서ㅡ

            // 반환에 조건이 있는 경우
            // !주의! 예외가 있어선 안ㅚㄴㅏ.
            if (xp > 50)
                return "특급 필살기!";
            else
                return "필살기!";
        }
    }
}
