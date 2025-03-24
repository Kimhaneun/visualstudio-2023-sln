using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_04
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("삼각형의 넓이를 출력한 결과는 " + (a * b / 2) + "입니다.");
        }
    }
}
