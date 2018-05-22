using System;

namespace AbstractFactory
{

    /* Abstract Factory paterni, farklı nesne aileleri ile çalışan bir istemcide,
    istemcinin nesnelerin üretiminden haberdar/sorumlu olmaması istenildiği durumlarda kullanılır.
    İstemci nesneleri bir abstract class(factory) aracılığı ile yaratır.

    Paternin uygulanmasında temel olarak 5 kısım vardır;
    * AbstractFactory => Soyut ürünler yaratan işlemler için bir arayüz bildirir.
    * ConcreteFactory => Somut ürün oluşturma işlemlerini yürütür.
    * AbstractProduct => Ürün nesnesinin tipi için arayüz bildirir.
    * Product         => ConcreteFactory tarafından oluşturulacak taban nesnesini tanımlar.
    * Client          => AbstractFactory ve AbstractProduct sınıfları tarafından bildirilen arayüzleri kullanır.
         
    
    Bu örnek için;
    AbstractFactory => DBFactory
    ConcreteFactory => SQLFactory, OracleFactory
    AbstractProduct => Command, Connection
    Product         => SQLCommand, SQLConnection, OracleCommand, OracleConnection
    Client          => Client
    */
    public class Client
    {
        public static void Main(string[] args)
        {
            DBFactory db = FactoryUtil.GetFactory("SQL");
            Connection con = db.CreateConnection();
            con.Connect();
            Command cmd = db.CreateCommand();
            cmd.Query = "select * from table";
            cmd.Execute();

            db = FactoryUtil.GetFactory("Oracle");
            con = db.CreateConnection();
            con.Connect();
            cmd = db.CreateCommand();
            cmd.Query = "select * from table";
            cmd.Execute();

            Console.ReadKey();
        }

    }
}
