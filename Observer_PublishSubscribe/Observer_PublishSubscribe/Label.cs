
namespace Observer_PublishSubscribe
{
    class Label : Control
    {
        public override void Add(IObservable o)
        {
            o.Register(this);
        }

        public override void Remove(IObservable o)
        {
            o.UnRegister(this);
        }

        public override void OnAction(string val)
        {
            Text = val;
        }
       
    }
}
