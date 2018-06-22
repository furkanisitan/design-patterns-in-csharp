using State_Observer_Singleton.Context;
using State_Observer_Singleton.Observer.Concrete;
using System;

namespace State_Observer_Singleton
{
    /*
    State paterni, nesnenin durumu değiştiğinde başka bir nesneye haber vermez.
    Fakat bu temayı kullanan(durum değişikliğini bildirme) Observer paterni ile birlikte kullanılabilir.
    Ayrıca, State paternindeki durum sınıflarının da singleton tasarlanması önerilmektedir.
    Bu örnekte bu üç patern birlikte kullanılmıştır.
    */

    class Program
    {
        static void Main(string[] args)
        {
            ThreadContext thread = new ThreadContext();
            ThreadMonitor monitor = new ThreadMonitor();

            thread.Register(monitor);

            thread.Start();
            thread.Start();
            thread.Sleep();
            thread.Start();
            thread.Abort();
            thread.Start();
            thread.Abort();
            thread.Abort();

            Console.ReadKey();
        }
    }
}
