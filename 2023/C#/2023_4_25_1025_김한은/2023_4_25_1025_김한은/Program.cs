using System;

namespace _2023_4_25_1025_김한은
{
    class Program
    {
        static void Main(string[] args)
        {
            // while 문

            //int input_0 = Convert.ToInt32(Console.ReadLine());

            //if (1 <= input_0 && input_0 <= 100)
            //{
            //    while (input_0 != 0)
            //    {
            //        Console.WriteLine(input_0--);
            //    }
            //}


            //  do ~ while 문

            //    string input_1;

            //    do
            //    {
            //        input_1 = Console.ReadLine();
            //        Console.WriteLine(input_1);

            //    } while (input_1 != "exit");


            // for 문
            // *for ( 초기화식; 조건식; 증감식 ) 에 초기화식, 조건식, 증감식 모두 초기화 할 수 있다.
            // (물론 무한 반복 처리 된다는 것이 문제지만) 

            //for (char i = '가'; i <= '힣'; i++)
            //{
            //    Console.WriteLine(i);
            //}


            // 중첩 for 문

            //for (int i = 2; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        Console.Write($"{i} * {j} = {i * j}\t");

            //    }
            //    Console.WriteLine(" ");
            //}


            // 별 찍기 (스벌... 눈물난다) 
            // 미완성. 수정요함.

            int input_2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= input_2; i++)
            {
                Console.WriteLine("*");

                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine("");
                }
            }

        }
    }
}
