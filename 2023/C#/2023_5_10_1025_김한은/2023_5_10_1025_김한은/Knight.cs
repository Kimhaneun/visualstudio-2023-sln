using System;

namespace _2023_5_10_1025_김한은
{
    class Knight
    {
        //    // 인스턴스 변수
        //public string name;
        //private int hp = Convert.ToInt32(Console.ReadLine());
        //private int attack = Convert.ToInt32(Console.ReadLine());   // 공격했을 때 줄 수 있는 데미지의 양

        //    // 속성

        //    public int HP
        //    {
        //        get
        //        {
        //            return hp;
        //        }
        //        set
        //        {
        //            if (value < 0)
        //            {
        //                hp = 0;
        //            }
        //            else
        //            {
        //                hp = value;
        //            }
        //        }

        //    }

        //    public int Attack
        //    {
        //        get
        //        {
        //            return attack;
        //        }
        //        set
        //        {
        //            if (value < 0)
        //            {
        //                attack = 0;
        //            }
        //            else
        //            {
        //                attack = value;
        //            }
        //        }
        //    }

        //     // 생성자
        //public Knight(string name, int hp, int attack)
        //{
        //    this.name = name;
        //    this.hp = hp;
        //    this.attack = attack;
        //}

        //    public Knight(string name, int attack)
        //    {
        //        this.name = name;
        //        this.attack = attack;
        //        this.hp = 100;

        //    }

        //    public Knight()

        //    {
        //        name = "무명";
        //        attack = 1;
        //        hp = 100;
        //    }


        //    public void Move(int count)
        //    {

        //        for (int i = 0; i < count; i++)
        //        {
        //            Console.WriteLine($"{name}기사가 움직입니다.");
        //            hp--;
        //            Console.WriteLine($"{name}의 hp 가 현재 {hp} 입니다.");
        //        }
        //    }

        //    public void AttackEnemy(Knight knight)
        //    {
        //        Console.WriteLine($"{name}기사가 공격합니다.");
        //        hp -= attack;
        //        Console.WriteLine($"{name}의 hp 가 현재 {hp} 입니다.");
        //    }





        int hp = 0;
        int attack = 0;
        public string name = "";

        int id = 0;
        public static int count = 0;

        public Knight(int hp, int attack, string name)
        {
            this.hp = hp;
            this.attack = attack;
            this.name = name;
            this.id = ++count;
        }

        public void ShowID()
        {
            Console.WriteLine(name + id);
        }





        //[Hollow Knight]
        //public string name;
        //private int hp = Convert.ToInt32(Console.ReadLine());
        //private int attack = Convert.ToInt32(Console.ReadLine());

        //public int HP
        //{
        //    get
        //    {
        //        return hp;
        //    }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            hp = 0;
        //        }
        //        else
        //        {
        //            hp = value;
        //        }
        //    }
        //}

        //public int Attack
        //{
        //    get
        //    {
        //        return attack;
        //    }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            attack = 0;
        //        }
        //        else
        //        {
        //            attack = value;
        //        }
        //    }
        //}

        //public void AttackEnemy(Knight knight)
        //{
        //    Console.WriteLine($"{name}이/가 공격합니다.");
        //    hp -= attack;
        //    Console.WriteLine($"{name}의 남은 HP는 {hp} 입니다.");
        //}





        // 정적 메서드
        internal static void UPCount()
        {
            count++;
        }

    }
}
