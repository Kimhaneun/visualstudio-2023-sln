using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    class ThreadTest2
    {
        public void Start()
        {
            Thread thread1 = new Thread(new ThreadStart(Thread1));
            Thread thread2 = new Thread(new ThreadStart(Thread2));

            thread1.IsBackground = true;
            thread2.IsBackground = true;

            thread1.Start();
            thread2.Start();

            Console.WriteLine("This is main Thread");
        }

        public void Thread1()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine($"Thread1 : {i}");
            }
        }

        public void Thread2()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine($"Thread2 : {i}");
            }
        }
    }
}
