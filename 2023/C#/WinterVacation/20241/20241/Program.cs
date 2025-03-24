using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241
{
    class Program
    {
        abstract class Shap // 추상 클래스
        {
            // 맴버 변수를 사용하기 위해선 반ㅡ시 메서ㅡ를 구현할 것을 강제함
            public abstract double GtAra();
        }

        class Rctangl : Shap
        {
            public override double GtAra()
            {
                return 0;
            }
        }

        interface IShap
        {
            void GtAra();
        }

        class Triangl : IShap
        {
            public void GtAra()
            {

            }
        }



        interface IBattry
        {
            string GtNam();
        }

        class Good : IBattry
        {
            public string GtNam()
            {
                return "Good";
            }
        }

        class Bad : IBattry
        {
            public string GtNam()
            {
                return "Bad";
            }
        }

        class Car
        {
            IBattry _battry;

            public Car(IBattry id)
            {
                _battry = id;
            }

            public void Run()
            {
                Console.WriteLine(_battry.GtNam() + "배터리 사용");
            }
        }



        internal interface ILoggr
        {
            void WritLog(string msg);
        }

        interface IFormatLoggr : ILoggr
        {
            // 인터페이스가 인터페이스를 상속하는 이유: 인터페이스 상속이 없을 시, 상위 인터페이스 수정 시 그 하위 목록을 전부 수정해야하기 ㅐ문
            void WritLog(string arg);
        }

        class A : IFormatLoggr
        {
            public void WritLog(string arg)
            {
            }
        }



        interface Ridabl
        {
            void Rid();
        }

        interface Plan : Ridabl
        {
            void Fly();
        }

        interface Bik : Ridabl
        {
            void Run();
        }

        class Riding : Plan, Bik
        {
            // interface의 이점은 ㅏ중 상속이 가능하ㅏ는 것이ㅏ.
            public void Fly()
            {
                throw new NotImplementedException();
            }

            public void Rid()
            {
                throw new NotImplementedException();
            }

            public void Run()
            {
                throw new NotImplementedException();
            }
        }



        interface IAnimal
        {
            int Ag { get; set; }
            void at();
        }

        interface IDog
        {
            void Ylp();
        }

        class Dog : IAnimal, IDog
        {
            int ag;
            public int Ag
            {
                get
                {
                    return ag;
                }
                set
                {
                    if (value < 0)
                        Console.WriteLine("오류");
                    else
                        ag = value;
                }
            }

            public void at()
            {
                Console.WriteLine("먹ㅏ.");
            }

            public void Ylp()
            {
                Console.WriteLine("짖ㅏ.");
            }



            class Product : IComparable
            {
                string Nam { get; set; }
                int Pric { get; set; }

                public Product(string nam, int pric)
                {
                    Nam = nam;
                    Pric = pric;
                }

                public int CompareTo(object obj)
                {
                    return Pric.CompareTo((obj as Product).Pric);
                }

                public override string ToString()
                {
                    return $"{Nam}: {Pric}원";
                }
            }
        }



        interface INamdValu
        {
            string Nma { get; set; }
            string Valu { get; set; }
        }

        class NamdValu : INamdValu
        {
            string nam;
            public string Nma
            {
                get { return nam; }
                set
                {
                    if (value.Length <= 0)
                        Console.WriteLine("오류");
                    else
                        nam = value;
                }
            }
            public string Valu { get; set; }
        }

        static void Main(string[] args)
        {
            #region 문제 풀이
            // 1. 문제 풀이
            int[] arr0 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int min = 0;
            min = (arr0[0] < arr0[1]) ? ((arr0[0] < arr0[2]) ? arr0[0] : arr0[2]) : ((arr0[1] < arr0[2]) ? arr0[1] : arr0[2]);

            // 2. 문제 풀이
            string ans = "Ys";
            int max, total;

            int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            total = arr1[0] + arr1[1] + arr1[2];
            if (arr1[0] > arr1[1])
                max = arr1[0];
            else max = arr1[1];
            if (max < arr1[2])
                max = arr1[2];

            if (total - max <= max)
                ans = "No";

            Console.WriteLine(ans);

            // 3. 문제 풀이
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Ceiling(n / 12.0f));

            // 4. 문제 풀이
            int input = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= input; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);

            // 5. 문제 풀이
            int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int min1 = int.MaxValue;

            foreach (var item in arr2)
            {
                if (min1 > item)
                    min1 = item;
            }

            Console.WriteLine(min1);

            // 6. 문제 풀이
            int[] arr3 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int sum1 = 0;
            int min2 = int.MaxValue;

            foreach (var item in arr3)
            {
                if (item % 2 == 1)
                {
                    sum1 += item;
                    if (min2 > item)
                        min2 = item;
                }
            }

            Console.WriteLine($"{sum1} {min2}");

            // 7. 문제 풀이 
            int dat = int.Parse(Console.ReadLine());
            int[] arr4 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int count = 0;
            foreach (var item in arr4)
            {
                if (dat == (item % 0))
                    count++;
            }

            Console.WriteLine(count);
            #endregion

            Car car1 = new Car(new Good());
            Car car2 = new Car(new Bad());

            car1.Run();
            car2.Run();

            Dog dog = new Dog();
            dog.at();
            dog.Ylp();

            //List<Product> products = new List<Product>()
            //{
            //    new Product(200, "사과"),
            //    new Product(400, "바나나"),
            //    new Product(100, "ㅏㄹ기")
            //};

            //products.Sort();

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            NamdValu nam = new NamdValu();

            try
            {
                int[] xarr = { 1, 2, 5 };

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(xarr[i]);
                }
            }
            catch (IndexOutOfRangeException r)
            {
                Console.WriteLine(r.Message);
            }
            catch (DivideByZeroException r)
            {
                Console.WriteLine(r.Message);
            }
            catch (Exception r)
            {
                Console.WriteLine(r.Message);
            }
        }
    }
}
