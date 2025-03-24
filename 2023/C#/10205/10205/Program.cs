using System;

namespace _10205
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 문제 1.

            //string[] s1 = Console.ReadLine().Split();

            //int A1 = Convert.ToInt32(s1[0]);
            //int B1 = Convert.ToInt32(s1[1]);
            //int C1 = Convert.ToInt32(s1[2]);

            //if (A1 <= 100 && B1 <= 100 && C1 <= 100)
            //{
            //    if (A1 < B1 && A1 < C1)
            //    {
            //        Console.WriteLine(A1);
            //    }

            //    if (B1 < A1 && B1 < C1)
            //    {
            //        Console.WriteLine(B1);
            //    }

            //    if (C1 < A1 && C1 < B1)
            //    {
            //        Console.WriteLine(C1);
            //    }
            //}

            #endregion

            #region 문제 2.

            //string[] s2 = Console.ReadLine().Split();

            //int A2 = Convert.ToInt32(s2[0]);
            //int B2 = Convert.ToInt32(s2[1]);
            //int C2 = Convert.ToInt32(s2[2]);

            //// 최대 길이는 남은 두개의 합보다 작아야하며, 같으면 안된다

            //if (A2 <= 100 && B2 <= 100 && C2 <= 100)
            //{
            //    if (A2 > B2 && A2 > C2)
            //    {
            //        if (A2 != B2 + C2 && A2 < B2 + C2)
            //        {
            //            Console.WriteLine("Yes");
            //        }

            //        else
            //        {
            //            Console.WriteLine("NO");
            //        }
            //    }

            //    if (B2 > A2 && B2 > C2)
            //    {
            //        if (B2 != A2 + C2 && B2 < A2 + C2)
            //        {
            //            Console.WriteLine("Yes");
            //        }

            //        else
            //        {
            //            Console.WriteLine("NO");
            //        }
            //    }

            //    if (C2 > A2 && C2 > B2)
            //    {

            //        if (C2 != A2 + B2 && C2 < A2 + B2)
            //        {
            //            Console.WriteLine("Yes");
            //        }

            //        else
            //        {
            //            Console.WriteLine("NO");
            //        }
            //    }

            //}

            #endregion

            #region 문제 3.

            //int N3 = Convert.ToInt32(Console.ReadLine());

            //if (N3 <= 1000)
            //{
            //    if (N3 % 12 == 0)
            //    {
            //        Console.WriteLine(N3 / 12);
            //    }

            //    else
            //    {
            //        Console.WriteLine(N3 / 12 + 1);
            //    }
            //}

            #endregion

            #region 문제 4.

            //int N4 = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //if (N4 <= 20)
            //{
            //    for (int i = 0; i <= N4; i++)
            //    {
            //        sum += i;
            //    }

            //    Console.WriteLine(sum);
            //}

            #endregion

            #region 문제 5.

            string[] s5 = Console.ReadLine().Split();
            int[] s5list = Array.ConvertAll(s5, int.Parse);

            // .
            // .
            // .

            #endregion


            // 입력받은 문자열 모두를 int 로 바꾸는 방법
            //int[] istr = Array.ConvertAll(string, int.Parse);
        }
    }
}
