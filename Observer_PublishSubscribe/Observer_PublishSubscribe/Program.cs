using System;

namespace Observer_PublishSubscribe
{
    /*
     Diğer adıyla Publish-Subscribe olarak da bilinen observer paterni;
    Bir nesnenin durumu değiştiğinde kendisini izleyen nesnelere bildirim göndererek,
    izleyici nesnelerin durumlarını güncellemesi esasına dayanır.

    Bu paternin uygulanmasında 4 temel unsur yer alır:
    - Concrete Subject => Gözetlenen sınıflar.
    - Subject => Concrete Subject sınıflarının implement ettiği interface
    - Concrete Observer => Gözetleyen(Gözetleyici) sınıflar
    - Observer => Concrete Observer sınıflarının miras aldığı soyut sınıf
    Concrete Subject nesneleri kendi içinde, kendisini gözleyen Concrete Observer nesnelerini tutar
    
    Bu örnekte:
    Concrete Subject=Stock, Subject=IObservable, Concrete Observer=Label, Observer=Control olarak tanımlanmıştır.

    */

    class Program
    {

        public static void Display(Control c)
        {
            Console.WriteLine($"{c.Name} : {c.Text}");
        }

        static void Main(string[] args)
        {

            Control c1 = new Label();
            c1.Name = "txt1";

            Control c2 = new Label();
            c2.Name = "txt2";

            // Kontrollerin register edilmesi
            Stock stock = new Stock();
            c1.Add(stock);
            c2.Add(stock);

            stock.Notify();
            Display(c1);
            Display(c2);

            // Değişiklikler otomatik olarak bildiriliyor
            stock.GetItem();
            Display(c1);
            Display(c2);

            stock.GetItem();
            Display(c1);
            Display(c2);

            Console.ReadKey();

        }
    }
}
