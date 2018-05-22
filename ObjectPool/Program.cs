using System;

namespace ObjectPool
{
    // Aynı sınıfa ait birden çok nesnenin sürekli kullanıldığı bir ortamda, bu nesneye her ihtiyaç duyulduğunda
    //  nesneyi ilgili sınıftan yaratmak performas düşüklüğüne neden olabilir.
    // Bunun yerine ObjectPool pattern kullanılır.
    // Bu paternde ilgili nesne belli bir miktarda yaratılıp bir havuzda tutulur.(ObjectPool)
    // Nesneye ihtiyaç duyulduğunda bu havuzdan nesne talep edilir.

    class Program
    {
        // Bu örnekte;
        // Connection sınıfından yaratılan nesne ile Open() metodu kullanılmak istendiğinde PoolManager devreye girer.
        // Connection.Open() çalıştırıldığında eğer hafuzda müsait nesne varsa bu nesne kullanılır, yoksa 
        //  olmadığı bildirilir ve bağlantı gerçekleşmez.

        static void Main(string[] args)
        {
            // ConnectionContext yaratılacak.
            Connection connection = new Connection("k1");
            connection.Open();
            connection.Execute("select1");
            connection.Close();

            Console.WriteLine("--------------------------------------");

            // 'k1' ConnectionString'i ile yaratılmış bir nesne zaten var olduğu için create işlemi yapılmaz,
            //  hazır olan kullanılır.
            Connection connection2 = new Connection("k1");
            connection2.Open();
            connection2.Execute("select2");
            connection2.Close();

            Console.WriteLine("--------------------------------------");

            // 'k2' ConnectionString'i olan bir ConnectionContext olmadığı için ConnectionContext yaratılır.
            Connection connection3 = new Connection("k2");
            connection3.Open();
            connection3.Execute("select3");
            connection3.Close();

            Console.ReadKey();
        }
    }
}
