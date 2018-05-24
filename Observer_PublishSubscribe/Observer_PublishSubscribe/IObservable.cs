
namespace Observer_PublishSubscribe
{
    interface IObservable
    {
        void Register(Control control);
        void UnRegister(Control control);
        void Notify();
    }
}
