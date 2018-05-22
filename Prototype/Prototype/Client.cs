using System;

namespace Prototype
{

    // Prototype paterni, sıfırdan yaratılması maliyetli olan nesneleri klonlama yoluyla oluşturmayı sağlar.
    // Klonlanan nesneye gerekli özellikler eklenerek istenilen nesne elde edilebilir.
        
    // Client => Ürün nesneyi kullanmak isteyen sınıf
    // Prototype => Kendini klonlayabilen sınıflar için taban sınıf. (Çoğunlukla abstract class veya interface)
    // ConcretePrototype => Kendini klonlayabilen nesnelerin sınıfları.

    class Client
    {
        // Bu örnekte;
        // Prototype => ICloneable, ConcretePrototype => Database, Client => Client dir.
        // Bu tür kopyalamaya yüzeysel kopyalama(shallow copy) denir.

        public static void run()
        {
            Database mdl = new Database();

            Database db1 = (Database)mdl.Clone();
            db1.Name = "StokTakip";
            db1.AddTable("Stoklar");
            Console.WriteLine($"Veritabanı İsmi: {db1.Name}");
            db1.TableList();

            Console.WriteLine("------------------------------");

            Database db2 = (Database)mdl.Clone();
            db2.Name = "CRM";
            db2.AddTable("Musteriler");
            Console.WriteLine($"Veritabanı İsmi: {db2.Name}");
            db2.TableList();

            Console.ReadKey();
        }
    }
}
