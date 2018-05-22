
namespace Singleton
{
    // Singleton pattern bir sınıftan sadece bir tane nesne üretilmesi esasına dayanır.
    // İhtiyaç halinde önceden üretilmiş olan nesne üzerinden işlem yapılır.

    class Singleton1
    {
        private static Singleton1 myObj;

        // Default constructor
        protected Singleton1()
        {
            // Contructor sınıf ya private yada protected olmalıdır.
            // Genellikle, türetme işlemlerinde contructor'ı türemiş sınıflara aktarabilmek için
            //  protected tercih edilir.
        }

        // Nesneye getObject() metodu aracılığı ile erişilir.
        public static Singleton1 getObject()
        {
            if (myObj == null)
                myObj = new Singleton1();
            return myObj;
        }
    }
}
