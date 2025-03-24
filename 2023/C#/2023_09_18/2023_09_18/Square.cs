using System;

namespace _2023_09_18
{
    class Square : Shape
    {
        public float _height { get; set; } // 인스턴스 변수
        public float _width { get; set; }

        public Square(float higth, float width)
        {
            higth = _height;
            width = _width;
        }

        public override float GetArea()
        {
            return _height * _width;
        }
    }
}
