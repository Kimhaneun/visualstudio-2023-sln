using System;

namespace _2023_3_15_1205_김한은
{
    class Program
    {
        static void Main(string[] args)
        {
            # region 복습

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = (a + b);
            Console.WriteLine(a + b);
            Console.WriteLine("두 수를 더한 값은 " + c + "입니다.");

            #endregion

            #region 이스캐이프 문자

            // 1. 탭 \t
            Console.WriteLine("Hello\tWorld!");

            // 2.줄바꿈 \n
            Console.WriteLine("Hello\nWorld!");

            // 3. 백스페이스 \b
            Console.WriteLine("Hello\boWord!");

            // 4. 캐리지리턴 \r
            Console.WriteLine("Hello\rWord!");

            // 5. 유니코드 \u
            Console.WriteLine('\u0065');

            #endregion

            #region

            // 소숫점 자릿수 지정
            float x = 3.14f;
            Console.WriteLine($"{x:F3}");

            // 정수 자릿수 지정
            int y = 5689;
            Console.WriteLine($"{y:D8}");

            // 화폐형식
            Console.WriteLine($"{y:c}");

            // 16진수 hexadecimal
            Console.WriteLine($"{y:z}");

            #endregion

            #region 입력한 값을 띄어쓰기를 기준으로 쪼개어 출력

            string[] str = Console.ReadLine().Split();
            for (int i = 0; i < str.Length; i++) 
            {
                Console.WriteLine(str[i] + " ");
            }
            foreach(string item in str)
            {
                Console.WriteLine(item);
            }

            #endregion
        }
    }
}
