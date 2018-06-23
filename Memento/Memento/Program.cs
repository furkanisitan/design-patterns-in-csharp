using System;

namespace Memento
{
    /*
    * Nesnelerin durum bilgileri değişebilir veya tümüyle yok olabilir. Bu durumda nesneyi önceki
    durumuna geri döndürmek için Memento paterni uygulanabilir.
    
    Bu paternde 3 temel kısım vardır.
    - Originator => Durum bilgisi korunarak gerektiğinde önceki durumuna geri döndürülmek istenen nesnelere denir.
    - Memento => Originator nesnenin durumunu saklar. Bu nesne Originator tarafından yaratılır ve sadece
    Originator tarafından manipüle edilmelidir.
    - Caretaker => Çoğu zaman Originator nesnenin belirli sayıdaki durumları ayrı ayrı saklanmak istenir.
    Bu durumda Caretaker isimli nesnenin içinde n tane Memento nesnesi saklanabilir.
    
    * Genellikle 'undo' sistemlerinde Memento nesneler bir stack sistemiyle saklanır.
    */

    class Program
    {
        /*
        Bu örnekte;
        Originator => Element, Memento => Memento, Caretaker => kullanılmadı
        */

        static void Main(string[] args)
        {
            ElementInfo elementInfo = new ElementInfo();
            elementInfo.Type = ElementType.Transistor;
            elementInfo.Detail = "BC-237";
            elementInfo.Location = new Location(12, 35);

            Element originator = new Element(elementInfo);
            Console.WriteLine(originator.ToString());

            Memento memento = originator.CreateMemento();

            originator.ElementInfo = new ElementInfo(ElementType.Transistor, "BD-547", new Location(12, 35));
            Console.WriteLine(originator.ToString());

            originator.SetMemento(memento);
            Console.WriteLine(originator.ToString());

            Console.ReadKey();
        }
    }
}
