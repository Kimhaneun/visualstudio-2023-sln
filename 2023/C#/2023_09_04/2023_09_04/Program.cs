using System;
using System.Collections.Generic;

namespace _2023_09_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight _knight = new Knight();
            _knight.Walk(); // Q. 자식이 부모의 모든 것을 받을 수 있나??
                            // A. NO!! 접근 한정자에 따라 다르다.



            // 다형성: 한 클레스가 여러 형태로 변환 가능한 성질
            // - > 자식 클래스가 부모 클래스로 위장이 가능하다. 
            // But 위장 메서드를 사용할 수 없어!
            // -> 형식 변환하여 사용이 가능해!
            // 스크린샷 확인해!!

            List<Hero> _heroes = new List<Hero>()
            {
                new Knight(), new Archer(),
                new Knight(), new Archer(),
                new Knight(), new Archer(),
                new Knight(), new Archer(),
                new Knight(), new Archer(),
            };

            foreach (Hero item in _heroes)
            {
                item.Walk();
                item.Run();

                if (item is Hero)
                {
                    foreach (var item1 in _heroes)
                    {
                        // ((Knight)item1).Attack(enemy);
                        // ((Archer)item1).Fire(enemy);
                    }
                }
            }
        }
    }
}
