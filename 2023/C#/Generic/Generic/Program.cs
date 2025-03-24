using System;
using System.Collections.Generic;

namespace Generic
{
    // Generic: 형식을 일반화 
    class Program
    {
        //static void CopyArray(int[] source, int[] target) // 정수 배열만 받아 올 수 있음
        //{
        //    for (int i = 0; i < source.Length; i++)
        //    {
        //        target[i] = source[i];
        //    }
        //}

        //static void CopArray(float[] sourcem, float[] target) // 실수 배열만 받아 올 수 있음
        //{
        //    for (int i = 0; i < sourcem.Length; i++)
        //    {
        //        target[i] = sourcem[i];
        //    }
        //}

        //static void CopyArray<T>(T[] source, T[] target) // T: 형식 매개변수
        //{
        //    for (int i = 0; i < source.Length; i++)
        //    {
        //        target[i] = source[i];
        //    }
        //}

        #region Generic 예제 1
        static void Rary<T>(T[] source1, T[] target1)
        {
            for (int i = 0; i < source1.Length; i++)
            {
                target1[i] = source1[source1.Length - 1 - i];
            }
        }
        #endregion


        static void Main(string[] args)
        {
            List<int> iList = new List<int>();

            //// 이렇게 썼던 내용을 
            //int[] s = { 1, 2, 3, 4, 5 };
            //int[] t = new int[5];
            //CopyArray(s, t);

            //// 이거 하나로
            //CopyArray<int>(s, t);

            //// 예 2
            //float[] s1 = { 1.0f, 2.0f, 3.0f, 4.0f };
            //float[] t1 = new float[4];
            //CopyArray<float>(s1, t1);

            //// 사용하기
            //Garr<string> sarr = new Garr<string>();
            //sarr.GetElement(0);

            #region Generic 예제 1
            int[] source1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] target1 = new int[9];
            Rary<int>(source1, target1);

            //float[] source2 = new float[2];
            //float[] target2 = new float[2];
            //Rary<float>(source2, target2);

            foreach (var item in target1)
            {
                Console.WriteLine(item);
            }
            #endregion

            Stack<int> myStack = new Stack<int>();
            myStack.Push(9);
            myStack.Push(2);
            myStack.Push(5);

            Console.WriteLine(myStack.Pop()); // 가장 마지막에 Push 한 값을 꺼내오는거!
            Console.WriteLine(myStack.Pop()); // 그 다음 스택에 쌓인 값을 꺼내오는거!

            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);

            Console.WriteLine(myQueue.Dequeue()); // 가장 처음에 들어온 값을 꺼내오는(?)거!
        }
    }
}