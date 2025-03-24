using System;

namespace _2023_09_18
{
    class Knight : Hero
    {
        #region 오버라이딩 실습_0
        public string knightName { get; set; }

        public override void Fire(Hero enemy)
        {
            Console.WriteLine($"{knightName} 용이 내가 된다!");
            enemy.hp -= 15;
        }
        public override void Attack(Hero enemy)
        {
            Console.WriteLine($"{knightName} 수리검 쇽쇽쇽");
            enemy.hp -= 10;
        }
        #endregion
    }
}
