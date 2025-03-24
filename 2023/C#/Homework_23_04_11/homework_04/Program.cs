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
            // string[] input = Console.ReadLine().Split();
            // 1등 = input[0] = "1" , input[1] = "등"

            int input = int.Parse(Console.ReadLine());

            if(input == 1)
                Console.WriteLine("아주 잘 했어요.");
            
            else if(input >= 2 && input <= 3)
                Console.WriteLine("잘 했네요.");

            else if(input >= 4 && input <= 9)
                Console.WriteLine("보통입니다.");

            else if(input >= 10 && input <= 21)
                Console.WriteLine("노력이 필요합니다.");

            else
                Console.WriteLine("잘못된 등수입니다.");
        }
    }
}
