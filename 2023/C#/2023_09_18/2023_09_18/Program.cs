using System;
using System.Collections.Generic;

namespace _2023_09_18
{
    class Program
    {
        #region 복습
        //class Parent
        //{
        //    public int num = 1234;
        //    public int var = 09;

        //    public virtual void Method()
        //    {
        //        Console.WriteLine("부모 메서드");
        //    }
        //}

        //sealed class Child : Parent // sealed를 추가하면 
        //{
        //    public new string var = "abc";

        //    public override void Method()
        //    {
        //        base.Method(); // 부모를 호출하려면 bass
        //                       // 단, 부모만 호출은 불가능
        //        Console.WriteLine("자식 메서드");
        //    }
        //}

        //class GrandChild : Child // 그 밑의 친구는 재정의를 하지 못함
        // -> 어디까지 상속할 수 있을지 정할 수 있음
        //{
        //    public override void Method()
        //    {

        //    }
        //}
        #endregion

        #region 추상 클래스 
        // 추상 클래스는 객체를 만들진 못한다.
        // 쓰는 이유: 오버라이딩 하도록 강제할 수 있기 때문에
        abstract class Parent // abstract: 반드시 오버라이딩 해달라는 것이다.
        {
            abstract public void Test();

            public void Normal()
            {
                Console.WriteLine("일반적인 메서드");
            }
        }

        class Child : Parent
        {
            public override void Test()
            {
                Console.WriteLine("자식 클래스에서 구현함");
            }
        }
        #endregion

        static void Main(string[] args)
        {
            #region 복습
            int num = 5678;
            Console.WriteLine(num); // 5678 출력: 셰도잉

            //Child child = new Child();
            //Console.WriteLine(child.var); // abc 출력: 하이딩
            //Console.WriteLine(((Parent)child).var);

            //Console.WriteLine(); // 자식 메서드 출력
            //child.Method();
            //((Parent)child).Method(); // 자식 메서드 출력: 오버라이딩은 셰도잉/하이딩과 다르게
            //                          // 형을 변환해도 부모를 호출하지 못함
            //                          // 오버라이딩을 쓰는 이유: 부모로 관리하되 원하는 메서드를 호출하기 위해
            #endregion

            #region 오버라이딩 실습_0
            Knight 겐지 = new Knight();
            겐지.Attack(new Knight());
            ((Hero)겐지).Fire(new Archer());

            Archer 한조 = new Archer();
            한조.Attack(new Archer());
            ((Hero)한조).Fire(new Knight());
            #endregion

            #region 오버라이딩 실습_1
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.Eat();
            dog.Eat();

            List<Animal> animals = new List<Animal>()
            {
                new Cat(), dog, new Dog(), cat, new Cat()
            };

            foreach (Animal item in animals)
            {
                item.Eat();
            }
            #endregion

            #region 추상 클래스
            // Parent parent = new Parent(); // 왜 구현 안됨?? 추상이니까...
            Child child = new Child();
            child.Test();
            child.Normal();
            #endregion
        }
    }
}
