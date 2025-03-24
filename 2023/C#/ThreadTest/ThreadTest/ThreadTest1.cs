using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadTest
{
    internal class ThreadTest1
    {
        public void Start()
        {
            Thread thread1 = new Thread(new ThreadStart(Thread1));
            Thread thread2 = new Thread(new ThreadStart(Thread2));

            thread1.Name = "Thread1";
            thread2.Name = "Thread2";

            thread1.Start();
            thread2.Start();
        }

        private void Thread1()
        {
            Console.WriteLine($"Thread: {Thread.CurrentThread.Name}");
        }
        private void Thread2()
        {
            Console.WriteLine($"Thread: {Thread.CurrentThread.Name}");
        }
    }
}
