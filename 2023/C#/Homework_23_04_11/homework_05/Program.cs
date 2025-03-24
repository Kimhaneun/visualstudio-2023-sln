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
            double input = double.Parse(Console.ReadLine());
             // 12.4
            if (input == Convert.ToDouble(input))
                // 12.4 == 12
            {
                Console.WriteLine("정수입니다.");
            }

            else
                Console.WriteLine("실수입니다.");
        }
    }
}
