namespace Adapter
{
    class Log4NetAdapter : ILogger
    {
        public void Log(string message)
        {
            var log4Net = new Log4NetDll();
            log4Net.LogMessage(message);
        }
    }
}
