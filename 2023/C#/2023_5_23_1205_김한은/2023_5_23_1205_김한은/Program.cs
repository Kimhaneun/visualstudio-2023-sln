using System;


namespace _2023_5_23_1205_김한은
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 2; i <= 100; i++)
            {
                if (MyMath.IsPrime(i))
                {
                    count++;
                }
            }
                Console.WriteLine(count);
        }
    }
}
