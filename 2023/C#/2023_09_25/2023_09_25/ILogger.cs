using System;

namespace _2023_09_25
{
    interface ILogger // 인터페이스: 클래스가 따라야 할 약속
                      // 즉, 자식 클래스가 어떤 메서드를 구현해야 할지 정의한다.
    {
        void WriteLog(string log); // 인터페이스는 접근 한정자를 적지 않으면 자동으로 Public으로 선언힌단!
    }

    interface IFormattableLogger : ILogger
    {
        void ILogger(string foramat, params object[] args);
    }
}
