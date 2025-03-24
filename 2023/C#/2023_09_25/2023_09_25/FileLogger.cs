using System;
using System.IO;  // System.IO 가 있어야 StreamWriter 구현 가능

namespace _2023_09_25
{
    class FileLogger : ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string log)
        {
            writer.WriteLine($"{DateTime.Now}, {log}");
        }
    }
}
