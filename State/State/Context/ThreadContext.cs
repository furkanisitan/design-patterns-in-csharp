using State.Abstract;
using State.Concrete;
using System;

namespace State.Context
{
    class ThreadContext
    {
        public IThreadState State { get; set; }

        public ThreadContext()
        {
            Console.WriteLine("Thread yaratıldı ve henüz çalışmıyor");
            State = new StoppedState();
        }

        public void Start()
        {
            State.Run(this);
        }

        public void Abort()
        {
            State.Stop(this);
        }
        public void Sleep()
        {
            State.Wait(this);
        }
    }
}
