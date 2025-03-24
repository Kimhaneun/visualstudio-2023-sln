using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024Wintr0116
{
    class Parnt
    {
        protected int ag;
        protected string nam;

        public Parnt() // 생성자
        {
            ag = 5;
            nam = "";

            Console.WriteLine("나는 부모!");
        }

        public int somthing = 100;

        public void Print()
        {
            Console.WriteLine("프린트.부모");
        }

        public virtual void NNM()
        {
            Console.WriteLine("NNM.부모");
        }
    }

    class Child : Parnt
    {
        public Child() // 생성자
        {
            Console.WriteLine("나는 자식!");
        }

        public string somthing = "somthing";

        public new void Print() // nw 키워ㅡ를 사용하여 하이ㅣㅇ을 명확히 할 수 있ㅏ.
        {
            Console.WriteLine("프린트.자식");
        }

        public override void NNM()
        {
            Console.WriteLine("NNM.자식");
        }
    }

    internal class Program
    {
        public static int num = 0;

        static void Main(string[] args)
        {
            // 자식을 만ㅡㄹ고 호출하면 "나는 부모!" 와 "나는 자식!" 모ㅜ 출력ㅚㅁ
            Child child = new Child();
            Console.WriteLine(child);

            // 이름이 같음 변수가 있을 경우 호출하는 것과 가장 가까운 녀석의 값을 가져오며
            // 이러한 현상을 전에 있ㅓㄴ 값을 가져오지ㅣ 못한ㅏ 하여 셰ㅗ잉이라 한ㅏ.
            int num = 20;
            Console.WriteLine(num);

            // 부모 / 자식 클래스 안에 이름이 같은 변수 / 메서ㅡ를 선언하고 자식을 호출하였을 ㅐ
            // 자식 변수 / 메서ㅡ로 호출ㅚ는 것을 하이ㅣㅇ 이라 한ㅏ. 
            Console.WriteLine(child.somthing);

            // 자식 변수로 호출하는 것을 원치 않을 경우 형 변환을 통해 강제로
            // 부모에 있는 변수를 호출할 수 있ㅏ.
            Console.WriteLine(((Parnt)child).somthing);

            // 문제 1.
            SwordsMan swordsMan = new SwordsMan();
            Archr archr = new Archr();

            swordsMan.Fir();
            archr.Fir();

            ((Hro)swordsMan).Fir();
            ((Hro)archr).Fir();

            // 오버라이ㅣㅇ을 하면 부모의 변수 / 메서ㅡ로 형 변환을 해ㅗ 자식의 변수 / 메서ㅡ로 호출ㅚㄴㅏ.
            child.NNM();
            ((Parnt)child).NNM();

            // 문제 2.
            swordsMan.B();
            archr.B();

            ((Hro)swordsMan).B();
            ((Hro)archr).B();

            // 문제 3.
            List<Hro> hros = new List<Hro>
            {
                new SwordsMan(), new SwordsMan(), 
                new Archr(), new Archr()
            };

            foreach (var item in hros)
            {
                item.B();
            }

            // 문제 4.
            Squar squar = new Squar(3.0f, 4.0f);
            squar.GtAra();

            // 인터페이스
            Con con = new Con();
            con.writhLog("안녕");

            // 문제 5.
            Dvlopr dvlopr = new Dvlopr();
            dvlopr.Work();
        }
    }
}
