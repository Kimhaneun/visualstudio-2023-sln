using System;

class Program
{
    #region 명명된 매개 변수
    static int Area(int height, int width)
    {
        return height * width;
    }

    static void Main(string[] args)
    {
        Area(6, 3);
        Area(height: 6, width: 3);
    }
    #endregion

    #region 선택적 매개 변수
    static void PrintP(string name, string address, string phone = "") // 선택적 매개 변수는 마지막 뒤에 써줘야해
    {
        Console.WriteLine($"이름: {name}, 주소: {address}, 전화번호: {phone}");
    }

    static void Main1(string[] args1)
    {
        PrintP(name: "온달", "미르"); // name: "온달" 처럼 사용하는게 가독성이 좋아!
                                     // phone 은 써주지 않아도 오류가 발생하지 않아!
    }
    #endregion

    #region 가변 길이 매개 변수
    static void Printlnt(params int[] iarr)
    {
        foreach(int item in iarr)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("T발롬이랑 예기 안해");
    }
    
    static void PrintObfect(params object[] oarr)
    {
        foreach (int item in oarr)
        {
            Console.WriteLine(item);
        }
    }

    static void Main2(string[] args)
    {
        Printlnt(1, 2);
        Printlnt(3, 5, 6, 2, 4, 4);
        PrintObfect(1, 1.432, 'a', "afjsa");

        int[] iarr = { 1, 4, 45, 324, 3, 3, 2, 2 };
        object[] oarr = { 2, 2, 34, 6, 4645, 65, 's', "asfjakh" };

        Printlnt(iarr);
        PrintObfect(oarr);
    }
    #endregion
}