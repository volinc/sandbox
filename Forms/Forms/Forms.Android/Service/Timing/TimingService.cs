using System;
using System.Threading;
using Forms.Services;

namespace Forms.Droid.Service.Timing
{
    public class TimingService : ITimingService, IDisposable
    {
        public event EventHandler<int> ValueChanged;

        public event EventHandler Started;

        public event EventHandler Stoped;

        public int Value { get; private set; }

        public bool IsStarted { get; private set; }

        private readonly Timer _timer;

        public TimingService()
        {
            _timer = new Timer(state =>
            {
                ++Value;
                ValueChanged?.Invoke(this, Value);
            });
        }

        public void Start()
        {
            if (IsStarted) return;

            _timer.Change(TimeSpan.Zero, TimeSpan.FromSeconds(1));

            IsStarted = true;
            Started?.Invoke(this, EventArgs.Empty);
        }

        public void Stop()
        {
            if (!IsStarted) return;

            _timer.Change(Timeout.Infinite, Timeout.Infinite);

            IsStarted = false;
            Stoped?.Invoke(this, EventArgs.Empty);
        }

        public void Dispose()
        {
            _timer.Dispose();
        }
    }
}