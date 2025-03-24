using System;

public class Program
{
    #region 매소드 오버로딩
    static int Min(int a, int b) // 매소드의 이름이 모두 같지만, 매개 변수로 알잘딱 구분해줌
    {
        return a < b ? a : b;
    }

    static int Min(int a, int b, int c)
    {
        return (a < b ? a : b) > c ? c : (a < b ? a : b);
    }

    static float Min(float a, float b)
    {
        return a < b ? a : b;
    }

    static float Min(float a, float b, float c)
    {
        return (a < b ? a : b) > c ? c : (a < b ? a : b);
    }

    static void Main(string[] args)
    {
        Min(3, 5);
        Min(3.5f, 10.9f);
        Min(6, 5, 9);
        Min(23.4f, 42.53f, 6657.4f);
    }
    #endregion
}

