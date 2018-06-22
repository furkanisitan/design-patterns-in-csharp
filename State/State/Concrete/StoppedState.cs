using State.Abstract;
using State.Context;
using System;

namespace State.Concrete
{
    class StoppedState : IThreadState
    {
        public void Run(ThreadContext context)
        {
            context.State = new RunningState();
            Console.WriteLine("Thread çalışmaya başladı");
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
