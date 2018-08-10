using Decorator.Concrete;
using System;

namespace Decorator
{
    /*
     Decorator paterni, sınıfın yapısında değişikliğe gidilmeksizin belirli bir nesneye(sadece o nesne etkilenir)
    dinamik olarak yeni fonksiyon ve özelliklerin eklenmesini tematize eder.
     
     Bu paternin uygulanmasında 4 temel kısım vardır.
     - Component => Yeni özellikler eklenmek istenen nesneyi soyut anlamda temsil eder. (interface, abstract class)
     - ConcreteComponent => Component arayüzünü somutlaştıran sınıf(lar).
     - Decorator => Üzerinde dekorasyon yapılmak istenen nesneler için bir wrapper(sarmalayıcı) durumundadır. Soyuttur.
     - ConcreteDecorator => Dekorasyonları gerçekleştirecek sınıf(lar).

     Decorator soyut sınıfı, Component sınıfını sarmaladığı için bu sınıfı miras alır.
     Ayrıca içerisinde, dekore edeceği sınıfın referansını tutması gerektiğinden Component tipinde bir değişken tanımlıdır.
    */

    class Program
    {
        static void Main(string[] args)
        {
            // Concrete Components
            var window1 = new LoginWindow("Login to System");
            var window2 = new ReportWindow("Stock Report Screen");
            var window3 = new ReportWindow("Sales Report Screen");

            // Concrete Decorators
            var decorator1 = new ScrollDecorator(window2, "Stock Report Screen");
            var decorator2 = new ThemeDecorator(window1, "Login to System");
            var decorator3 = new ThemeDecorator(window3, "Sales Report Screen");
            var decorator4 = new ThemeDecorator(window2, "Stock Report Screen");

            decorator1.ScrollBy(7);
            decorator2.SetTheme("sky");
            decorator3.SetTheme("autumn");
            decorator4.SetTheme("sea");

            Console.ReadKey();
        }
    }
}
