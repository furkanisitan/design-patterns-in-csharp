namespace Facade
{
    public class Facade
    {
        private static object lockObj = new object();
        private static volatile Facade facade;

        private SubSystem2 subSystem2;

        public SubSystem1 SubSystem1 { get; }
        public SubSystem3 SubSystem3 { get; }

        public static Facade Current
        {
            // Singleton
            get
            {
                if (facade == null)
                    lock (lockObj)
                        if (facade == null)
                            facade = new Facade();
                return facade;
            }
        }

        private Facade()
        {
            SubSystem1 = new SubSystem1();
            subSystem2 = new SubSystem2();
            SubSystem3 = new SubSystem3();
        }

        public void Sample()
        {
            SubSystem1.Foo();
            subSystem2.Bar();
        }

        public void DoWork()
        {
            SubSystem4.Zet();
        }

        public void Func()
        {
            SubSystem3.Tar();
        }
    }
}
