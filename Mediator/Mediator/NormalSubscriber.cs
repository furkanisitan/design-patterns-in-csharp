using System;

namespace Mediator
{
    class NormalSubscriber : Subscriber
    {
        public NormalSubscriber(string nick) : base(nick) { }

        public override void GetMessage(Subscriber sender, string message)
        {
            Console.WriteLine($"{sender.Nick} -> {Nick} : {message}");
        }
    }
}
