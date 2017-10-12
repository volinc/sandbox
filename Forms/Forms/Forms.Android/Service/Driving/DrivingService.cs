using System;
using Forms.Services;

namespace Forms.Droid.Service.Driving
{
    internal class DrivingService : IDrivingService
    {
        public event EventHandler<string> Received;

        public event EventHandler Started;

        public event EventHandler Stoped;

        public bool IsStarted { get; private set; }

        public void Start()
        {
            if (IsStarted) return;

            IsStarted = true;
            Started?.Invoke(this, EventArgs.Empty);
        }

        public void Stop()
        {
            if (!IsStarted) return;

            IsStarted = false;
            Stoped?.Invoke(this, EventArgs.Empty);
        }
    }
}