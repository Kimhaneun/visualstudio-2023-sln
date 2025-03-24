using System;

namespace _2023_03_08_1205_김한은
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 1.
            Console.Write("1205 \n");
            Console.Write("김한은 \n"); 

            // 2.
            Console.WriteLine("1205\n김한은"); // 큰 따음표 ("") 안에 있으면 문자열

            // 3.
            int number = 1205;
            string name = "김한은";
            Console.Write(number);
            Console.Write(name);
            
            // 4.
            Console.WriteLine("이름은 " + name + "입니다.");

            // 5.
            Console.WriteLine("학번은 {1} 이름은 {0} 입니다.", name, number);

            // 6.
            int number_2 = 1203;
            string name_2 = "김진후";
            
            Console.WriteLine("앞 친구의 이름은 " + name_2 + "이고, 번호는 " + number_2 +"입니다.");

        }
    }
}

//이것이 주석이다!!!

/*희망편
 * 
 */