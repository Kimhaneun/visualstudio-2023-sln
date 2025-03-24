using System;


namespace _2023_4_18_1205_김한은
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("몇 월인지 입력하시오.");

            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("계절 : 겨울");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("계절 : 봄");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("계절 : 여름");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("계절 : 가을");
                    break;

                default:
                    Console.WriteLine("다시 시도하십쇼.");
                    break;

            }

        }
    }
}
