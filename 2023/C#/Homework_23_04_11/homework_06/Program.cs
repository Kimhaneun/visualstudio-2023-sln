using System;

namespace homework_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length == 3)
            {
                for(int sum = input.Length - 1; sum >= 0; sum--)
                    Console.WriteLine(input[sum]);
            }

            else if(input.Length == 2)
            {
                string a = Convert.ToString(input[0]);
                string b = Convert.ToString(input[1]);

                int x = int.Parse(b);
                int y = int.Parse(a);
                Console.WriteLine(x + y);
            }

            else
                Console.WriteLine("잘못된 값을 입력하였습니다.");

            //int input = int.Parse(Console.ReadLine());
            //int sum = 0;

            //do
            //{
            //    Console.WriteLine(input % 10);
            //    input = input / 10;
            //} while (input != 0);

            //if(input == 2)
            //{

            //}
        }
    }
}
