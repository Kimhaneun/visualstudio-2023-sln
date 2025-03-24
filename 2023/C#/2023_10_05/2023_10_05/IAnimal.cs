using System;

namespace _2023_10_05
{
    #region 인퍼테이스 예제 1.
    interface IAnimal
    {
        void Eat();
    }

    interface IDog : IAnimal
    {
        void Yelp();
    }

    class Dog : IDog
    {
        public void Eat()
        {
            Console.WriteLine("먹다");
        }

        public void Yelp()
        {
            Console.WriteLine("짖다");
        }
    }
    #endregion
}
