using State_Observer_Singleton.Abstract;
using State_Observer_Singleton.Context;
using System;

namespace State_Observer_Singleton.State.Concrete
{
    class WaitingState : IThreadState
    {
        // Singleton
        private static volatile WaitingState obj;
        private static object lockObj = new object();

        public static WaitingState GetObject
        {
            get
            {
                if (obj == null)
                    lock (lockObj)
                        if (obj == null)
                            obj = new WaitingState();
                return obj;
            }
        }

        private WaitingState() { }

        public void Run(ThreadContext context)
        {
            context.State = RunningState.GetObject;
            Console.WriteLine("Thread beklemedeyken tekrar çizelgeye sokuldu");

            context.Notify(context.ThreadId, ThreadStateMachine.StartState);
        }

        public void Stop(ThreadContext context)
        {
            context.State = StoppedState.GetObject;
            Console.WriteLine("Beklemedeki thread tümüyle durduruldu.");

            context.Notify(context.ThreadId, ThreadStateMachine.StopState);
        }

        public void Wait(ThreadContext context)
        {
            Console.WriteLine("Thread zaten beklemede");
        }
    }
}
