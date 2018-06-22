using State_Observer_Singleton.Context;
using State_Observer_Singleton.Observer.Abstract;
using System;

namespace State_Observer_Singleton.Observer.Concrete
{
    class ThreadMonitor : IObserver
    {
        public void Handle(string threadId, ThreadStateMachine tsm)
        {
            switch (tsm)
            {
                case ThreadStateMachine.StartState:
                    Console.WriteLine($"ThreadId: {threadId} running");
                    break;
                case ThreadStateMachine.StopState:
                    Console.WriteLine($"ThreadId: {threadId} stopped");
                    break;
                case ThreadStateMachine.WaitState:
                    Console.WriteLine($"ThreadId: {threadId} waiting");
                    break;
            }
        }
    }
}
