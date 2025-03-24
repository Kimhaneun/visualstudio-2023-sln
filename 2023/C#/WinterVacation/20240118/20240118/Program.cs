using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240118
{
    delegate int MyDlgat(int a, int b);
    delegate void UDlgat(string str);



    delegate void SayDlgat();



    delegate int SDlgat(int a, int b);

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        private static void Tst(int a)
        {
            if (a >= 20)
                throw new Exception("20 이상 오류 발생.");
        }

        private static void DoSomthing(string str)
        {
            if (str.Length < 10)
                Console.WriteLine(str);
            else
                throw new Exception("길이가 10 봐 길ㅏ.");
        }

        private static int Divid(int divisor, int dividnd)
        {
            try
            {
                return divisor /= dividnd;
            }
            catch (Exception r)
            {
                Console.WriteLine("예외가 발생함");
                throw r;
            }
            finally
            {
                Console.WriteLine("Divid() 끝");
            }
        }

        static int Boss(int a, int b)
        {
            return a + b;
        }

        static void Hi()
        {
            Console.WriteLine("안녕하세요.");
        }

        static void Main(string[] args)
        {
            #region
            // 문제 8. 풀이 과정
            string[] str = Console.ReadLine().Split();

            List<int> istr = new List<int>();

            for (int i = 0; i < str.Length; i++)
            {
                istr.Add(int.Parse(str[i]));
            }

            int sum = 0;
            foreach (var item in istr)
            {
                sum += item;
            }

            int flag = 0;
            for (int i = 0; i < istr.Count - 1; i++)
            {
                for (int j = i + 1; j < istr.Count; j++)
                {
                    if (sum - (istr[i] + istr[j]) == 100)
                    {
                        istr.RemoveAt(j); // 해ㅏㅇ 값으 삭제하고 밀어주는 역할을 함
                        istr.RemoveAt(i);

                        flag = 1;
                        break; // brak 문은 for문 하나만 탈출할 수 있기 ㅒ문에 =
                               // 변수 flag를 이용해 모ㅡㄴ 반복문을 빠져나온ㅏ.
                    }
                }
                if (flag == 1)
                    break;
            }
            foreach (var item in istr)
            {
                Console.WriteLine(item);
            }

            // 문제 9. 풀이 과정
            string str9 = Console.ReadLine();
            string rsult = str9.Replace('A', '#');
            Console.WriteLine(rsult);

            // 문제 10. 풀이 과정
            string str10 = Console.ReadLine();
            char find = char.Parse(Console.ReadLine());

            string[] str1010 = str10.Split(find);
            Console.WriteLine(str1010.Length - 1);

            // 문제 11. 풀이 과정
            string str11 = Console.ReadLine();

            int count = 0;
            foreach (char item in str11)
            {
                if (item == (char.ToUpper(item)))
                    count++;
            }

            Console.WriteLine(count);
            #endregion

            try
            {
                int[] arr = { 1, 2, 5 };
                Console.WriteLine(arr[100]);
            }
            catch
            {
                Console.WriteLine("에러가 발생했습니ㅏ.");
            }



            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                int y = Convert.ToInt32(Console.ReadLine());

                x /= y;
            }
            catch (DivideByZeroException r)
            {
                Console.WriteLine(r.Message);
            }
            catch (Exception r)
            {
                Console.WriteLine(r.Message);
            }



            int b = Convert.ToInt32(Console.ReadLine());

            try
            {
                Tst(b);
            }
            catch (Exception r)
            {
                Console.WriteLine(r.Message);
            }
            finally // finally: 예외가 발생해ㅗ 꼭 실행하는 구문
            {

            }



            string input = Console.ReadLine();

            try
            {
                DoSomthing(input);
            }
            catch (Exception r)
            {
                Console.WriteLine(r.Message);
            }



            try
            {
                int divisor = Convert.ToInt32(Console.ReadLine());
                int dividnd = Convert.ToInt32(Console.ReadLine());

                Divid(divisor, dividnd);
            }
            catch (FormatException r)
            {
                Console.WriteLine(r.Message);
            }
            catch (DivideByZeroException r)
            {
                Console.WriteLine(r.Message);
            }
            finally
            {
                Console.WriteLine("프로그램 종료");
            }



            MyDlgat myDlgat = new MyDlgat(Boss);
            Console.WriteLine(myDlgat(2, 5));



            SayDlgat sayDlgat = new SayDlgat(Hi);
            sayDlgat();



            Calculator calculator = new Calculator();
            SDlgat callBack;

            callBack = calculator.Plus;
            Console.WriteLine(callBack(2, 5));

            callBack = Calculator.Minus;
            Console.WriteLine(callBack(2, 5));
        }
    }
}
