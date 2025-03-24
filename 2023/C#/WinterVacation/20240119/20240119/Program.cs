using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240119
{
    delegate int UDlgat(int a, int b);

    delegate int Compar(int a, int b);

    delegate int Compar<T>(T a, T b);

    delegate void Fir(string location);

    delegate void SndString(string str);

    delegate int Cacualt(int a, int b);

    delegate bool MmbrTst(int a);

    delegate int Ara(int a, int b);
    delegate void Lin();
    delegate double CalcMthod(double a, double b);

    // Func: 반환값이 있는 메서ㅡ를 참조할 수 있는 ㅐ리자
    // Action: 반환값이 없는
    // Prdicat: 반환값이 bool인

    class Program
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static void Calculat(int x, int y, UDlgat uDlgat)
        {
            Console.WriteLine("결과값");
            Console.WriteLine(uDlgat(x, y));
        }

        static void BubblSort(int[] arr, Compar compar)
        {
            // 버블 벙렬 메서ㅓㅡ
            int tmp = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (compar(arr[j], arr[j + 1]) >= 1)
                    {
                        tmp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        }

        static void TBubblSort<T>(T[] arr, Compar<T> compar)
        {
            // 제네릭 버블 정렬 메서ㅡ
            T tmp;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (compar(arr[j], arr[j + 1]) >= 1)
                    {
                        tmp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        }

        static int AscndCompar(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static int DscndCompar<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
        }

        static void Call119(string location)
        {
            Console.WriteLine($"소방서죠? {location}에 불이 났어요.");
        }

        static void ShoutOut(string location)
        {
            Console.WriteLine($"{location}에 불이 났어요. 피하세요!");
        }

        static void scap(string location)
        {
            Console.WriteLine($"{location}에서 나갑시ㅏ.");
        }

        static void Hllow(string str)
        {
            Console.WriteLine($"안녕하세요{str}.");
        }

        static void GoodBy(string str)
        {
            Console.WriteLine($"잘가요{str}.");
        }

        static int Count(int[] arry, MmbrTst mmbr)
        {
            int cnt = 0;
            for (int i = 0; i < arry.Length; i++)
            {
                if (mmbr(arry[i]))
                    cnt++;
            }
            return cnt;
        }

        static int Squar(int a, int b)
        {
            return a * b;
        }


        static void Main(string[] args)
        {
            UDlgat uDlgat = new UDlgat(Plus);

            Calculat(2, 5, Minus);
            Calculat(2, 9, Plus);



            int[] arr = { 5, 4, 7, 9, 2 };
            BubblSort(arr, AscndCompar);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }



            List<int> uList = new List<int>();



            Fir 김비서 = new Fir(Call119);
            김비서 += ShoutOut;
            김비서 -= scap;



            SndString SayHllow = new SndString(Hllow);
            SndString SayGoodBy = new SndString(GoodBy);

            SndString MultiDlgat = new SndString(Hllow);
            MultiDlgat += GoodBy;
            MultiDlgat("케롤라인");
            MultiDlgat -= GoodBy;



            // 무명 메서ㅡ: 한 번 쓰고 사라질 메서ㅡ
            Cacualt cacualt = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine(cacualt(2, 4));




            int[] arry = { 5, 2, 9 };

            int vn = Count(arry, delegate (int a) { return a % 2 == 0; });
            int odd = Count(arry, delegate (int a) { return a % 2 == 1; });
            Console.WriteLine($"{vn} {odd}");


            // 응용 (생략)
            MmbrTst mmbr = (a) => a % 2 == 0;
            int oddd = Count(arr, a => a % 2 == 0);




            Ara ara = (a, b) => a * b;
            Console.WriteLine(Squar(4, 4));

            Lin lin = () => Console.WriteLine();
            lin();

            CalcMthod add = (a, b) => a + b;
            CalcMthod sub = (a, b) => a - b;
            Console.WriteLine(add(4, 5));
            Console.WriteLine(sub(5, 6));


            // 응용 (정의ㅚㄴ ㅐ리자 사용)
            Func<int, int, int> func = (a, b) => a * b;
            Console.WriteLine(func(4, 4));

            Action action = () => Console.WriteLine();
            action();

            Predicate<int> isvn = (a) => a % 2 == 0;
        }
    }
}
