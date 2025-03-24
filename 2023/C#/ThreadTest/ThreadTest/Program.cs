using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadTest1 test1 = new ThreadTest1();
            test1.Start();
            Console.ReadKey();

            ThreadTest2 test2 = new ThreadTest2();
            test2.Start();
            Console.ReadKey();
        }
    }
}
