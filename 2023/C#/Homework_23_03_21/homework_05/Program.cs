using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_05
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("원의 넓이를 출력한 결과는 " + (a * a * 3.14) + "입니다.");
        }
    }
}
