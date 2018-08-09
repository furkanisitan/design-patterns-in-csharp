using DependencyInjection.Concrete;
using System;

namespace DependencyInjection
{
    /*
     Dependency Injection paternine, bağımlılıkların olduğu tasarımlarda ihtiyaç duyulur.
     
     İyi bir tasarımda beklenen;
     - Bağımlılıkların somut değil, soyut implementasyonlara dayalı olması,
     - Bağımlılıklar yüzünden oluşabilecek çalışma zamanı hatalarının olmaması,
     - Bağımlılıkların dışarıdan enjekte edilebilmesi,
     - Bağımlılık değiştirilmek istendiğinde, kaynak kodu değiştirmeye veya yeniden derlemeye ihtiyaç duyulmamasıdır.
     İşte Dependency Injection paterni de bu beklentileri karşılar.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Context.DependencyRegister("page", new Page());
            Context.DependencyRegister("screen", new Screen());

            var smp = Context.CreateSample();
            smp.Test();

            Console.ReadKey();
        }
    }
}
