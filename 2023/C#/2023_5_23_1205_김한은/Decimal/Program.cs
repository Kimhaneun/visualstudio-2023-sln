using System;


namespace Decimal
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
                return true;
            }
        }
    }
}
