using System;

namespace Forms.Services
{
    public interface ITimingService
    {
        event EventHandler<int> ValueChanged;

        event EventHandler Started;

        event EventHandler Stoped;

        int Value { get; }

        bool IsStarted { get; }

        void Start();

        void Stop();
    }
}
