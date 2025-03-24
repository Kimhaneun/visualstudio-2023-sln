using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class IArr
    {
        int[] array; // 정수 배열

        public int GetElement(int index)
        {
            return array[index];
        }
    }

    class DArr
    {
        double[] array;
        public double GetElement(int index)
        {
            return array[index];
        }
    }

    class Garr<T>
    {
        // 해당 타입의 공간을 마련하는거야
        T[] array;

        public T GetElement(int index)
        {
            return array[index];
        }
    }
}
