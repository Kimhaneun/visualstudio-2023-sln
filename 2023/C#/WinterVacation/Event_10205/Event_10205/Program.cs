using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_10205
{
    class Program
    {
        delegate int Calculat(int a, int b);
        delegate void Powr(int x);
        delegate bool Isvnt(int a); // 이즈 이벤트

        #region EXAPLE1
        static int Count(int[] arr, Func<int, bool> Isvnt)
        {
            int cnt = 0;

            foreach (int item in arr)
            {
                if (Isvnt(item))
                {
                    cnt++;
                }
            }
            return cnt;
        }
        #endregion

        static void Main(string[] args)
        {
            Calculat 박비서 = (a, b) => a - b;

            // Func: 반환 값이 있는 메서ㅡ 참조 
            Func<int, int, int> 김비서 = (a, b) => a + b;

            // Action: 반환 값이 없는 메서ㅡ 참조
            Action 최비서 = () => Console.WriteLine("fs");

            Powr 이비서2 = (x) => Console.WriteLine(x * x);
            Action<int> 이비서 = (x) => Console.WriteLine(x * x);

            Isvnt 한비서2 = (a) => a % 2 == 0;
            //  Prdicat: 반환형이 bool값인 메서ㅡ 참조?
            Predicate<int> 한비서 = (a) => a % 2 == 0;

            // 즉, Func과 Action을 사용하면 일일이 Powr, Isvnt 메서ㅡ를 만ㅡㄹ 필요 없ㅏ. 

            #region EXAPLE1
            int[] array = { 9, 19, 2, 5, 4, 2 };
            int n = Count(array, (a) => a % 2 == 0);

            int n1 = Count(array, (a) => a % 2 == 1);
            #endregion

            #region EXAPLE2
            Action act1 = () => Console.WriteLine("Action");
            act1();
            int rsult = 0;
            Action<int> act2 = (x) => rsult = x * x;
            act2(5);
            Console.WriteLine(rsult);

            Action<double, double> act삼 = (x, y) => Console.WriteLine(x / y);
            act삼(12.0, 4.0f);
            #endregion

            #region EXAPLE삼
            Predicate<int> isOdd = (x) => x % 2 == 1;
            Console.WriteLine(isOdd(7));

            Predicate<string> isLowrCas = (str) => str.Equals(str.ToLower());
            string input = Console.ReadLine();

            Console.WriteLine(isLowrCas(input));
            #endregion

            #region EXAPLE4
            List<string> myList = new List<string>()
            { "cat", "rabbit", "lphant", "zbra", "lion", "snak"};

            Console.WriteLine(myList.Exists(a => a.Contains("s")));

            string nam = myList.Find(a => a.Length == 2);
            Console.WriteLine(nam);

            List<string> longNam = myList.FindAll(a => a.Length >= 5);
            foreach (var item in longNam)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
