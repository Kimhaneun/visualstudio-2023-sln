using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024Winter
{
    class Swordsman : Hero
    {
        string sword;

        public Swordsman(string nam, string sword, float xp)
        {
            this.nam = nam;
            this.sword = sword;
            this.XP = xp;
        }

        public Swordsman()
        {
            nam = "링크";
            sword = "마스터 소ㅡ";
            XP = 1;
        }

        float XP
        {
            get
            {
                return XP;
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("잘못ㅚㄴ 값입니ㅏ.");
                else
                    XP = value;
            }
        }

        public void swordAttack()
        {
            Console.WriteLine("찌르기!");
        }
    }
}
