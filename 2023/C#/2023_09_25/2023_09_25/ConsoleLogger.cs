using System;

namespace _2023_09_25
{
    //class ConsoleLogger : ILogger // 애러가 생겼을 때 Art + Enter 키 누르고 인터페이스 구현 하면 자동으로 만들어줌 ㅇㅇ 
    //{
    //    public void WriteLog(string log)
    //    {
    //        Console.WriteLine($"{DateTime.Now}, {log}");
    //    }
    //}

    class ConsoleLogger : IFormattableLogger
    {
        public void ILogger(string foramat, params object[] args)
        {
            foreach (var item in args)
            {
                Console.WriteLine(item);
            }
        }

        public void WriteLog(string log)
        {
            Console.WriteLine(log);
        }
    }
}
