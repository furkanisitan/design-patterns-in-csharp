using State_Observer_Singleton.Context;

namespace State_Observer_Singleton.Abstract
{
    interface IThreadState
    {
        void Run(ThreadContext context);
        void Stop(ThreadContext context);
        void Wait(ThreadContext context);
    }
}
