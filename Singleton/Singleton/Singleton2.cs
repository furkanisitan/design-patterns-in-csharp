
namespace Singleton
{
    // Singleton1 sınıfında yapılan yöntem, multi threading olarak çalışan programlarda
    //  her zaman tek bir nesnenin yaratılacağını garanti edemez.

    class Singleton2
    {

        private static Singleton2 myObj;
        private static object lockObj = new object();

        protected Singleton2()
        {
            //
        }

        // Lock, bir kaynağa aynı anda birden fazla thread'in erişmesini engeller.
        public static Singleton2 getObject()
        {
            if (myObj == null)
                lock (lockObj)
                    if (myObj == null)
                        myObj = new Singleton2();
            return myObj;
        }

    }
}
