using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_5_23_1205_김한은
{
    class MyMath
    {
        internal static bool IsPrime(int input)
        {
            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }
                return true;
        }
    }
}
