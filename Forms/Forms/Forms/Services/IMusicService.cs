using System;

namespace Forms.Services
{
    public interface IMusicService
    {
        event EventHandler Started;

        event EventHandler Stoped;

        bool IsStarted { get; }

        void Start();

        void Stop();
    }
}
