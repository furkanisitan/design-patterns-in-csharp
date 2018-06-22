using State.Abstract;
using State.Context;
using System;

namespace State.Concrete
{
    class RunningState : IThreadState
    {
        public void Run(ThreadContext context)
        {
            Console.WriteLine("Thread zaten çalışır durumda");
        }

        public void Stop(ThreadContext context)
        {
            context.State = new StoppedState();
            Console.WriteLine("Thread durduruldu");
        }

        public void Wait(ThreadContext context)
        {
            context.State = new WaitingState();
            Console.WriteLine("Thread geçici olarak çizelgeleme dışına çıkarıldı.");
        }
    }
}
