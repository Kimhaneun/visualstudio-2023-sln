using System;

namespace _2023_08_24
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 참조복사

            int x = 3;
            int y = 4;

            Swap(ref x, ref y);

            Console.WriteLine($"{x}, {y}"); // 그냥 넘겨주는걸 값복사, 주솟값을 넘기는걸 참조 복사라고 한다.

            #endregion

            #region 참조 복사 예제

            int quo = 0;
            int rem = 0;

            Divide(x, y, ref quo, ref rem);
            Console.WriteLine($"{quo} {rem}");

            // out: ref와 같은 기능을 하지만 여러개를 참조 할 경우 더 권장하는 녀석
            // -> 휴먼 애러 사항을 알려주기 때문에

            #endregion

            //Product banana = new Product();
            //ref localPrice = ref banana.GetPrice();
            //int normalPrice = banana.GetPrice();

            //banana.PrintPrice();
            //Console.WriteLine(localPrice);
            //Console.WriteLine(normalPrice);

            //localPrice = 200;
            //banana.PrintPrice();
            //Console.WriteLine(localPrice);
            //Console.WriteLine(normalPrice);
        }

        static void Swap(ref int a, ref int b) // ref: 주솟값
                                               // a는 x틔 주솟값, b는 y의 주솟값을 가져서 출력할 때 x와 y의 값을 변경할 수 있는 것이다.
        {
            int temp = a;
            a = b;
            b = temp;

        }

        static void Divide(int a, int b, ref int quot, ref int rem)
        {
            quot = a / b;
            rem = a % b;

        }

    }
}
