using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Delegate: 대리자
// 사용자가 대리자를 호출하면 그 대리자는 해당 메서드를 호출한다.
// 그래서 왜 씀?: 배열 arr 선언 후 대리자로 My정렬 메서드를 'My정렬(arr, 오름/내림);' 로 호출해 배열을 정렬한 값은 반환할 수 있다.
// 대리자 하나가 여러 메서드를 호출할 수 있다.

// 여러가지 정렬 방법 중 버블 정렬! 에 대해 알아야 한다.

namespace Delegate_10205
{
    class Program
    {
        #region DELEGATE BASIC EXAMPLE
        delegate int MyDelegate(int a, int b); // 대리자 MyDelegate 선언 (대리자를 찍어낼 수 있는 형식 선언)

        static int Plus(int a, int b)
        {
            return a + b;
        }

        static int Minus(int a, int b)
        {
            return a - b;
        }
        #endregion

        #region BUBBLE SORT USING DELEGATE
        delegate int Compare(int a, int b);

        static int AscendCompare(int a, int b)// 오름차순을 비교하는 AscendCompare 메서드
        {
            if (a > b)
                return 1;

            else if (a == b)
                return 0;

            else
                return -1;
        }

        static void My정렬(int[] array, Compare 최비서)
        {
            // 여러가지 정렬 방법 중 버블 정렬 방법으로 정렬해 보자!

            // 두 개의 인접한 원소를 비교하기 위해 사용되는 이중 for문
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (최비서(array[j], array[j + 1]) > 0)
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        #endregion

        #region BUBBLE SORT VALUES OF GENERIC DELEGATE TYPE
        delegate int Compare<T>(T a, T b); // 제네릭 대리자 형식

        static int AscendCompare<T>(T a, T b) where T : IComparable<T> // IComparable: CompareTo를 반드시 사용할 수 있도록 하는 인터페이스
        {
            // 오름차순 정렬
            return a.CompareTo(b);
        }

        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {
            // 내림차순 정렬
            return -a.CompareTo(b);
        }

        static void My정렬<T>(T[] array, Compare<T> 비서)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (비서(array[j], array[j + 1]) > 0)
                    {
                        T temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        #endregion

        #region DELEGATE DUPLICATE CALLS
        delegate void 사고신고(string msg); // 비서 형식

        static void Call_119(string location)
        {
            Console.WriteLine($"사고 발생 {location}으로 이동 바람");
        }

        static void A(string location)
        {
            Console.WriteLine($"사고 발생 위치인 {location}에서 대피하기 바람");
        }

        static void B(string location)
        {
            Console.WriteLine($"{location} 사건 종료");
        }
        #endregion

        #region DELEGATE EXAMPLE
        delegate void SayDelegate();

        static void Hi()
        {
            Console.WriteLine("안녕!");
        }
        #endregion

        static void Main(string[] args)
        {
            #region DELEGATE BASIC EXAMPLE
            MyDelegate 김비서 = new MyDelegate(Plus); // Plus 메서드를 호출하는 김비서 생성
            Console.WriteLine(김비서(3, 5));

            김비서 = Minus; // 김비서가 호출하는 메서드를 Minus로 변경
            Console.WriteLine(김비서(3, 5));
            #endregion

            #region BUBBLE SORT USING DELEGATE
            int[] arr = { 5, 2, 5, 6, 7, 24 };
            My정렬(arr, new Compare(AscendCompare));
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region BUBBLE SORT VALUES OF GENERIC DELEGATE TYPE
            // 오름차순 정렬
            string[] array = { "Gryffindor", "Hufflepuff", "Ravenclaw", "Slytherin" };
            My정렬<string>(array, new Compare<string>(AscendCompare));

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            // 내림차순 정렬
            My정렬<string>(array, DescendCompare);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region DELEGATE DUPLICATE CALLS
            사고신고 팀1 = new 사고신고(Call_119);
            팀1 += A;
            팀1 += B;

            팀1("호수 공원");
            #endregion

            #region DELEGATE EXAMPLE
            SayDelegate sayDelegate = Hi;
            sayDelegate();
            #endregion
        }
    }
}
