using State.Context;

namespace State.Abstract
{
    interface IThreadState
    {
        void Run(ThreadContext context);
        void Stop(ThreadContext context);
        void Wait(ThreadContext context);
    }
}
