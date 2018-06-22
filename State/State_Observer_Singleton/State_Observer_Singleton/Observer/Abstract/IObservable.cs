using State_Observer_Singleton.Context;

namespace State_Observer_Singleton.Observer.Abstract
{
    interface IObservable
    {
        void Register(IObserver observer);
        void UnRegister(IObserver observer);
        void Notify(string threadId, ThreadStateMachine tsm);
    }
}
