
namespace Singleton
{

    // Mikroişlemciler değişkenleri her defasında bellekten almak yerine bazen daha hızlı olması
    //  açısından mikroişlemcideki data registerlarda tutabilir.
    // Değişkenin bellek yerine register'da tutulması o değişkenin donanımsal bir kesme ile değiştirilebileceği
    //  anlamına gelir.
    // İşte bu tür durumları engellemek için "volatile" anahtar sözcüğü kullanılır.
    // volatile, derleyicinin bir değişkenin değerini kendi insiyatifiyle registar'da saklayamamasını
    //  ve her zaman bellekte tutmasını sağlar. 

    class Singleton3
    {
        private static volatile Singleton3 myObj;
        private static object lockObj = new object();

        protected Singleton3()
        {
            //
        }
        
        public static Singleton3 getObject()
        {
            if (myObj == null)
                lock (lockObj)
                    if (myObj == null)
                        myObj = new Singleton3();
            return myObj;
        }

    }
}
