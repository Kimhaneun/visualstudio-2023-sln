using System;

namespace _2023_09_04
{
    class Knight : Hero // Hero를 상속 받을꺼야!
    {
        public string SwordName { get; set; }

        internal void Fire(Archer enemy)
        {
            enemy.hp -= 15;
            Console.WriteLine("용이 내가 된다!");
            this.exp += 5;
        }

        internal void Attack(Archer enemy)
        {
            enemy.hp -= 5;
            Console.WriteLine("이것도 받아보시지");
            this.exp += 5;
        }
    }
}
