using System;
using Visitor.Controls;
using Visitor.Visitors;

namespace Visitor
{
    /*
    - Visitor paterni, mevcut sınıf hiyerarşisini değiştirmeksizin bir takım alt
    sınıflara yeni özellikler kazandırmayı sağlar. 
    
    - Örneğin Asp.Net kütüphanesinde tüm control ler 'Control' isimli sınıftan türemiştir.
    Böylece id, text, visible gibi üyeler tüm alt sınıflara miras olarak aktarılmıştır.
    Ancak bunların yanı sıra 'EnableViewState' veya 'Controls' gibi bazı üyelerde tüm alt sınıflara mecburen aktarılmış olur.
    Fakat bu üyeler tüm alt sınıflarda kullanılamamaktadır.
    Örneğin TextBox' ın asla child kontrolü olamayacağı için bu kontroldeki 'Controls' property si anlamsızdır.
    İşte bu noktada doğru çözüm visitor paternidir.

    Visitor paterninin 4 temel kısmı vardır.
    - Element => İlave özelliklerin ekleneceği elementlerin(ConcreteElement) taban sınıfıdır.
      İçerisinde Accept(Visitor visitor) şeklinde bir abstract method barındırır.
      Bu method sayesinde, ilave edilmek istenen fonksiyon veya özellikler ilgili elemente dahil edilir.
    - ConcreteElement => Element isimli abstract class' ı miras alan sınıflardır.

    - Visitor => abstract class veya interface' dir. İçerisinde Visit(Element element) isimli method tanımlıdır.
      Bu method ile ilgili elementin dinamik türüne göre yeni özelliğin eklenip eklenmeyeceğine karar verilir.
    - ConcreteVisitor => İlave özellikleri temsil eden sınıflardır. Visitor 'ı taban alırlar.
    */

    class Program
    {
        static void Main(string[] args)
        {
            // Elementler
            Control pnl = new Panel();
            Control ddl = new DropDownList();
            Control txt = new TextBox();

            // Visitorlar
            IVisitor cv = new ControlsVisitor();
            pnl.Accept(cv);
            ddl.Accept(cv);
            txt.Accept(cv);

            IVisitor sv = new StateFullVisitor();
            pnl.Accept(sv);
            ddl.Accept(sv);
            txt.Accept(sv);

            Console.ReadKey();
        }
    }
}
