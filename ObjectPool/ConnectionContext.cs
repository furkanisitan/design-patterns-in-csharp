using System;

namespace ObjectPool
{
    public class ConnectionContext
    {
        // Nesnenin kullanılıp kullanılmadığı bilgisi
        public bool IsActive { get; set; }

        public ConnectionContext()
        {
            IsActive = false;
            Console.WriteLine($"{GetType().Name} yaratıldı.");
        }

        public void Open()
        {
            Console.WriteLine("Connection açıldı.");
        }

        public void Close()
        {
            Console.WriteLine("Connection kapatıldı.");
        }

        public void Execute(string query)
        {
            Console.WriteLine($"{query} çalıştırıldı.");
        }
    }
}
