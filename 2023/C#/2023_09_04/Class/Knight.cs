using System;

namespace Class
{
    class Knight : Hero
    {
        public string SwordName{get;set; }

        internal void Walk()
        {
            Console.WriteLine("걸어서 이동 중입니다.");
            this.hp -= 5;
        }

        internal void Run()
        {
            Console.WriteLine("뛰어가는 중입니다.");
            this.hp -= 10;
        }

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
