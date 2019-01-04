using System;

namespace Adapter
{
    class Log4NetDll
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"Log4Net : {message}");
        }
    }
}
