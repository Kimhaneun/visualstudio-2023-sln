using System;

namespace _2023_3_14_1205_김한은
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.
            string name = "권정열";
            int age = 40;
            string group = "10cm";

            Console.WriteLine("좋아하는 가수는 " + name + "이고 나이는 " + age + "그룹명은 " + group + "입니다.");

            // 2.
            Console.WriteLine("좋아하는 가수는 {0} 나이는 {1} 그룹명은 {2} 입니다.", name, age, group);

            // 3.
            string input = Console.ReadLine();
            Console.Write("콘솔 입력 후 input 값은 : ");
            Console.WriteLine(input);



            // 1. Parse : 문자열 -> 다른 자료형
            Console.WriteLine("실수 두 개를 입력하시오 : ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + b);

            float f1 = 0.0f;
            float f2 = 0.0f;
            try
            {
                f1 = float.Parse(Console.ReadLine());
                f2 = float.Parse(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("잘못된 값을 입력했습니다.");
            }

            // 2. Convert : 기본 자료형 <-> 기본 자료형
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a + b);


            string[] str = Console.ReadLine().Split();

            for(int i = 0; i< str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
        }
    }
}
