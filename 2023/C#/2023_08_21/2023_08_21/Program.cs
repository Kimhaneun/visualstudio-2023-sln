using System;

namespace _2023_08_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int[] istr = Array.ConvertAll(Console.ReadLine().Split(), int parse);
            // Console.WriteLine(Min(istr[0], istr[1], istr[2]));
        }

        static int Min(int a, int b, int c)
        {
            return (a < b ? a : b) > c ? c : (a < b ? a : b);
        } 
    }
}
