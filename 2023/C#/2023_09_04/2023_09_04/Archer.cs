using System;

namespace _2023_09_04
{
    class Archer : Hero // Hero를 상속 받을꺼야!
    {
        public int arrow { get; set; }

        internal void Fire(Knight enemy)
        {
            enemy.hp -= 15;
            this.arrow -= 1;
            Console.WriteLine("용이여 적들을 삼켜라!");
            this.exp += 5;
        }

        internal void Attack(Knight enemy)
        {
            enemy.hp -= 5;
            this.arrow -= 4;
            Console.WriteLine("숨을 곳은 없다");
            this.exp += 5;
        }
    }
}
