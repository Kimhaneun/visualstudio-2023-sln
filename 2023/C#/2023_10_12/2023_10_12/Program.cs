using System;
using System.IO;

namespace _2023_10_12
{
    class Program
    {
        static void Main(string[] args)
        {
            #region File Stream 
            FileStream fileStream = File.Open(@"D:\2023_10_12 IO\bin.txt", FileMode.Open); // [FileMode]
                                                                                           // Open: 이미 존재하는 파일을 열거야
                                                                                           // OpenOrCreate: 파일이 존재하면 그 파일을 사용하고 없으면 파일을 생성해 사용할거야
                                                                                           // Create: 파일을 생성해서 사용할거야 
                                                                                           // Append: 이미 존재하는 파일에 추가할거야

            for (int i = 0; i < fileStream.Length; i++)
            {
                int value = fileStream.ReadByte(); // ReadByte(): 한 바이트 씩 읽는 방식
                Console.Write($"{value}");
            }
            fileStream.Close();

            // File Stream - Read 메서드
            byte[] numbers = { 2, 9, 5, 8, 100 };
            File.WriteAllBytes(@"D:\2023_10_12 IO\num.txt", numbers);

            fileStream = File.Open(@"D:\2023_10_12 IO\num.txt", FileMode.Open);

            byte[] input = new byte[numbers.Length];
            int n = fileStream.Read(input, 0, 3); // Read: 원하는 갯수 만큼 읽는 방식

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }

            // File Stream - Write 메서드
            byte[] test = new byte[] { 67, 35, 32, 105, 115, 32, 116, 104, 101, 32, 98, 101, 115, 116, 046 };

            fileStream = File.Open(@"D:\2023_10_12 IO\test.txt", FileMode.OpenOrCreate);

            for (int j = 0; j < test.Length; j++)
            {
                fileStream.WriteByte(test[j]);
            }
            fileStream.Close();

            // Stream Writer
            using (var writer = new StreamWriter(File.Open(@"D:\2023_10_12 IO\SW_test.txt", FileMode.OpenOrCreate)))
            {
                writer.Write("dd");
                writer.WriteLine("dd");
                writer.WriteLine("dd");
            }

            // Stream Reader
            using (var reader = new StreamReader(File.Open(@"D:\2023_10_12 IO\SW_test.txt", FileMode.Open))) // using: 중괄호가 전부 끝나면 중괄호를 나간다
            {
                string text = reader.ReadToEnd();
                Console.WriteLine(text);
                reader.Close();
            }
            #endregion

            #region 파일 쓰기 복습
            byte[] bytes_0 = { 12, 65, 3 };
            File.WriteAllBytes(@"D:\2023_10_12 IO\bin.txt", bytes_0);
            #endregion

            #region 파일 읽기 예외 처리
            try
            {
                byte[] bytes_1;
                if (File.Exists(@"D:\2023_10_12 IO\din.txt"))
                {
                    bytes_1 = File.ReadAllBytes(@"D:\2023_10_12 IO\din.txt");
                    for (int i = 0; i < bytes_1.Length; i++)
                    {
                        Console.WriteLine(bytes_1[i]);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            #endregion

        }
    }
}
