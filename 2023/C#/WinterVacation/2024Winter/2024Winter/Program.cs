using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024Winter
{
    // Class: 사용자 정의 자료형
    class Studnt
    {
        // Class 안에 인ㅆ는거슬은 맴버
        int id;
        string nam;

        public void Study()
        {
            Console.WriteLine("공부를 한ㅏ.");
        }
    }

    class Car
    {
        public string carNum = ""; // 변수
        public int oil { get; set; } // 속성 (프로퍼티)

        public void Rid()
        {
            Console.WriteLine("ㅏㄹ린ㅏ.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car0 = new Car();
            car0.carNum = "r40";
            car0.Rid();

            Swordsman swordsman = new Swordsman();
            Archr archr = new Archr();

            swordsman.Walk();
            // archr.Run(); 자식 클래스가 아니기 ㅐ문에 접근 불가

            // ㅏ향성: 자식 클래스가 부모 클래스로 위장 가능한 것 (하나의 클래스가 여러 형태로 변환이 가능한 것)
            List<Hero> hros = new List<Hero>()
            {
                swordsman, archr, new Swordsman(), new Archr()
            };

            foreach (var item in hros)
            {
                item.Walk();
                Console.WriteLine(item.nam);

                // 자료형 검사 
                if (item is Swordsman) // is: 자료형 검사
                    ((Swordsman)item).swordAttack();
                if (item is Archr)
                    ((Archr)item).Go();

                // 자료형 변환
                Swordsman 검사 = item as Swordsman; // as: 변환을 할 수 있으면 변환, 아니면 null 반환 
                검사.swordAttack();
                Archr 궁수 = item as Archr;
                궁수.Go();


                
                // int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }
        }
    }
}

