using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_4_11_1205_김한은
{
    class Program
    {
        static void Main(string[] args)
        {
            // 할당 연산자
            int num = 20;

            num += 2;
            Console.WriteLine(num);

            num <<= 3;
            Console.WriteLine(num);
            // .
            // .
            // .

            // 할당 연산자 문제
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(x += 2);
            
            Console.WriteLine(x -= 8);
            
            Console.WriteLine(x *= 3);
           
            Console.WriteLine(x /= 2);
            
            Console.WriteLine(x <<= 3);
            
            Console.WriteLine(x >>= 2);
      
            Console.WriteLine(x |= 10);



        }
    }
}
