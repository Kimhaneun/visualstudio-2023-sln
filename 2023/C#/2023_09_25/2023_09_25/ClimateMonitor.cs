using System;

namespace _2023_09_25
{
    class ClimateMonitor
    {
        ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }

        public void Start()
        {
            while (true)
            {
                Console.Write("온도 입력: ");
                string temperature = Console.ReadLine();
                if (temperature == "")
                {
                    break;
                }

                logger.WriteLog("현재 온도: " + temperature);
            }
        }
    }
}
