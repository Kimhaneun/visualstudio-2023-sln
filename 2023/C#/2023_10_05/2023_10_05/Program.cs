using System;
using System.Collections.Generic; // List를 사용하기 위해 선언
using System.IO;
using System.Net; // File을 사용하기 위해 선언

namespace _2023_10_05
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 인터페이스
            Dog dog = new Dog();
            dog.Eat();
            dog.Yelp();
            #endregion

            #region 인터페이스 정렬
            List<Product> prodcuts = new List<Product>()
            {
                new Product(3000, "복숭아"),
                new Product(7000, "딸기"),
                new Product(1000, "사과"),
                new Product(5000, "포도"),
                new Product(10000, "원단")
            };

            prodcuts.Sort(); // 리스트를 정렬해줌

            foreach (var item in prodcuts)
            {
                Console.WriteLine(item.ToString());
            }
            #endregion

            #region 파일 쓰기
            string[] names_0 = { "레드", "그린", "블루" };
            File.WriteAllLines(@"D:\2023_10_05 IO\a.txt", names_0); // Q. 인스턴스 메서드일까? 아님 Static 메서드일까?
                                                                    // A. 정답은 Static 메서드!
                                                                    // @: 쓴거 그대로 사용할 거야
                                                                    
            File.WriteAllLines(@"D:\2023_10_05 IO\b.txt", names_0); // 없는 파일을 쓰면 만들어 준다.

            string s = "이러면 안 될 거 아는데\n너 앞에만 서면 나락";
            File.WriteAllText(@"D:\2023_10_05 IO\c.txt", s);

            // WriteAllLines 과 WriteAllText의 차이점!
            // WriteAllLines: 이어서 쓰지 않음
            // WriteAllText: 이어서 씀
            #endregion

            #region 파일 읽기
            for (int i = 0; i < 3; i++)
            {
                File.AppendAllLines(@"D:\2023_10_05 IO\a.txt", names_0);
                File.AppendAllText(@"D:\2023_10_05 IO\c.txt", s);
            }
            string[] name = File.ReadAllLines(@"D:\2023_10_05 IO\b.txt");
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            string  str = File.ReadAllText(@"D:\2023_10_05 IO\b.txt");
            Console.WriteLine(str);
            #endregion

            byte[] bytes_0 = new byte[3] { 12, 65, 3 };
            File.WriteAllBytes(@"D:\2023_10_05 IO\bin.txt", bytes_0);

            byte[] bytes_1 = File.ReadAllBytes(@"D:\2023_10_05 IO\bin.txt");
            foreach (var VARIABLE in bytes_1)
            {
                Console.WriteLine((VARIABLE));
            }
        }
    }
}
