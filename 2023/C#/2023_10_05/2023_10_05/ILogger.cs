using System;

namespace _2023_10_05
{
    #region 인터페이스 복습
    interface ILogger // 구현을 무조건 해야하는 강제성을 가지기 때문에
                      // 자식 클래스가 지켜야 할 규칙이라 말하는것
    {
        void WriteLog(string message);
    }

    interface IFormattableLogger : ILogger
    {
        void WriteLog(string str, int[] arr);
    }

    //class ConsoleLogger : ILogger
    //{
    //    public void WriteLog(string message)
    //    {
    //        Console.WriteLine($"{DateTime.Now}, {message}");
    //    }
    //}

    class ConsoleLogger : IFormattableLogger // 이러면 메서드의 이름이 같으므로 두 개의 메서드를 구현해야 한다.
                                             // 이렇듯 인터페이스를 여러개 상속할 수 있다.
    {
        public void WriteLog(string str, int[] arr)
        {
            throw new NotImplementedException();
        }

        public void WriteLog(string message)
        {
            throw new NotImplementedException();
        }
    }

    class A
    {

    }

    class B
    {

    }

    // class C : A, B 
    // 추상클래스 말고 인터페이스를 사용하는 이유
    // C 클래스에서 A 클래스와 B 클래스 모두 사용하고 싶어!
    // 하지만 부모를 여럿 둘 수 없대
    // -> 하지만 인터페이스를 여러개 상속하는건 가능해!
    #endregion
}
