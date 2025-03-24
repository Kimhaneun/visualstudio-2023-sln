using System;
using System.Threading;

namespace _2023_5_2_1205_김한은
{
    class Program
    {
        static void Test()
        {
            Car myCar = new Car();
        }


        static void Main(string[] args)
        {
            //Car car1 = new Car();
            //car1.carNumber = 04;

            ////Student kimhaneun = new Student();

            //kimhaneun.name = "Kimhaneun";
            //kimhaneun.id = 10205;
            //kimhaneun.introdusce();

            //kimhaneun.Age = 17;     Age 는 public 아라서 접근이 가능하지만,
            //                        age 는 private 로 보호하였기 때문에 접근이 불가하다.


            //    Console.WriteLine("kimhaneun을 몇 번 공부시킬까?");

            //    int input = int.Parse(Console.ReadLine());

            //    for (int i = 0; i < input; i++)
            //    {
            //        kimhaneun.Study();
            //    }
            //    if (kimhaneun.count >= 5)
            //    {
            //        kimhaneun.RunAway();

            //        Console.WriteLine("kimhaneun이 탈주하였습니다.\n kimhaneun은 얼마나 놀까요?");
            //        int inputplay = int.Parse(Console.ReadLine());

            //        for (int j = 0; j < inputplay; j++)
            //        {
            //            kimhaneun.Play();
            //        }
            //        if (kimhaneun.count < 10)
            //        {
            //            kimhaneun.Comehome();
            //        }
            //    }

            Console.WriteLine(DateTime.Now + "프로그램 실행 시작.");
            Test(); // Test 메서드 호출
            GC.Collect();
            Thread.Sleep(1000);

            Car maycar = new Car();
            //maycar.~Car(); // 소멸자를 프로그래머가 호출하는것이 아닌 가비지 컬랙터가 호출하기 때문에 에러가 나온다.
                             // 생성자와 다르게, 오버로딩이 불가하다.

            Car youcar = new Car("12가3456");
            Car hiscar = new Car("34나5678", 20);
            Car hercar = new Car("67다7890", 30, 70);



        }
    }
}
