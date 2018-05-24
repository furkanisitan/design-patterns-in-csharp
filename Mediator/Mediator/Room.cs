using System.Collections.Generic;

namespace Mediator
{
    abstract class Room
    {
        protected List<Subscriber> subscribers;

        public Room()
        {
            subscribers = new List<Subscriber>();
        }

        public void AddSubscriber(Subscriber subscriber)
        {
            if (!subscribers.Contains(subscriber))
                subscribers.Add(subscriber);
        }

        public abstract void SendMessage(Subscriber sender, Subscriber receiver, string message);
        public abstract void BroadcastSendMessage(Subscriber sender, string message);
    }
}

