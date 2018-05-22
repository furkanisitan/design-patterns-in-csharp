using System;

namespace Prototype2
{
    [Serializable]
    public class PrototypeClient : PrototypeHelper<Account>
    {
        public static void Display(Account a1, Account a2)
        {
            Console.WriteLine($"{"Prototip",-9}: {a1}\n{"Klon",-9}: {a2}\n");
        }
    }
}
