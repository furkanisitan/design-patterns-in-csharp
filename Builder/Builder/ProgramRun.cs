using System;

namespace Builder
{
    // Builder paterni, aynı kompleks ürünün farklı farklı parçalarla oluşturulup farklı farklı sununların elde
    //  edilmesini sağlamaktadır.

    // Örn: Bilgisayar => Kompleks ürün, Parçalar => Monitör, Klavye, Mouse,.. => Parçalar
    // Belirtilen parçalar bir araya getirildiğinde farklı özelliklerde ürünler oluşur, 
    //  fakat sonuçta hepsi bilgisayardır.

    class ProgramRun
    {
        // Bu örnekte;
        // ConcreteBuilder => ürün nesnesini oluşturan sınıf. (Her farklı ürün için ayrı bir ConcreteBuilder vardır)
        // Builder => ConcreteBuilder sııflarının ata sınıfı.
        // Product => Ürün nesnesini tutan sınıftır.
        // Director => Ürün oluşumunu yöneten sınıf.

        public static void run()
        {
            string[] partList1 = { "a", "b", "c" };
            string[] partList2 = { "d", "e", "f" };

            Builder builder = new ConcreteBuilder1();
            Director.Construct(builder,partList1);
            Product product1 = builder.GetProduct();
            Console.WriteLine(product1.ToString());

            builder = new ConcreteBuilder2();
            Director.Construct(builder, partList2);
            Product product2 = builder.GetProduct();
            Console.WriteLine(product2.ToString());

            Console.ReadKey();
        }

    }
}
