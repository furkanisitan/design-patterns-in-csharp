using State.Abstract;
using State.Context;
using System;

namespace State.Concrete
{
    class WaitingState : IThreadState
    {
        public void Run(ThreadContext context)
        {
            context.State = new RunningState();
            Console.WriteLine("Thread beklemedeyken tekrar çizelgeye sokuldu");
        }

        public void Stop(ThreadContext context)
        {
            context.State = new StoppedState();
            Console.WriteLine("Beklemedeki thread tümüyle durduruldu");
        }

        public void Wait(ThreadContext context)
        {
            Console.WriteLine("Thread zaten beklemede");
        }
    }
}
