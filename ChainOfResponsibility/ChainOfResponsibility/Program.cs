using HandleExpenseExample;
using System;

namespace ChainOfResponsibility
{
    /*
    * İsmi Türkçe'ye "sorumluluk zinciri" diye çevirilmiş olan bu patern, istemcinin bir işi(görev yada sorumluluk)
    hakkında bilgi sahibi olmadığı bir dizi nesneye talep göndererek yaptırmasını tematize eder.
    * Görevi yerine getirecek olan nesneler(handler) ile istemci nesne arasında doğrudan bir ilişki olmamalıdır.(gevşek bağlı)
    * Bu paternde temel incelik, handler nesnelerinin belirli bir sıra düzen içerisinde birbirlerini tanımasını sağlamaktır.
    Bunu için her bir handler nesne kendisinden sonra gelen başka bir handler nesnesinin referansını tutmalıdır.

    Bu örnekte;
    - CallCenter' a çağrı talebi gelir.
    - CallCenter çağrıyı ilk operatöre iletir.
    - Operator musaitse çağrı cevaplanır, değilse bir sonraki operatore iletilir.
    - En son operatörde çağrıyı cevaplamazsa, çağrı beklemeye alınır.
    */

    class Program
    {
        static void Main(string[] args)
        {
            // İstemci operatörleri, operatörler de istemciyi tanımamaktadır.
            Client.Call(new CallCenter());

            Console.WriteLine("\n----------------------------");


            /*
            Bu örnekte;
            - Expense(harcama) nesnesi ilk olarak Manager(yöneticiye) iletilir.
            - Eğer harcama miktarı yöneticinin yetki alanı içinde ise harcamayı onaylar aksi takdirde
            harcama VicePresident'a(başkan yardımcısı) iletilir.
            - Aynı şeyler VicePresident içinde geçerlidir. Harcama yetki alanı dışında ise bunu President'a(başkan)
            iletir.
            - President'da bir yetki sınırlaması tanımlanmadığı için başkan harcamayı onaylar.
            */
            ExpenseHandlerBase manager = new Manager();
            ExpenseHandlerBase vicePresident = new VicePresident();
            ExpenseHandlerBase president = new President();

            manager.SetSuccessor(vicePresident);
            vicePresident.SetSuccessor(president);

            Expense expense = new Expense() { Detail = "Training", Amount = 153 };
            manager.HandleExpense(expense);

            Console.ReadKey();
        }
    }
}
