using System;

namespace Singleton
{
    // Nesneye erişim için metod yerine C# 'ın sağladığı property özelliği kullanılabilir.

    class Singleton4
    {
        private static volatile Singleton4 myObj;
        private static object lockObj = new object();

        private int randomNum;

        protected Singleton4() {
            randomNum = new Random().Next(100);
        }

        public static Singleton4 getObject
        {
            get
            {
                if (myObj == null)
                    lock (lockObj)
                        if (myObj == null)
                            myObj = new Singleton4();
                return myObj;
            }
        }

        public int getNum()
        {
            return randomNum;
        }
    }
}
