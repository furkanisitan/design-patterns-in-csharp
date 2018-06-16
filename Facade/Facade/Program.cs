using System;

namespace Facade
{
    /*
    * Facade'ın görevi; karmaşık bir yazılım sistemindeki alt sistem nesnelerini kullanıcısından soyutlamaktır.
    * Ayrıca çok katmanlı sistemlerde katmanların birbirinden düzgün bir şekilde soyutlanmasını sağlamak amacıyla
    da sıklıkla kullanılır.
    * Facade sınıflar genellikle 'Singleton' olarak tasarlanırlar.
    * Çoğu zaman, barındırdıkları Factory metodlar yoluyla alt sistem nesnelerinin yaratılmasını sağlarlar.
    * Genellikle Facade sınıf isimlerinde 'Context' kelimesinin kullanımı söz konusudur.
    
    * Facade paterni bazen Mediator paterni ile karıştırılabilir. Aralarındaki en önemli fark;
    Mediator paterninde nesneler Mediator olan nesneyi tanımaktadır oysa Facade alt sistem nesnelerinin facade 
    hakkında bilgisi yoktur.
    */

    class Program
    {
        static void Main(string[] args)
        {
            Facade.Current.Func();
            Facade.Current.DoWork();
            Facade.Current.Sample();
            Facade.Current.SubSystem1.Foo();
            Facade.Current.SubSystem3.Tar();

            Console.ReadKey();
        }
    }
}
