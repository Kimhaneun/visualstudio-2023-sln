using System;

namespace _2023_3_22_1205_김한은
{
    class Program
    {
        static void Main(string[] args)
        {
            float ff = 3.141592653589793238462643383f;
            double dd = 3.141592653589793238462643383;
            decimal de = 3.141592653589793238462643383m;

            Console.WriteLine(ff);
            Console.WriteLine(dd);
            Console.WriteLine(de);

            // 문제. 이 코드에서 잘못된 부분은?
            int number = 2049;
            Console.WriteLine(number/45);
            // 정답. 디버그를 실행하면 소숫점의 자리가 나오지 않는다. 따라서 코드의 int 를 float 로 바꾸거거나 ((float)number/45); 로 바꾸거나 (number/45.0f); 로 바꾸어야 한다.

            // 문자 형식
            char a = 'a';
            char b = 'b';
            char c = 'c';
            char d = 'd';
            char e = 'e';

            // 문제. 이 코드는 왜 숫자가 나올까?
            Console.WriteLine(a+b+c+d+e);
            // 정답. 더하는 코드가 되어버렸기 때문...
            Console.WriteLine("{0}{1}{2}{3}{4}", a,b,c,d,e);
            Console.WriteLine($"{a}{b}{c}{d}{e}");

            // 문자열 형식
            string abc = "abcde";

            Console.WriteLine(abc);

            char[] arr = { '안', '녕', '하', '세', '요' };
            abc = new string(arr);

            Console.WriteLine(abc);

            bool tt = true;
            bool fa = false;

            Console.WriteLine($"{tt}{fa}");

            // object 형식
            object oint = 09;
            object ofloat = 3.14f;
            object ochar = '난';
            object ostring = "너랑";
            object obool = true;

            // 박싱 & 언박싱
            int x = 01;
            object y = (object)x; // 01 을 박싱해 힙에 저장
            int z = (int)y; // 박싱한 01을 언박싱해 스택에 저장

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            // 묵시적 형변환
            float faf = 3.141592f;
            double db = faf;

            int af = 0929;
            long bf = af;

            // 명시적 형변환
            double bdbd = 3.141592f;
            int afaf = (int)bdbd;

            // 날짜 자료형
            Console.WriteLine(DateTime.Now.Hour);
            DateTime dt = new DateTime(2023, 3, 2, 11, 57, 0);
            Console.WriteLine(dt);
        }
    }
}