using System;

namespace Iterator_Cursor
{
    /* 
     Diğer adıyla Cursor olarak da bilinen Iterator paterni;
    yapısı bilinmeyen(Array,List,Collection,...) bir listenin elemanlarına sıralı olarak
    erişmeyi sağlar.

     Örnekte ADKDepartment sınıfı içindeki Employee nesneleri List kullanılarak,
    IKDepartment sınıfı içindeki Employee nesneleri ise Array kullanılarak saklanmıştır.
    Iterator interface'i ile bu listelerdeki elemanlara, listenin yapısıyla ilgilenmeden
    sıralı olarak erişim sağlanmıştır.
    */

    class Program
    {
        static void Main(string[] args)
        {
            IKDepartment ik = new IKDepartment();
            Iterator iterator = ik.GetIterator();

            while (iterator.Next())
                Console.WriteLine(iterator.GetItem().ToString());

            Console.WriteLine("---------------------------------");
            ADKDepartment adk = new ADKDepartment();
            iterator = adk.GetIterator();
            while (iterator.Next())
                Console.WriteLine(iterator.GetItem().ToString());

            Console.ReadKey();
        }
    }
}
