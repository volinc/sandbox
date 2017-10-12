using System;

namespace Forms.Services
{
    public interface IDrivingService
    {
        event EventHandler<string> Received;

        event EventHandler Started;

        event EventHandler Stoped;

        bool IsStarted { get; }

        void Start();

        void Stop();
    }
}