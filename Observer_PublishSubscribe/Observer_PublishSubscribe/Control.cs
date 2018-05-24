
namespace Observer_PublishSubscribe
{
    abstract class Control
    {
        public string Text { get; set; }
        public string Name { get; set; }
        
        // Durum değiştiğinde çalışacak metod
        public abstract void OnAction(string val);

        public abstract void Add(IObservable o);
        public abstract void Remove(IObservable o);
    }
}
