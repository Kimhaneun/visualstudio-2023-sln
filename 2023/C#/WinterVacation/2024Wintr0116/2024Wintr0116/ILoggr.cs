using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024Wintr0116
{
    interface ILoggr // interface: 클래스가 지켜야 할 약속을 의미
    {
        // 구현이 없는  프로퍼티 / 메서ㅡ 이벤트 / 인ㅔㄱ서가 ㅡㄹ어갈 수 있ㅏ.
        int MyProprty { get; set; }
        void writhLog(string log);
    }

    class Con : ILoggr
    {
        public int MyProprty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void writhLog(string log)
        {
            System.Console.WriteLine(log);
        }
    }

    interface IPrson
    {
        void Work();
    }

    class Dvlopr : IPrson
    {
        public void Work()
        {
            Console.WriteLine("개발을 합니ㅏ.");
        }
    }
}
