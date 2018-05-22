using FinansLib;
using System;

namespace FactoryMethod
{
    /*
    Bazen bir sınıf, nesne oluşturabilmek için başka bir sınıfın nesnesine ihtiyaç duyar.

    Örn: DataRow sınıfından bir row nesnesi yaratmak;
    - Satır oluşturulacak fakat hangi tabloya göre?
    - Bunu DataRow sınıfının bilmesi gerekir.
    - O zaman DataRow sınıfından direkt nesne yaratılmamalı. (constructor, private veya protected olmalı)
    - DataRow row = new DataTable().NewRow();  
    */

    /*
    VirtualConstructor olarak da bilinen 'FactoryMethod' paterni, nesne yaratılışı için bir arayüz(creator)
     oluşturmayı ve hangi nesnenin yaratılacağına bu sınıftan türeyen alt sınıfların(ConcreteCreator)
     karar vermesini sağlamayı tematize eder.
    */

    /*
    Para basma örneği;

    Parayı herkes kafasına göre basamaz. Bu iş için özel darphaneler vardır.
    - Mint(Darphane) => Creator
    Ülkelere göre her para birimini basan ayrı ayrı darphaneler vardır.(Türkiye=>TL, ABD=>Dolar vs.)
    - TCMint, USMint => ConcreteCreator
    TCMint TL, USMint Dolar basar.
    - Dolar, Lira sınıfları
    Bu sınıflar ise Money sınıfından türer.
    - Money sınıfı ilgili paraya göre işlem yapar.
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Lira tl = new Lira() şeklinde kafama göre lira basamam.
            // Bunu darphanenin basması lazım.
            TCMint tcMint = new TCMint();
            Lira tl = (Lira)tcMint.PrintMoney(200);
            // Peki parayı nerden alacağım?
            // Money sınıfından. Ama Money sınıfına direkt erişimim yok ve
            //  Money sınıfı bana hangi türde para vereceğini nerden bilecek?
            // Money sınıfına Lira sınıfı üzerinden erişeceğim ve Lira sınıfı üzerinden eriştiğim için
            //  bana Lira olarak para vereceğini bilecek.
            Console.WriteLine(tl.getNominalValue);

            // Dolar dolar = (Dolar)tcMint.PrintMoney(250); // TODO Hata (TCMint darphanesi Dolar basamaz)

            USMint usMint = new USMint();
            Dolar dolar = (Dolar)usMint.PrintMoney(250);
            Console.WriteLine(dolar.getNominalValue);

            Console.ReadKey();
        }
    }
}
