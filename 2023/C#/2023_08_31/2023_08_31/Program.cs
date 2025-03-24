using System;

namespace _2023_08_31
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 로컬함수
            // 메서드 안에 메서드를 선언하는것
            // 그 안에서만 사용하는 메서드
            // 그 안에 사용된 변수 사용
            // 밖에서 다시 쓸 일이 없는 반복적인 작업을 하나의 이름 아래 묶어두는데 좋음 

            int Add(int a, int b)
            {
                return a + b;
            }

            float Sub(float a, float b)
            {
                return a - b;
            }

            string[] inputInt = Console.ReadLine().Split();
            int x = Convert.ToInt32(inputInt[0]);
            int y = Convert.ToInt32(inputInt[1]);
            Add(x, y);
            Sub(x, y);
            #endregion

            int a = new int();
            SalaryMan c = new SalaryMan();/* 컴퓨터가 읽는 방법: SalaryMan*/
            SalaryMan cds = new SalaryMan(1231231);/*SalaryManInt*/
            //object b = new int();
        }
    }

    class SalaryMan
    {
        int salary = 1000000;
        readonly int bouns = 5;

        int getAnnual()
        {
            return salary * 12/*<- 매직넘버*/ + salary * bouns/*<- 매직넘버 해결: 읽기 전용(값이 변핮 않는변수)*/;
        }
        /*SalaryMan*/
        public SalaryMan() // 생성자는 제일 아래에~~
        {
            Console.WriteLine("회사원이 생성~~~");
        }
        /*SalaryManInt*/
        public SalaryMan(int salary)
        {
            this.salary = salary;
        }



        //    /*SalaryManIntInt*/
        //    public SalaryMan(int a, int b)
        //    {

        //    }
        //    ///*SalaryManIntInt*/
        //    //public SalaryMan(int b, int a)
        //    //{

        //    //}
        //    /*SalaryManFloat*/
        //    public SalaryMan(float a)
        //    {

        //    }
    }
}
