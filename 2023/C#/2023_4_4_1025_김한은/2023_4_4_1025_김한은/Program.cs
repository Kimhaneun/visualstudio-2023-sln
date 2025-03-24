using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_4_4_1025_김한은
{
    class Program
    {
        static void Main(string[] args)
        {
            //삼항 연산자
            int input_1 = int.Parse(Console.ReadLine());
       
            Console.WriteLine(input_1 % 2 == 0 ? "짝수" : "홀수");



            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
            Console.WriteLine(a < c ? (a < b ? a : (b < c ? b : c)) : (b > c ? c : b));

        }
    }
}
