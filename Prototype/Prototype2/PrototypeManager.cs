using System;
using System.Collections.Generic;

namespace Prototype2
{
    [Serializable]
    public class PrototypeManager : PrototypeHelper<Account>
    {
        public Dictionary<string, Account> accounts = new Dictionary<string, Account>()
        {
            { "1", new Account(1000, "Furkan","Işıtan")},
            { "2", new Account(1000, "Lionel","Messi") },
            { "3", new Account(1000, "Cristiano","Ronaldo")}
        };
    }
}
