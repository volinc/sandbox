using System;

namespace Forms.Services
{
    public interface ITrackingService
    {
        int Value { get; }

        event EventHandler ValueChanged;

        event EventHandler Started;

        event EventHandler Stoped;

        void Start();

        void Stop();
    }
}
