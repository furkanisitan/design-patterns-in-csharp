
namespace Mediator
{
    abstract class Subscriber
    {
        public string Nick { get; set; }

        protected Subscriber(string nick)
        {
            Nick = nick;
        }

        public abstract void GetMessage(Subscriber sender, string message);

    }
}
