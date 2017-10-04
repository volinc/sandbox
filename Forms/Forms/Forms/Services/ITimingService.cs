using System;

namespace Forms.Services
{
    public interface ITimingService
    {
        int Value { get; }

        event EventHandler<int> ValueChanged;

        event EventHandler Started;

        event EventHandler Stoped;

        void Start();

        void Stop();
    }
}
