using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a % 3 == 0)
                Console.WriteLine("3의 배수입니다.");

            if (a % 2 == 0)
                Console.WriteLine("2의 배수입니다.");

            else
                Console.WriteLine("2의 배수도, 3의 배수도 아닙니다.");
        }
    }
}