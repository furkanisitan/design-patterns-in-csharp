using System;

namespace Mediator
{
    /*
     Mediator paterni aralarında iletişim kuracak nesnelerin(colleague) birbirlerini
    bilmeksizin merkezi bir(mediator) nesne üzerinden haberleşmesini öngürür.

     Örnek olarak havaalanı modellemesini ele alalım:
     Üçakların pist kullanımı için birbirleriyle haberleşmesi halinde ortaya büyük bir karmaşa çıkar.
     Fakat her uçak kontrol kulesi gibi merkezi bir unsur ile haberleşirse bir sıkıntı yaşanmaz.

     Bu paternin uygulanmasında 4 temel unsur vardır:
     - ConcreteColleague => İletişim kuracak sınıflar
     - Colleague => ConcreteColleague sınıfları tarafından kalıtılacak soyut sınıf
     - ConcreteMediator => ConcreteColleague sınıflarının iletişimini yönetecek merkezi sınıf
     - Mediator => ConcreteMediator sınıfları tarafından kalıtılacak soyut sınıf 
     
     Bu örnekte;
     ConcreteColleague=NormalSubscriber&Moderator, Colleague=Subscriber, ConcreteMediator=SoftwareRoom,
     Mediator=Room sınıfları olarak tanımlanmıştır.
    */


    class Program
    {
        static void Main(string[] args)
        {
            Subscriber s1 = new NormalSubscriber("normal1");
            Subscriber s2 = new NormalSubscriber("normal2");
            Subscriber s3 = new NormalSubscriber("normal3");
            Subscriber s4 = new NormalSubscriber("normal4");
            Subscriber s5 = new Moderator("furkan");

            SoftwareRoom softwareRoom = new SoftwareRoom();
            softwareRoom.AddSubscriber(s1);
            softwareRoom.AddSubscriber(s2);
            softwareRoom.AddSubscriber(s3);
            softwareRoom.AddSubscriber(s4);
            softwareRoom.AddSubscriber(s5);

            softwareRoom.BroadcastSendMessage(s5, "Herkese selam");

            softwareRoom.SendMessage(s2, s3, "Ders ne zaman?");
            softwareRoom.SendMessage(s3, s2, "14:30 da");

            softwareRoom.SendMessage(s1, s4, "Dün aksamki maç kaç kaç bitti?");
            softwareRoom.SendMessage(s4, s1, "2-1");

            Console.ReadKey();
        }
    }
}
