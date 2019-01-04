using System;

namespace Adapter
{
    class MyLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"MyLogger : {message}");
        }
    }
}
