using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_3_29_1205_김한은
{
    class Program
    {
        static void Main(string[] args)
        {
            // 증가 연산자
            int a = 5;
            Console.WriteLine(a++); // 실행 결과 : 5
                                    // 이유 : 문장 실행 이후 더하기
                                    // 문장 실행 이후 a 의 값은 6

            Console.WriteLine(++a); // 실행 결과 : 7
                                    // 이유 : 더하기 이후 문자 실행



            // 감소 연산자
            int b = 10;
            Console.WriteLine(b--); // 실행 결과 : 10
                                    // 이유 : 문장 실행 이후 빼기
                                    // 문장 실행 이후 b 의 값은 9

            Console.WriteLine(a--); // 실행 결과 : 9
                                    // 이유 : 빼기 이후 문자 실행

            //동일한 작업을 하는 문장 : b = b - 1;



            // 관계 연산자 ( 숫자 추리 게임 )
            Random rand = new Random();
            int num = rand.Next(1, 101);

            Console.WriteLine("1 ~ 100 까지의 정수를 추리하십쇼.");

            int input = 0;

            while (input != num)
            {
                input = int.Parse(Console.ReadLine());

                if (input > num)
                {
                    Console.WriteLine("더 작은 수 입니다.");
                }

                else if (input < num)
                {
                    Console.WriteLine("더 큰 수 입니다.");
                }

                else
                {
                    Console.WriteLine("정답 입니다.");
                }

            }



            // 논리 연산자
            bool A = true;
            bool B = false;

            // AND 연산자
            Console.WriteLine(A && B);

            // OR 연산자
            Console.WriteLine(A || B);

            //NOT 연산자
            Console.WriteLine(!A);
            Console.WriteLine(!B);
            // (피연산자가 하나)

            // 입력된 정수가 2의 배수이면서 3의 배수인지 여부를 판단하는 프로그램
            int iInput = int.Parse(Console.ReadLine());

            if (iInput % 2 == 0 && iInput % 3 == 0)
            {
                Console.WriteLine("입력된 값은 2의 배수이면서 동시에 3의 배수입니다");
            }

            // 윤년인지 판단하는 프로그램
            // (윤년 : 연도가 4의 배수이면서 100의 배수가 아닐때 or 연도가 400의 배수일 때)
            //int U = int.Parse(Console.ReadLine());
            //if(((U % 4 == 0)&& (U % 100 != 0)) || (U % 400 == 0))
            //{
            //    Console.WriteLine("입력된 연도는 윤년이 맞습니다.");
            //}
            //else
            //{
            //    Console.WriteLine("입력된 연도는 윤년이 아닙니다.");
            //}

            // 삼항 연산자
            Console.WriteLine(DateTime.Now.Hour < 12 ? "오전" : "오후");

            Console.WriteLine(iInput % 2 ==0 ? "짝수" : "홀수");
        }
    }
}
