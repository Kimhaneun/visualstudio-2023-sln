using System;

namespace DelegateEvent_10205
{
    class Program
    {
        #region ANONYMOUS METHOD
        delegate int Calculate(int a, int b);

        static int Plus(int a, int b) // 반환값이 정수인 메서드
        {
            return a + b;
        }

        static int Minus(int a, int b) // 반환값이 정수인 메서드22
        {
            return a - b;
        }
        #endregion

        #region
        delegate int Calculate2(int x, int y);

        delegate void Print();

        static int Minus2(int a, int b)
        {
            return a - b;
        }
        #endregion

        #region ANONYMOUS METHOD EXAMPLE
        delegate int Area(int a, int b);
        delegate void Line();
        delegate double CalcMethod(double a, double b);
        #endregion

        static void Main(string[] args)
        {
            #region ANONYMOUS METHOD
            Calculate 김비서;

            // 무명 메서드: 메서드가 아니지만 형태(하는 일)가 매서드인 메서드
            // 본래 메서드는 재사용을 위해 사용하지만 그럴 필요 없을 경우 무명 메서드를 기용
            김비서 = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine(김비서(2, 5));
            #endregion

            #region
            Calculate2 최비서 = (x, y) => x + y; // 이렇게 짧게 쓸 수 도!! 

            Calculate2 박비서 = (x, y) => x + y; // 연결이 끊어지면 다시 호출할 수 없다 
            박비서 = Minus2;

            Print 강비서 = () =>
            {
                Console.WriteLine("sfaf");
                Console.WriteLine("FS");
                Console.WriteLine("dsfds");
            };
            #endregion

            #region ANONYMOUS METHOD EXAMPLE
            Area square = (a, b) => a * b;
            square(4, 3);

            Line line = () => Console.WriteLine();
            line();

            CalcMethod add = (a, b) => a + b;
            CalcMethod sub = (a, b) => a - b;
            add(3.5, 6.7);
            sub(4.9, 3.6);
            #endregion
        }
    }
}
