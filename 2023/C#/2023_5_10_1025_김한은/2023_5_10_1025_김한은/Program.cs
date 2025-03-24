using System;

namespace _2023_5_10_1025_김한은
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Knight littleKnight = new Knight("Little_kight", 100, 10);
            //    Knight BigKnight = new Knight("Big_kight", 100, 20);

            //    littleKnight.Move(5);
            //    BigKnight.Move(6);

            //    littleKnight.AttackEnemy(BigKnight);
            //    BigKnight.AttackEnemy(littleKnight);





            Knight 김기사 = new Knight(100, 10, "김게임");
            Knight 박기사 = new Knight(100, 20, "박게임");

            김기사.ShowID();
            박기사.ShowID();

            김기사.name = "김게임";
            박기사.name = "박게임";







            //Knight littleknight = new Knight();
            //Console.WriteLine("기사의 이름은...");
            //littleknight.name = Console.ReadLine();
            //Console.WriteLine("기사의 HP는...");
            //littleknight.HP = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("기사의 공격력은...");
            //littleknight.Attack = Convert.ToInt32(Console.ReadLine());

            //Knight Hornet = new Knight();
            //Hornet.name = "Hornet";
            //Hornet.HP = 30;
            //Hornet.Attack = 2;

            //Console.WriteLine("...눈 앞의 누군가 지나갔다.\n누군가는 잠시 당신을 지켜보더니, 공격하기 시작한다.");

            //Hornet.AttackEnemy(littleknight);






      
            // 정적 메서드 연결
            Knight.UPCount();
            Math.Abs(-45.5);    // 굳이 메서드를 만들지 않도 이렇게도...
        }
    }
}
