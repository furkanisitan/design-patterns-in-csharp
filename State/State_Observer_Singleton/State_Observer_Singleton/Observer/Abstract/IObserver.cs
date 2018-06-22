using State_Observer_Singleton.Context;

namespace State_Observer_Singleton.Observer.Abstract
{
    interface IObserver
    {
        void Handle(string threadId, ThreadStateMachine tsm);
    }
}
