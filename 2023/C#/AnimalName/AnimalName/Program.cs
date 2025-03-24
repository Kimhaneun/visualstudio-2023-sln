using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalName
{
    class Program
    {
        static void Main(string[] args)
        {
            // ?. 널 조건부 연산자
            string animal = null;

            Console.WriteLine("4글자 이상의 동물의 이름만 츨력합니다.");
            do
            {
                longNameAnimal(animal);
                Console.WriteLine("동물 이름을 입력하십시오 : ");

            } while ((animal = Console.ReadLine()) != "");

           
        }
        
        private static void longNameAnimal(string animal)
        {
            if (animal?.Length >= 4)
                Console.WriteLine(animal + " : " + animal.Length);
        }
    }
}
