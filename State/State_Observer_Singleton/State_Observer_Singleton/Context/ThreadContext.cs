using State_Observer_Singleton.Abstract;
using State_Observer_Singleton.Observer.Abstract;
using State_Observer_Singleton.State.Concrete;
using System;
using System.Collections.Generic;

namespace State_Observer_Singleton.Context
{
    class ThreadContext : IObservable
    {
        private List<IObserver> observers;

        public string ThreadId { get; }
        public IThreadState State { get; set; }

        public ThreadContext()
        {
            Console.WriteLine("Thread yaratıldı ve henüz çalışmıyor");
            ThreadId = Guid.NewGuid().ToString();
            State = StoppedState.GetObject;
            observers = new List<IObserver>();
        }

        // State paterni metodları

        public void Start() => State.Run(this);

        public void Abort() => State.Stop(this);

        public void Sleep() => State.Wait(this);

        // Observers paterni metodları

        public void Register(IObserver observer) => observers.Add(observer);

        public void UnRegister(IObserver observer) => observers.Remove(observer);

        public void Notify(string threadId, ThreadStateMachine tsm)
        {
            foreach (var item in observers)
                item.Handle(threadId, tsm);
        }
    }
}
