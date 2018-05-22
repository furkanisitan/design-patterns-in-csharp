using System;

namespace Prototype2
{
    // Prototype paterninde 'Yüzeysel' ve 'Derin' o.ü. iki tip klonlama vardır.
    // Prototype projesindeki örnek yüzeysel klonlamadır.

    // Yüzeysel klonlama 'Prototype' projesindeki durum için kullanışlı olmasına rağmen, içerisinde başka nesneleri
    //  referanse eden sınıfları kopyalamada yetersiz kalır.
    // Bu noktada Derin kopyalamaya ihtiyaç duyulur.
    // Derin kopyalamada nesnenin referanse ettiği nesnelerde kopyalanır.
    // Bu işlem için .NET kütüphanesi serialization mekanizmasını sağlar.

    public class Client
    {
        // Bu örnekte;
        // Prototype => PrototypeHelper, ConcretePrototype => Account, Client => Client, PrototypeClient dir.
        // Account sınıfı, kendi içinde Customer sınıfını da referanse ettiğinden bu örnekte yüzeysel klonlama
        //  yetersiz kalacaktır.

        public static void run()
        {

            PrototypeManager pm = new PrototypeManager();

            Console.WriteLine("Yüzeysel Klonlama");

            Account a = pm.accounts["1"].Clone();
            PrototypeClient.Display(pm.accounts["1"], a);

            a.Balance = 300;
            PrototypeClient.Display(pm.accounts["1"], a);

            a.Customer.Surname = "Kara";
            PrototypeClient.Display(pm.accounts["1"], a);

            // Klonda yapılan soyadı değişikliği, prototype' ı da etkiledi.
            // Çünkü soyadı değişkeni Customer nesnesinde tutuluyor ve Customer nesnesi yüzeysel klonlamada
            //  klonlanmadı.
            // Yani hem prototype'da hem de klon da aynı Customer nesnesi mevcut.

            /////////////////////////////////////////////

            Console.WriteLine("Derin Klonlama");

            Account b = pm.accounts["3"].DeepCopy();
            PrototypeClient.Display(pm.accounts["3"], b);

            b.Balance = 250;
            PrototypeClient.Display(pm.accounts["3"], b);

            b.Customer.Surname = "Çelik";
            PrototypeClient.Display(pm.accounts["3"], b);

            // DeepCopy' de Customer sınıfının da kopyası alındığından kopyada yapılan soyadı değişikliği
            //  prototype' ı etkilemez.

            Console.ReadKey();
        }
    }
}
