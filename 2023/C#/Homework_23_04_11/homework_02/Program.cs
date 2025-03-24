using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            
            if ( a.Length > 10)
                Console.WriteLine("10글자 이상 입니다.");

            else if(a.Length < 10)
                Console.WriteLine("어서오세요 " + a + "님");
        }
    }
}
