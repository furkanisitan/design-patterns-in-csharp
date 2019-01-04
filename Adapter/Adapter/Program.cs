using System;

namespace Adapter
{
    /*
     * Adapter design paterninde, birbirleriyle uyumsuz olan yapıları uyumlu hale getirme durumu
     söz konusudur.
     
     * İki temel unsur bulunur. Adaptee ve Adapter.
     * Adaptee isimli sınıf adapte edilmek istenen nesneyi temsil eder.
     * Adapter sınıfı ise Adaptee sınıfını referanse ederek bu sınıfa ilişkin metodları
     kendi wrapper(sarmalayıcı) metodları ile sarmalar ve proje iin uyumlu hale getirir.
     * Böylelikle Adaptee sınıfının metodlarına Adapter sınıfı üzerinde erişilir.
     
     
     * Bu projede verilen örnekte;
     * Adaptee => Log4NetDll, Adapter => Log4NetAdapter sınıfıdır.
     
     * EntityManager'ın yapıcı metodu ILogger tipinde bir değişken alır.
     * MyLogger sınıfı ILogger arayüzünü implemente ettiği için burada bir sorun yoktur.

     * Fakat nuget üzerinde Log4Net paketinin indirildiği varsayılsın.
     * Bu paket bir dll'dir ve dll'in içindeki sınıflara müdahale edilemez.
     * Yani dll'deki log4Net sınıfı bizim oluşturduğumuz ILogger arayüzünü implement edemez.
     * Fakat EntityManager ILogger tipinde bir parametre beklemektedir.
     
     * Burada bir adapter paterni uygulanarak Log4NetAdapter sınıfı oluşturulmuştur.
     * Bu sınıf ILogger arayüzünü implemete etmektedir.
     * Ayrıca içinde bulunan Log metodu da Log4Net dll'indeki sınıfa ait metodu kullanır(sarmalar)
     * Böylelikle Log4NetAdapter sınıfı üzerinden Log4NetDll sınıfının özelikleri kullanılabilir.
     */


    class Program
    {
        static void Main(string[] args)
        {

            // MyLogger
            var entityManager1 = new EntityManager(new MyLogger());
            entityManager1.Add();

            // Log4Net
            var entityManager2 = new EntityManager(new Log4NetAdapter());
            entityManager2.Add();

            Console.ReadLine();
        }
    }
}
