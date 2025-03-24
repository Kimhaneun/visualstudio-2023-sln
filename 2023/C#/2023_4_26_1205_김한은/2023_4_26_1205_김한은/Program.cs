using System;
using System.Collections.Generic;

namespace _2023_4_26_1205_김한은
{
    class Program
    {
        static void Main(string[] args)
        {
            // 별 찍기

            // 가.

            //int input_0 = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < input_0; i++)
            //{
            //    for (int j = 0; j < input_0; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}

            //// 나.

            //int input_1 = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < input_1; i++)

            //{
            //    for (int j = 0; j < i + 1; j++)

            //    {
            //        Console.Write("*");
            //    }

            //    Console.Write("\n");
            //}

            // 다.

            int input_2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= input_2; i++)
            {
                for (int j = 1; j <= input_2 - i; j++)
                    Console.Write(" ");

                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();

            // 라.

            //int input_3 = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < input_3; i++)

            //{

            //}

            // 공       i(별)         입력값
            // 4          1             5

            // 마.

            //int input_4 = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < input_4; i++)
            //{
            //    for (int j = 1; j <= input_4 - i; j++)
            //        Console.Write(" ");
            //    for (int j = 1; j <= 2 * i - 1; j++)
            //        Console.Write("*");
            //    Console.WriteLine();

            //}

            // 배열

            //string[] year = new string[] { "말 많은", "푸른", "어두운", "조용한", "웅크린", "백색", "지혜로운", "용감한", "날카로운", "욕심많은" };
            //string[] month = new string[] { "늑대", "태양", "양", "매", "황소", "불꽃", "나무", "달빛", "말", "돼지", "하늘", "바람" };
            //string[] day = new string[] { " 와 함께 춤을", " 의 기상", " 은 그림자 속에", " ", " 의 환생", " 의 죽음", " 아래에서", " 을 보라",
            //                              "이 노래하다", " 의 그림자", " 의 일격", " 에게 쫒기는 남자", " 의 행진", " 의 왕", " 의 유령", " 을 죽인 자",
            //                              " 는 맨날 잠잔다", " 처럼", " 의 고향", " 의 전사", "은 나의 친구", " 의 노래", " 의 정령", " 의 파수꾼",
            //                              " 의 악마", " 와 같은 사나이", " 를 쓰러트린자", " 의 혼", " 은 말이 없다" };


            //string[] birthday = Console.ReadLine().Split('-');

            //int[] birthday_ = new int[]
            //{
            //    int.Parse(birthday[0]),
            //     int.Parse(birthday[1]),
            //      int.Parse(birthday[2]),
            //};

            //string result = "";
            //result += year[int.Parse(birthday[0].ToString()[birthday[0].Length - 1].ToString())];
            //result += month[birthday_[1] - 1];
            //result += day[birthday_[2] - 3];

            //Console.Write(result);

            //foreach

            //List<string> lst = new List<string>();

            //lst.Add("백인성");
            //lst.Add("빅원");
            //lst.Add("이상규");       또는

            //List<string> lst = new List<string>() { "백인성", "빅원", "이상규" };

            //for (int i = 0; i < lst.Count; i++)
            //{
            //    Console.WriteLine(lst[i]);
            //}

            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item);
            //}

            //break

            //while (true)
            //{
            //    int input = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(input);

            //    if (input == 0)
            //    {
            //        break;
            //    }
            //}

            //Console.WriteLine("break");

            // continue

            //int input = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < input; i++)
            //{
            //    if (input % 2 != 0)
            //    {
            //        continue;
            //        Console.WriteLine(i);
            //    }
            //}

        }
    }
}
