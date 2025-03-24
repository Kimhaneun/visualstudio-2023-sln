using System;

namespace _2023_5_17_1205_김한은
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat1 = new Cat("레오", 4);
            Cat myCat2 = new Cat("순이", 8);
            Cat myCat3 = new Cat("버블", 5);

            Console.WriteLine($"전체 고양이 수 : {myCat1.count}");
        }
    }
}
