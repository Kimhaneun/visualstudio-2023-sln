using System;

namespace _2023_10_05
{
    #region 인터페이스 정렬
    class Product : IComparable // 객체들을 정렬하자!
    {
        public int Price { get; set; }
        public string Name { get; set; }

        public Product(int price, string name)
        {
            this.Price = price;
            this.Name = name;
        }

        public int CompareTo(object obj) // object 형식을 못 써!
        {
            Product pro = obj as Product; // 형 변환!
            return Price.CompareTo(pro.Price); // CompareTo: 반환값이 pro.price 보다 작으면 음수를 반환
                                                                          // 같으면 0
                                                                          // 크면 양수를 반환

            // 비교 기준을 만들어 준거야~
        }

        public override string ToString()
        {
            return $"{Name}: {Price}원";
        }
    }
    #endregion
}
