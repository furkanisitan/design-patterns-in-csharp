using State_Observer_Singleton.Abstract;
using State_Observer_Singleton.Context;
using System;

namespace State_Observer_Singleton.State.Concrete
{
    class RunningState : IThreadState
    {

        // Singleton
        private static volatile RunningState obj;
        private static object lockObj = new object();

        public static RunningState GetObject
        {
            get
            {
                if (obj == null)
                    lock (lockObj)
                        if (obj == null)
                            obj = new RunningState();
                return obj;
            }
        }

        private RunningState() { }

        public void Run(ThreadContext context)
        {
            Console.WriteLine("Thread zaten çalışır durumda");
        }

        public void Stop(ThreadContext context)
        {
            context.State = StoppedState.GetObject;
            Console.WriteLine("Thread durduruldu");

            context.Notify(context.ThreadId, ThreadStateMachine.StopState);
        }

        public void Wait(ThreadContext context)
        {
            context.State = WaitingState.GetObject;
            Console.WriteLine("Thread geçici olarak çizelgeleme dışına çıkarıldı.");

            context.Notify(context.ThreadId, ThreadStateMachine.WaitState);
        }
    }
}
