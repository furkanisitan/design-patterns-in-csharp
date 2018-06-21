using Strategy_Policy.Context;
using Strategy_Policy.Strategy.Abstract;
using Strategy_Policy.Strategy.Concrete;
using System;

namespace Strategy_Policy
{
    /*
    * Strategy(Policy) paterni, bir işin birden fazla algoritması olduğu bir uygulamada, iş için
    hangi stratejinin(algoritmanın) seçileceğini belirler.
    * Bu paternde algoritmalar ile bunları kullanan sistemin arasındaki ilişki kalıcı değil, geçicidir.
    * Sistemden bağımsız olarak yeni algoritmalar eklenebilmeli veya mevcutlarda değişiklik yapılabilmelidir.
    * Ancak kullanıcı bu değişimlerden etkilenmemelidir.
    * Geçici/Kalıcı İlişki Örneği;
    Günlük hayatta bir yerden bir yere gitmenin birden fazla yolu vardır.
    - Kendi Otomobilimiz => Kalıcı ilişki
    - Taksi, Otobüs => Geçici ilişki

    * Paternin uygulanmasında 3 temel kısım vardır.
    - Strategy => Yöntemlerin(algoritmaların) taban sınıfı veya arayüzü.(Abstract Class or Interface)
    - ConcreteStrategy => Örnek uzaydaki her bir yöntemi temsil eden sınıflar.(Her yöntem ayrı bir sınıfla temsil edilir)
    - Context => Yöntemleri seçecek ve uygulayacak sınıf. Bu sınıf Strategy arayüzünü tanımalı ancak yöntemlere
    ilişkin sınıfları asla tanımamalıdır.
        
    */

    class Program
    {
        static void Main(string[] args)
        {
            Brush b1 = new SolidBrush();
            Brush b2 = new LinearGradienBrush();
            Brush b3 = new RadialGradienBrush();

            Rectangle rectangle = new Rectangle(b3);
            rectangle.Draw();

            Console.ReadKey();
        }
    }
}
