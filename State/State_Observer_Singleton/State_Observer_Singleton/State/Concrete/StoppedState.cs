using State_Observer_Singleton.Abstract;
using State_Observer_Singleton.Context;
using System;

namespace State_Observer_Singleton.State.Concrete
{
    class StoppedState : IThreadState
    {
        // Singleton
        private static volatile StoppedState obj;
        private static object lockObj = new object();

        public static StoppedState GetObject
        {
            get
            {
                if (obj == null)
                    lock (lockObj)
                        if (obj == null)
                            obj = new StoppedState();
                return obj;
            }
        }

        private StoppedState() { }

        public void Run(ThreadContext context)
        {
            context.State = RunningState.GetObject;
            Console.WriteLine("Thread çalışmaya başladı");

            context.Notify(context.ThreadId, ThreadStateMachine.StartState);
        }

        public void Stop(ThreadContext context)
        {
            Console.WriteLine("Thread zaten durdurulmuş");
        }

        public void Wait(ThreadContext context)
        {
            Console.WriteLine("Duran bir thread beklemeye alınamaz");
        }
    }
}
