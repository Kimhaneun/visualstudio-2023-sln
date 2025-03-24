using System;

namespace _2023_09_25
{
    class Car : IPerson, ILogger
    {
        Ibattery _Ibattery;

        public Car(Ibattery ibattery)
        {
            this._Ibattery = ibattery;
        }

        public void Run()
        {
            Console.WriteLine($"{_Ibattery.GetName()}) 배터리를 장착한 " + $"자동차가 달리고 있다.");
        }

        public void Work()
        {
            throw new NotImplementedException();
        }

        public void WriteLog(string log)
        {
            throw new NotImplementedException();
        }
    }
}
