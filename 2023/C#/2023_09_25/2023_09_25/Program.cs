using System;

namespace _2023_09_25
{
    class Program
    {
        static void Main(string[] args)
        {
            ClimateMonitor monitor0 = new ClimateMonitor(new ConsoleLogger());
            monitor0.Start();

            ClimateMonitor moitor1 = new ClimateMonitor(new FileLogger("MyLog.txt")); // 실행하면 파일 안에서 text 파일을 생성해준다.
            moitor1.Start();



            Developer developer = new Developer();
            developer.Work();

            Art art = new Art();
            art.Work();

            Manager manager = new Manager();
            manager.Work();



            Car 타요 = new Car(new Good());
            Car 가니 = new Car(new Bad());

            타요.Run();
            가니.Run();
        }
    }
}