namespace ChainOfResponsibility
{
    class Client
    {
        public static void Call(CallCenter callCenter)
        {
            callCenter.GetCall();
        }
    }
}
