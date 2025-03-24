using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_09_14
{
    class Program
    {
        class Parent
        {
            public int a = 123;
            public virtual void Print()
            {
                Console.WriteLine("나는 부모");
            }
        }

        class Child : Parent
        {
            public override void Print() // 또는 new 키워드랑은 좀 달라!
            {
                Console.WriteLine("나는 응애");
            }

            public new string a = "문자열";
        }

        public static int number = 10;

        static void Main(string[] args)
        {
            #region 1교시
            Cat 고양이 = new Cat();
            Dog 강아지 = new Dog();

            Archer 궁수 = new Archer();

            Animal animal = new Animal();
            animal.Print();

            Hero hero = new Hero();
            hero.CounterPrint();
            #endregion

            #region 2교시
            int number = 20;
            Console.WriteLine(number); // 여기서 출력되는 값은? 20!
                                       // 이름이 겹치면 가까운 친구의 값을 할당!
                                       // -> 섀도잉

            Child 자식 = new Child();
            Console.WriteLine(자식.a); // 여기서 출력되는 값은? 문자열!
                                     // -> 하이딩

            // 하지만 나는 다른거 출력하고 싶어!
            Console.WriteLine(((Parent)자식).a); // 형 변환하여 부모 출력 OK

            자식.Print();            // 매서드도 마찬가지
            ((Parent)자식).Print();



            Archer archer = new Archer();
            Knight knight = new Knight();

            archer.Fire();
            knight.Fire();

            ((Hero)hero).Fire();
            ((Hero)knight).Fire();
            #endregion
        }
    }
}
