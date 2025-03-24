using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_03
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = float.Parse(Console.ReadLine());
            float c = 5 * (f - 32) / 9;

            Console.WriteLine(c);

            if(c > 30)
                Console.WriteLine("더워요.");

            else if(c < 10)
                Console.WriteLine("추워요.");
        }
    }
}
