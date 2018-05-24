
namespace Mediator
{
    // sealed => Kalıtım vermeyen sınıf. Bu sınıftan başka bir sınıt türetilemez

    sealed class SoftwareRoom : Room
    {
        public override void BroadcastSendMessage(Subscriber sender, string message)
        {
            foreach (Subscriber item in subscribers)
                item.GetMessage(sender, message);
        }

        public override void SendMessage(Subscriber sender, Subscriber receiver, string message)
        {
            receiver.GetMessage(sender, message);
        }
    }
}
