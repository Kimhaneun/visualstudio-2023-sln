using System;

namespace _2023_09_18
{
    class Archer : Hero
    {
        #region 오버라이딩 실습_0
        public string archerName { get; set; }
        public int arrow { get; set; }

        public override void Fire(Hero enemy)
        {
            Console.WriteLine($"{archerName}용이여 적들을 삼켜라!");
            arrow -= 5;
            enemy.hp -= 15;
        }

        public override void Attack(Hero enemy)
        {
            Console.WriteLine($"{arrow} 화살 쇽쇽쇽");
            enemy.hp -= 10;
        }
        #endregion
    }
}
