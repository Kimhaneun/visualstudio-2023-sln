using System;

namespace _2023_09_18
{
    class Hero
    {
        #region 오버라이딩 실습_0
        public int hp { get; set; }

        public virtual void Attack(Hero enemy)
        {
            Console.WriteLine("일반 공격");
        }

        public virtual void Fire(Hero enemy)
        {
            Console.WriteLine("Q 누른다!");
        }
        #endregion
    }
}
