using System;

public class Class1
{
    int price = 100;

    public Product()  // 인스턴스 메서드: 앞에 static 등이 붙여있지 않는것
    {
        Console.WriteLine("Product 객체 생성");
    }

    public Product(int price)
    {
        this.price = price;
    }

    public ref int GetPrice() // price 값을 반환 (참조 반환함)
    {
        return ref price;
    }

    public void PrintPrice() // price 값을 출력 (반환값이 없을때 void를 씀)
    {

    }
}

