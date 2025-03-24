using System;

namespace Cat
{
    class Cat
    {
        string name;
        int age;
        public static int Count = 0;    // 정적 변수

        // 생성자
        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;

            ++Count;
        }
    }
}
