using System;

namespace _2023_5_2_1205_김한은
{
    class Car
    {
        internal int carNumber = 0;
        internal int inTime = 0;
        internal int outTime = 0;
        internal string id;

        // 소멸자
        ~Car()
        {
            Console.WriteLine(DateTime.Now.Ticks + "이 시점에 소멸자가 호출됨.");
        }



        // 생성자 => 오버로딩 (이름이 같은 메서드를 사용하는 것, 구분은 매개변수를 보고 구분함)
        public Car()
        {
            Console.WriteLine("자동차 클래스의 객체가 생성됨.");
        }

        public Car(string id, int inTime, int outTime)
        {
            this.id = id;
            this.inTime = inTime;
            this.outTime = outTime;

        }

        public Car(string id)
        {
            this.id = id;
            inTime = 0;
            outTime = 0;
        }

        public Car(string id, int inTime)
        {
            this.id = id;
            this.inTime = inTime;
            this.outTime = 0;
        }

        internal void Car_()
        {
            Console.WriteLine($"{carNumber}차의 요금은 {(outTime - inTime)} 입니다.");

        }
    }
}
